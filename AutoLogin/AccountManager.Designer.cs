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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManager));
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
            this.DIY_RBtn = new System.Windows.Forms.RadioButton();
            this.template_RBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.cB_template = new System.Windows.Forms.ComboBox();
            this.rBEmail = new System.Windows.Forms.RadioButton();
            this.rBUsername = new System.Windows.Forms.RadioButton();
            this.gB2 = new System.Windows.Forms.GroupBox();
            this.lblActivate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.gB1.SuspendLayout();
            this.gB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(12, 385);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(191, 53);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Back";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(12, 68);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(483, 306);
            this.dataGrid1.TabIndex = 3;
            // 
            // accNameLbl
            // 
            this.accNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNameLbl.Location = new System.Drawing.Point(12, 5);
            this.accNameLbl.Name = "accNameLbl";
            this.accNameLbl.Size = new System.Drawing.Size(340, 53);
            this.accNameLbl.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::AutoLogin.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(454, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 43);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(501, 49);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(178, 22);
            this.tbType.TabIndex = 6;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(501, 113);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(178, 22);
            this.tbInfo.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(501, 173);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(178, 22);
            this.tbEmail.TabIndex = 8;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(501, 233);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(178, 22);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(501, 292);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(178, 22);
            this.tbPassword.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(208, 385);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(287, 53);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add account";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "type";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(501, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "info";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(501, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(501, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "username";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(501, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "password";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(501, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "link";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(501, 352);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(178, 22);
            this.tbLink.TabIndex = 18;
            // 
            // DIY_RBtn
            // 
            this.DIY_RBtn.Checked = true;
            this.DIY_RBtn.Location = new System.Drawing.Point(3, 11);
            this.DIY_RBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DIY_RBtn.Name = "DIY_RBtn";
            this.DIY_RBtn.Size = new System.Drawing.Size(18, 16);
            this.DIY_RBtn.TabIndex = 19;
            this.DIY_RBtn.TabStop = true;
            this.DIY_RBtn.Text = "DIY";
            this.DIY_RBtn.UseVisualStyleBackColor = true;
            this.DIY_RBtn.CheckedChanged += new System.EventHandler(this.DIY_RBtn_CheckedChanged);
            // 
            // template_RBtn
            // 
            this.template_RBtn.Location = new System.Drawing.Point(3, 31);
            this.template_RBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.template_RBtn.Name = "template_RBtn";
            this.template_RBtn.Size = new System.Drawing.Size(18, 18);
            this.template_RBtn.TabIndex = 20;
            this.template_RBtn.Text = "template";
            this.template_RBtn.UseVisualStyleBackColor = true;
            this.template_RBtn.CheckedChanged += new System.EventHandler(this.template_RBtn_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(709, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "template";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(709, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "DIY";
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.template_RBtn);
            this.gB1.Controls.Add(this.DIY_RBtn);
            this.gB1.Location = new System.Drawing.Point(681, 31);
            this.gB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gB1.Name = "gB1";
            this.gB1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gB1.Size = new System.Drawing.Size(21, 53);
            this.gB1.TabIndex = 23;
            this.gB1.TabStop = false;
            this.gB1.Paint += new System.Windows.Forms.PaintEventHandler(this.gB1_Paint);
            // 
            // cB_template
            // 
            this.cB_template.FormattingEnabled = true;
            this.cB_template.Items.AddRange(new object[] { "Google", "Github", "Microsoft", "𝕏" });
            this.cB_template.Location = new System.Drawing.Point(501, 49);
            this.cB_template.Name = "cB_template";
            this.cB_template.Size = new System.Drawing.Size(178, 24);
            this.cB_template.TabIndex = 24;
            this.cB_template.Visible = false;
            this.cB_template.SelectedIndexChanged += new System.EventHandler(this.cB_template_SelectedIndexChanged);
            // 
            // rBEmail
            // 
            this.rBEmail.Checked = true;
            this.rBEmail.Location = new System.Drawing.Point(6, 9);
            this.rBEmail.Name = "rBEmail";
            this.rBEmail.Size = new System.Drawing.Size(16, 16);
            this.rBEmail.TabIndex = 25;
            this.rBEmail.TabStop = true;
            this.rBEmail.Text = "radioButton1";
            this.rBEmail.UseVisualStyleBackColor = true;
            this.rBEmail.CheckedChanged += new System.EventHandler(this.rBEmail_CheckedChanged);
            // 
            // rBUsername
            // 
            this.rBUsername.Location = new System.Drawing.Point(5, 67);
            this.rBUsername.Name = "rBUsername";
            this.rBUsername.Size = new System.Drawing.Size(16, 16);
            this.rBUsername.TabIndex = 26;
            this.rBUsername.Text = "radioButton2";
            this.rBUsername.UseVisualStyleBackColor = true;
            this.rBUsername.CheckedChanged += new System.EventHandler(this.rBUsername_CheckedChanged);
            // 
            // gB2
            // 
            this.gB2.Controls.Add(this.rBUsername);
            this.gB2.Controls.Add(this.rBEmail);
            this.gB2.Location = new System.Drawing.Point(676, 167);
            this.gB2.Name = "gB2";
            this.gB2.Size = new System.Drawing.Size(29, 88);
            this.gB2.TabIndex = 27;
            this.gB2.TabStop = false;
            this.gB2.Paint += new System.Windows.Forms.PaintEventHandler(this.gB2_Paint);
            // 
            // lblActivate
            // 
            this.lblActivate.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblActivate.Location = new System.Drawing.Point(709, 203);
            this.lblActivate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivate.Name = "lblActivate";
            this.lblActivate.Size = new System.Drawing.Size(146, 27);
            this.lblActivate.TabIndex = 28;
            this.lblActivate.Text = "needed";
            this.lblActivate.Click += new System.EventHandler(this.lblActivate_Click);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.lblActivate);
            this.Controls.Add(this.gB2);
            this.Controls.Add(this.cB_template);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountManager_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.gB1.ResumeLayout(false);
            this.gB2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblActivate;

        private System.Windows.Forms.RadioButton rBEmail;
        private System.Windows.Forms.RadioButton rBUsername;
        private System.Windows.Forms.GroupBox gB2;

        private System.Windows.Forms.ComboBox cB_template;

        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.RadioButton DIY_RBtn;
        private System.Windows.Forms.RadioButton template_RBtn;
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

        private System.Windows.Forms.Button cancelBtn;

        #endregion
    }
}