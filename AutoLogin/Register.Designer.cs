namespace AutoLogin
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
            this.textBoxRegisterUsername = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPasswordCheck = new System.Windows.Forms.TextBox();
            this.labelRegisterEmail = new System.Windows.Forms.Label();
            this.labelRegisterUsername = new System.Windows.Forms.Label();
            this.labelRegisterCheckPassword = new System.Windows.Forms.Label();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.buttonRegisterSubmit = new System.Windows.Forms.Button();
            this.labelRegisterPasswordSafety = new System.Windows.Forms.Label();
            this.labelRegisterRegistration = new System.Windows.Forms.Label();
            this.labelRegisterPasswordWrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRegisterEmail
            // 
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(216, 125);
            this.textBoxRegisterEmail.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            this.textBoxRegisterEmail.Size = new System.Drawing.Size(196, 31);
            this.textBoxRegisterEmail.TabIndex = 0;
            // 
            // textBoxRegisterUsername
            // 
            this.textBoxRegisterUsername.Location = new System.Drawing.Point(216, 175);
            this.textBoxRegisterUsername.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRegisterUsername.Name = "textBoxRegisterUsername";
            this.textBoxRegisterUsername.Size = new System.Drawing.Size(196, 31);
            this.textBoxRegisterUsername.TabIndex = 1;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(216, 225);
            this.textBoxRegisterPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(196, 31);
            this.textBoxRegisterPassword.TabIndex = 2;
            // 
            // textBoxRegisterPasswordCheck
            // 
            this.textBoxRegisterPasswordCheck.Location = new System.Drawing.Point(216, 275);
            this.textBoxRegisterPasswordCheck.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRegisterPasswordCheck.Name = "textBoxRegisterPasswordCheck";
            this.textBoxRegisterPasswordCheck.PasswordChar = '*';
            this.textBoxRegisterPasswordCheck.Size = new System.Drawing.Size(196, 31);
            this.textBoxRegisterPasswordCheck.TabIndex = 3;
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Location = new System.Drawing.Point(24, 131);
            this.labelRegisterEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(79, 25);
            this.labelRegisterEmail.TabIndex = 4;
            this.labelRegisterEmail.Text = "E-Mail:";
            // 
            // labelRegisterUsername
            // 
            this.labelRegisterUsername.AutoSize = true;
            this.labelRegisterUsername.Location = new System.Drawing.Point(24, 181);
            this.labelRegisterUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegisterUsername.Name = "labelRegisterUsername";
            this.labelRegisterUsername.Size = new System.Drawing.Size(116, 25);
            this.labelRegisterUsername.TabIndex = 5;
            this.labelRegisterUsername.Text = "Username:";
            // 
            // labelRegisterCheckPassword
            // 
            this.labelRegisterCheckPassword.AutoSize = true;
            this.labelRegisterCheckPassword.Location = new System.Drawing.Point(24, 281);
            this.labelRegisterCheckPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegisterCheckPassword.Name = "labelRegisterCheckPassword";
            this.labelRegisterCheckPassword.Size = new System.Drawing.Size(179, 25);
            this.labelRegisterCheckPassword.TabIndex = 6;
            this.labelRegisterCheckPassword.Text = "Check Password:";
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Location = new System.Drawing.Point(24, 231);
            this.labelRegisterPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(112, 25);
            this.labelRegisterPassword.TabIndex = 7;
            this.labelRegisterPassword.Text = "Password:";
            // 
            // buttonRegisterSubmit
            // 
            this.buttonRegisterSubmit.Location = new System.Drawing.Point(266, 365);
            this.buttonRegisterSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRegisterSubmit.Name = "buttonRegisterSubmit";
            this.buttonRegisterSubmit.Size = new System.Drawing.Size(150, 44);
            this.buttonRegisterSubmit.TabIndex = 8;
            this.buttonRegisterSubmit.Text = "Submit";
            this.buttonRegisterSubmit.UseVisualStyleBackColor = true;
            this.buttonRegisterSubmit.Click += new System.EventHandler(this.buttonRegisterSubmit_Click);
            // 
            // labelRegisterPasswordSafety
            // 
            this.labelRegisterPasswordSafety.AutoSize = true;
            this.labelRegisterPasswordSafety.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterPasswordSafety.Location = new System.Drawing.Point(428, 231);
            this.labelRegisterPasswordSafety.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegisterPasswordSafety.Name = "labelRegisterPasswordSafety";
            this.labelRegisterPasswordSafety.Size = new System.Drawing.Size(239, 25);
            this.labelRegisterPasswordSafety.TabIndex = 9;
            this.labelRegisterPasswordSafety.Text = "Password Not Available";
            this.labelRegisterPasswordSafety.Visible = false;
            // 
            // labelRegisterRegistration
            // 
            this.labelRegisterRegistration.AutoSize = true;
            this.labelRegisterRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterRegistration.Location = new System.Drawing.Point(186, 17);
            this.labelRegisterRegistration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegisterRegistration.Name = "labelRegisterRegistration";
            this.labelRegisterRegistration.Size = new System.Drawing.Size(256, 48);
            this.labelRegisterRegistration.TabIndex = 10;
            this.labelRegisterRegistration.Text = "Registration";
            // 
            // labelRegisterPasswordWrong
            // 
            this.labelRegisterPasswordWrong.AutoSize = true;
            this.labelRegisterPasswordWrong.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterPasswordWrong.Location = new System.Drawing.Point(428, 281);
            this.labelRegisterPasswordWrong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegisterPasswordWrong.Name = "labelRegisterPasswordWrong";
            this.labelRegisterPasswordWrong.Size = new System.Drawing.Size(175, 25);
            this.labelRegisterPasswordWrong.TabIndex = 11;
            this.labelRegisterPasswordWrong.Text = "Password Wrong";
            this.labelRegisterPasswordWrong.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 433);
            this.Controls.Add(this.labelRegisterPasswordWrong);
            this.Controls.Add(this.labelRegisterRegistration);
            this.Controls.Add(this.labelRegisterPasswordSafety);
            this.Controls.Add(this.buttonRegisterSubmit);
            this.Controls.Add(this.labelRegisterPassword);
            this.Controls.Add(this.labelRegisterCheckPassword);
            this.Controls.Add(this.labelRegisterUsername);
            this.Controls.Add(this.labelRegisterEmail);
            this.Controls.Add(this.textBoxRegisterPasswordCheck);
            this.Controls.Add(this.textBoxRegisterPassword);
            this.Controls.Add(this.textBoxRegisterUsername);
            this.Controls.Add(this.textBoxRegisterEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRegisterEmail;
        private System.Windows.Forms.TextBox textBoxRegisterUsername;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterPasswordCheck;
        private System.Windows.Forms.Label labelRegisterEmail;
        private System.Windows.Forms.Label labelRegisterUsername;
        private System.Windows.Forms.Label labelRegisterCheckPassword;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Button buttonRegisterSubmit;
        private System.Windows.Forms.Label labelRegisterPasswordSafety;
        private System.Windows.Forms.Label labelRegisterRegistration;
        private System.Windows.Forms.Label labelRegisterPasswordWrong;
    }
}