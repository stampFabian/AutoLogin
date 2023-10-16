using System.ComponentModel;

namespace AutoLogin
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonLoginRegister = new System.Windows.Forms.Button();
            this.labelLoginRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(336, 223);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 44);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.Location = new System.Drawing.Point(184, 119);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(298, 31);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxUsername.Location = new System.Drawing.Point(184, 69);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(298, 31);
            this.textBoxUsername.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(50, 75);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(122, 25);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Usarname :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPassword.Location = new System.Drawing.Point(50, 125);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(118, 25);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password :";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(42, 233);
            this.labelError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(279, 25);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Usarname/Password Wrong";
            this.labelError.Visible = false;
            // 
            // buttonLoginRegister
            // 
            this.buttonLoginRegister.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLoginRegister.FlatAppearance.BorderSize = 0;
            this.buttonLoginRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoginRegister.Location = new System.Drawing.Point(336, 279);
            this.buttonLoginRegister.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLoginRegister.Name = "buttonLoginRegister";
            this.buttonLoginRegister.Size = new System.Drawing.Size(150, 44);
            this.buttonLoginRegister.TabIndex = 3;
            this.buttonLoginRegister.Text = "Register";
            this.buttonLoginRegister.UseVisualStyleBackColor = false;
            this.buttonLoginRegister.Click += new System.EventHandler(this.buttonLoginRegister_Click);
            // 
            // labelLoginRegister
            // 
            this.labelLoginRegister.AutoSize = true;
            this.labelLoginRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLoginRegister.Location = new System.Drawing.Point(50, 288);
            this.labelLoginRegister.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLoginRegister.Name = "labelLoginRegister";
            this.labelLoginRegister.Size = new System.Drawing.Size(276, 25);
            this.labelLoginRegister.TabIndex = 7;
            this.labelLoginRegister.Text = "No Account? Register here:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(516, 350);
            this.Controls.Add(this.labelLoginRegister);
            this.Controls.Add(this.buttonLoginRegister);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonLoginRegister;
        private System.Windows.Forms.Label labelLoginRegister;
    }
}