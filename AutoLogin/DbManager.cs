﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DatabaseManager {
    public class DbManager {
        //Management class for databases
        public static string connectionString, server, database, inteSec, uname, psw;
        public static MySqlConnection activeCon;

        //Open a connection if the connectionString is already set
        public async static Task<bool> openConnection() {
            if (connectionString.Equals("")) return false;
            activeCon = new MySqlConnection(connectionString);
            try {
                activeCon.Open();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }


        //Closes an active connection if available
        public static void closeConnection() {
            if (activeCon.State == System.Data.ConnectionState.Open)
                activeCon.Close();
        }
         

        //If all the variables are filled, this methode will convert them to a valid connection string
        public static void convertToConStrg(bool integratedSecurity) {
            if(integratedSecurity) {
                //Creating the string with integrated Security
                if (server.Equals("") || database.Equals("") || inteSec.Equals("")) return;
                connectionString = "Server = " + server + "; Database = " + database + "; Integrated Security = " + inteSec + ";";
            } else {
                //Creating the string WITHOUT integrated Security
                if (server.Equals("") || database.Equals("") || uname.Equals("") || psw.Equals("")) return;
                connectionString = "Server = " + server + "; Database = " + database + "; Uid = " + uname + "; Pwd = " + psw + ";";
            }
        }

        //----------------------------------------- DATABASES

        //To check if a database with a passed name is existing
        public static bool checkIfDbExists(string dbName) {
            MySqlConnection con = new MySqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database = Master; integrated security = true");
            con.Open();
            MySqlCommand checkCmd = new MySqlCommand("select * from sys.databases", con);
            MySqlDataReader checkReader = checkCmd.ExecuteReader();
            while (checkReader.Read()) {
                //Console.WriteLine(checkReader.GetString(0));
                if(checkReader.GetString(0).ToLower().Equals(dbName.ToLower())) {
                    return true;
                }
            }
            checkReader.Close();
            con.Close();
            return false;
        }
        
        //To get a list of all existing databases
        public List<String> getDatabases() {
            MySqlCommand cmd = new MySqlCommand("select * from sys.databases", activeCon);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<String> Databases = new List<string>();
            while (reader.Read()) {
                Databases.Add(reader.GetString(0));
            }
            reader.Close();
            return Databases;
        }
        //To create a new Database with a given name
        public static void createDatabase(string dbName) {
            MySqlConnection createCon = new MySqlConnection("Server=(localdb)\\MSSQLLocalDB;Integrated security=SSPI;database=master");
            string createConStr = "CREATE DATABASE " + dbName;
            MySqlCommand createCmd = new MySqlCommand(createConStr, createCon);
            createCon.Open();
            createCmd.ExecuteNonQuery();
            createCon.Close();
        }
        //To delete a database with a given name
        public static void deleteDatabase(string dbName) {
            MySqlConnection deleteCon = new MySqlConnection("Server=(localdb)\\MSSQLLocalDB;Integrated security=SSPI;database=master");
            string delDbStr = "DROP DATABASE IF EXISTS " + dbName;
            MySqlCommand delCmd = new MySqlCommand(delDbStr, deleteCon);
            deleteCon.Open();
            delCmd.ExecuteNonQuery();
            deleteCon.Close();
        }
        //To change the name of a database
        public static void changeDatabaseName(string dbName, string newDbName) {
            MySqlConnection changeNameCon = new MySqlConnection("Server=(localdb)\\MSSQLLocalDB;Integrated security=SSPI;database=master");
            string changeDbNameStr = "ALTER DATABASE " + dbName + " MODIFY NAME = " + newDbName;
            MySqlCommand changeCmd = new MySqlCommand(changeDbNameStr, changeNameCon);
            changeNameCon.Open();
            changeCmd.ExecuteNonQuery();
            changeNameCon.Close();
        }

        //----------------------------------------- TABLES

        //An table will be created if an active connection is given
        //Needs three lists: First one is the names of the collums, Second one is the type of the collums, Third one is if the collum can be null
        public static async Task createTable(string tableName, List<string> names, List<string> types, List<string> canNull) {
            if (names.Count() != types.Count() || names.Count() != canNull.Count() || types.Count() != canNull.Count()) return;
            List<string> variables = new List<string>();
            for (int i = 0; i<names.Count(); i++) {
                variables.Add(names[i]);
                variables.Add(types[i]);
                if (!(types.Count() - 1 == i)) {
                    variables.Add(canNull[i] + ",");
                } else {
                    variables.Add(canNull[i]);
                }
            }
            string variablesString = string.Join(" ", variables.ToArray());
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE " + tableName + " (" + variablesString +")", activeCon);
            await cmd.ExecuteNonQueryAsync();
        }
        public static async Task<bool> createPasswordTable(string tblName, string clmId, string clmUsername, string clmPassword) {
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE " + tblName + " (" + clmId + " INT AUTO_INCREMENT, " + clmUsername + " VARCHAR(255), " + clmPassword + " VARCHAR(110), email VARCHAR(255), PRIMARY KEY (" + clmId + "))", activeCon);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        //An table will be deleted if an active connection is given
        public static void deleteTable(string tableName) {
            MySqlCommand cmd = new MySqlCommand("DROP TABLE IF EXISTS " + tableName, activeCon);
            cmd.ExecuteNonQuery();
        }

        //To rename a table
        public static void renameTable(string name, string newName) {
            MySqlCommand cmd = new MySqlCommand("ALTER TABLE " + name + " RENAME TO " + newName, activeCon);
            cmd.ExecuteNonQuery();
        }

        //To add a column in an table if a connection is opened
        public static void addColumnToTable(string tableName, string name, string type, string canNull) {
            MySqlCommand cmd = new MySqlCommand("ALTER TABLE " + tableName + " ADD " + name + " " + type + " " + canNull, activeCon);
                cmd.ExecuteNonQuery();
        }
        //To delete a column in an table if a connection is opened
        public static void deleteColumnFromTable(string tableName, string name) {
            MySqlCommand cmd = new MySqlCommand("ALTER TABLE " + tableName + " DROP COLUMN " + name, activeCon);
            cmd.ExecuteNonQuery();
        }
        //To check if a Table is existing in a Connected Database
        public async static Task<bool> checkIfTableExists(string tableName) {
            MySqlCommand cmd = new MySqlCommand("SELECT table_name FROM information_schema.tables", activeCon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                string currentTableName = reader["table_name"].ToString(); // Hier wird der Alias verwendet
                if (currentTableName.ToLower().Equals(tableName.ToLower())) {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }


        public static void testExecute() {
            //where name = 'newAignerDB'
            //select * from sys.databases
            //IF EXISTS (SELECT NAME FROM master.dbo.sysdatabases WHERE NAME = 'newAignerDB' ) //
            //SqlCommand cmd = new SqlCommand("alter table passwords alter column id  auto_increment", activeCon);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read()) {
            //   Console.WriteLine(reader.GetString(0));
            //}
            //Console.ReadLine();
            //reader.Close();
            //cmd.ExecuteNonQuery();
        }

        //To

        //----------------------------------------- DATA

        //Data will be added to an table if available and if an active connection is given
        public static async Task<bool> addDataToTable(string tableName, List<string> collumns, List<string> values) {
            try
            {
                string sCollumns = string.Format("{0}", string.Join(", ", collumns));
                string sValues = string.Format("'{0}'", string.Join("', '", values));
                MySqlCommand cmd = new MySqlCommand("INSERT INTO " + tableName + " (" + sCollumns + ") VALUES (" + sValues + ")", activeCon);
                await cmd.ExecuteNonQueryAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                return false;
            }
            
        }

        public static bool addDataToPswTable(string tableName, string username, string password, string email)
        {
            MySqlCommand readerCmd = new MySqlCommand("SELECT username FROM " + tableName, activeCon);
            MySqlDataReader reader = readerCmd.ExecuteReader();
    
            while (reader.Read())
            {
                if (reader.GetString(0).Equals(username))
                {
                    reader.Close();
                    return false; // Username already exists, so return false.
                }
            }
            reader.Close();

            string hash = ToSHA256(password);
    
            // Explicitly specify the columns you want to insert data into.
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + tableName + " (username, hashed_password, email) VALUES ('" + username + "', '" + hash + "','" + email + "')", activeCon);

            cmd.ExecuteNonQuery();
            return true; // Successfully inserted data.
        }


        //To check if a user with a password is in a password table
        public async static Task<int> checkPasswordUser(string tableName, string username, string password) {
            MySqlCommand cmd = new MySqlCommand("SELECT uid, hashed_password FROM " + tableName + " where username = '" + username + "'", activeCon);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> passwords = new List<string>();
            int i = 0;
            while (reader.Read()) {
                string h = ToSHA256(password);
                if(h.Equals(reader.GetString(i + 1)))
                {
                    int uid = reader.GetInt32(i);
                    reader.Close();
                    return uid;
                }
                i++;
            }
            reader.Close();
            return 0;
        }
        //To get the ID from User off an Password Table
        public static int getUserIdPasswordTable(string tableName, string username, string password) {
            MySqlCommand cmd = new MySqlCommand("SELECT Id FROM " + tableName + " WHERE Username = '" + username + "'", activeCon);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int i = reader.GetInt32(0);
            reader.Close();
            return i;
        }

        //Date will be deleted from a Table. To define which row is meant, you have to tell which collumn (e.g. ID) and data (e.g. 15 (ID))
        public static void deleteDataFromTable(string tableName, string column, string content) {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM " + tableName + " WHERE " + column + " = " + content, activeCon);
            cmd.ExecuteNonQuery();
        }


        // ----------------------------------------- HASHING
        public static string ToSHA256(string psw) {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(psw));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++) {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /*
        public static void databaseFilePut(string varFilePath)
        {
            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            using (var varConnection = activeCon)
            using (var sqlWrite = new MySqlCommand("INSERT INTO Data (doc) Values(@File)", varConnection))
            {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                sqlWrite.ExecuteNonQuery();
            }
        }
        */

    }
}
