using System.ComponentModel;

namespace AutoLogin
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dashboard_label_title = new System.Windows.Forms.Label();
            this.dashboard_label_combolbl = new System.Windows.Forms.Label();
            this.dashboard_button_login = new System.Windows.Forms.Button();
            this.dashboard_button_edit = new System.Windows.Forms.Button();
            this.dashboard_lbl_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 140);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // dashboard_label_title
            // 
            this.dashboard_label_title.Font = new System.Drawing.Font("Trebuchet MS", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_label_title.Location = new System.Drawing.Point(59, 26);
            this.dashboard_label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboard_label_title.Name = "dashboard_label_title";
            this.dashboard_label_title.Size = new System.Drawing.Size(460, 51);
            this.dashboard_label_title.TabIndex = 1;
            this.dashboard_label_title.Text = "Dashboard";
            // 
            // dashboard_label_combolbl
            // 
            this.dashboard_label_combolbl.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_label_combolbl.Location = new System.Drawing.Point(68, 114);
            this.dashboard_label_combolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboard_label_combolbl.Name = "dashboard_label_combolbl";
            this.dashboard_label_combolbl.Size = new System.Drawing.Size(311, 24);
            this.dashboard_label_combolbl.TabIndex = 2;
            this.dashboard_label_combolbl.Text = "Zum anmelden auswählen";
            // 
            // dashboard_button_login
            // 
            this.dashboard_button_login.Font = new System.Drawing.Font("Trebuchet MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button_login.Location = new System.Drawing.Point(68, 173);
            this.dashboard_button_login.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard_button_login.Name = "dashboard_button_login";
            this.dashboard_button_login.Size = new System.Drawing.Size(312, 51);
            this.dashboard_button_login.TabIndex = 3;
            this.dashboard_button_login.Text = "Anmelden";
            this.dashboard_button_login.UseVisualStyleBackColor = true;
            // 
            // dashboard_button_edit
            // 
            this.dashboard_button_edit.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button_edit.Location = new System.Drawing.Point(68, 236);
            this.dashboard_button_edit.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard_button_edit.Name = "dashboard_button_edit";
            this.dashboard_button_edit.Size = new System.Drawing.Size(145, 35);
            this.dashboard_button_edit.TabIndex = 4;
            this.dashboard_button_edit.Text = "Bearbeiten";
            this.dashboard_button_edit.UseVisualStyleBackColor = true;
            this.dashboard_button_edit.Click += new System.EventHandler(this.dashboard_button_edit_Click);
            // 
            // dashboard_lbl_username
            // 
            this.dashboard_lbl_username.Location = new System.Drawing.Point(68, 80);
            this.dashboard_lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboard_lbl_username.Name = "dashboard_lbl_username";
            this.dashboard_lbl_username.Size = new System.Drawing.Size(235, 19);
            this.dashboard_lbl_username.TabIndex = 5;
            this.dashboard_lbl_username.Click += new System.EventHandler(this.dashboard_lbl_username_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dashboard_lbl_username);
            this.Controls.Add(this.dashboard_button_edit);
            this.Controls.Add(this.dashboard_button_login);
            this.Controls.Add(this.dashboard_label_combolbl);
            this.Controls.Add(this.dashboard_label_title);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label dashboard_lbl_username;

        private System.Windows.Forms.Button dashboard_button_edit;

        private System.Windows.Forms.Label dashboard_label_combolbl;
        private System.Windows.Forms.Button dashboard_button_login;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dashboard_label_title;

        #endregion
    }
}