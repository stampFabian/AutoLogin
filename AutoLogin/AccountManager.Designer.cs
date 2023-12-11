﻿using System.ComponentModel;

namespace AutoLogin
{
    partial class AccountManager
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
        private void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManager));
            this.saveBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.accNameLbl = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gB1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.gB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(604, 602);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(286, 83);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // undoBtn
            // 
            this.undoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoBtn.Location = new System.Drawing.Point(14, 602);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(286, 83);
            this.undoBtn.TabIndex = 1;
            this.undoBtn.Text = "undo changes";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(309, 602);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(286, 83);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(36, 130);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(686, 419);
            this.dataGrid1.TabIndex = 3;
            // 
            // accNameLbl
            // 
            this.accNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNameLbl.Location = new System.Drawing.Point(36, 28);
            this.accNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accNameLbl.Name = "accNameLbl";
            this.accNameLbl.Size = new System.Drawing.Size(510, 83);
            this.accNameLbl.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::AutoLogin.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(440, 20);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 67);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(752, 83);
            this.tbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(265, 31);
            this.tbType.TabIndex = 6;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(752, 177);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(265, 31);
            this.tbInfo.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(752, 270);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(265, 31);
            this.tbEmail.TabIndex = 8;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(752, 364);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(265, 31);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(752, 456);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(265, 31);
            this.tbPassword.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(900, 602);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(286, 83);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "type";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "info";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(752, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 50);
            this.label3.TabIndex = 14;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 50);
            this.label4.TabIndex = 15;
            this.label4.Text = "username";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(752, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 50);
            this.label5.TabIndex = 16;
            this.label5.Text = "password";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(752, 495);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 50);
            this.label6.TabIndex = 17;
            this.label6.Text = "link";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(752, 550);
            this.tbLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(265, 31);
            this.tbLink.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(12, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(20, 21);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(12, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(20, 21);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(721, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "template";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(721, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "DIY";
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.radioButton2);
            this.gB1.Controls.Add(this.radioButton1);
            this.gB1.Location = new System.Drawing.Point(683, 14);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(38, 80);
            this.gB1.TabIndex = 23;
            this.gB1.TabStop = false;
            this.gB1.Paint += new System.Windows.Forms.PaintEventHandler(this.gB1_Paint);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.gB1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.accNameLbl);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountManager";
            this.Text = "Auto Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountManager_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.gB1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLink;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbEmail;

        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Label accNameLbl;

        private System.Windows.Forms.DataGrid dataGrid1;

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button cancelBtn;

        #endregion
    }
}