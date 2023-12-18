namespace AutoLogin
{
    partial class ForgotPW
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
        private void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPW));
            this.dashboard_label_title = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotpw_textbox_email = new System.Windows.Forms.TextBox();
            this.forgotpw_textbox_newpw = new System.Windows.Forms.TextBox();
            this.forgotpw_textbox_emailcode = new System.Windows.Forms.TextBox();
            this.forgotpw_button_emailcode = new System.Windows.Forms.Button();
            this.forgotpw_button_submit = new System.Windows.Forms.Button();
            this.forgotpw_button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboard_label_title
            // 
            this.dashboard_label_title.Font = new System.Drawing.Font("Trebuchet MS", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_label_title.Location = new System.Drawing.Point(36, 14);
            this.dashboard_label_title.Name = "dashboard_label_title";
            this.dashboard_label_title.Size = new System.Drawing.Size(740, 98);
            this.dashboard_label_title.TabIndex = 2;
            this.dashboard_label_title.Text = "Forgot Password?";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(46, 156);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(51, 16);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "E-Mail :";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-Mail code :";
            // 
            // forgotpw_textbox_email
            // 
            this.forgotpw_textbox_email.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.forgotpw_textbox_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.forgotpw_textbox_email.Location = new System.Drawing.Point(212, 152);
            this.forgotpw_textbox_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forgotpw_textbox_email.Name = "forgotpw_textbox_email";
            this.forgotpw_textbox_email.Size = new System.Drawing.Size(301, 31);
            this.forgotpw_textbox_email.TabIndex = 7;
            // 
            // forgotpw_textbox_newpw
            // 
            this.forgotpw_textbox_newpw.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.forgotpw_textbox_newpw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.forgotpw_textbox_newpw.Location = new System.Drawing.Point(212, 230);
            this.forgotpw_textbox_newpw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forgotpw_textbox_newpw.Name = "forgotpw_textbox_newpw";
            this.forgotpw_textbox_newpw.Size = new System.Drawing.Size(301, 31);
            this.forgotpw_textbox_newpw.TabIndex = 8;
            // 
            // forgotpw_textbox_emailcode
            // 
            this.forgotpw_textbox_emailcode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.forgotpw_textbox_emailcode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.forgotpw_textbox_emailcode.Location = new System.Drawing.Point(212, 309);
            this.forgotpw_textbox_emailcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forgotpw_textbox_emailcode.Name = "forgotpw_textbox_emailcode";
            this.forgotpw_textbox_emailcode.Size = new System.Drawing.Size(301, 31);
            this.forgotpw_textbox_emailcode.TabIndex = 9;
            // 
            // forgotpw_button_emailcode
            // 
            this.forgotpw_button_emailcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forgotpw_button_emailcode.Location = new System.Drawing.Point(524, 152);
            this.forgotpw_button_emailcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forgotpw_button_emailcode.Name = "forgotpw_button_emailcode";
            this.forgotpw_button_emailcode.Size = new System.Drawing.Size(165, 36);
            this.forgotpw_button_emailcode.TabIndex = 10;
            this.forgotpw_button_emailcode.Text = "Send code";
            this.forgotpw_button_emailcode.UseVisualStyleBackColor = true;
            // 
            // forgotpw_button_submit
            // 
            this.forgotpw_button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotpw_button_submit.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpw_button_submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.forgotpw_button_submit.Location = new System.Drawing.Point(110, 367);
            this.forgotpw_button_submit.Name = "forgotpw_button_submit";
            this.forgotpw_button_submit.Size = new System.Drawing.Size(218, 55);
            this.forgotpw_button_submit.TabIndex = 11;
            this.forgotpw_button_submit.Text = "Submit";
            this.forgotpw_button_submit.UseVisualStyleBackColor = true;
            // 
            // forgotpw_button_exit
            // 
            this.forgotpw_button_exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.forgotpw_button_exit.Location = new System.Drawing.Point(358, 367);
            this.forgotpw_button_exit.Name = "forgotpw_button_exit";
            this.forgotpw_button_exit.Size = new System.Drawing.Size(208, 55);
            this.forgotpw_button_exit.TabIndex = 12;
            this.forgotpw_button_exit.Text = "Exit";
            this.forgotpw_button_exit.UseVisualStyleBackColor = false;
            // 
            // ForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(706, 423);
            this.Controls.Add(this.forgotpw_button_exit);
            this.Controls.Add(this.forgotpw_button_submit);
            this.Controls.Add(this.forgotpw_button_emailcode);
            this.Controls.Add(this.forgotpw_textbox_emailcode);
            this.Controls.Add(this.forgotpw_textbox_newpw);
            this.Controls.Add(this.forgotpw_textbox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dashboard_label_title);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ForgotPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPW";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label dashboard_label_title;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox forgotpw_textbox_email;
        private System.Windows.Forms.TextBox forgotpw_textbox_newpw;
        private System.Windows.Forms.TextBox forgotpw_textbox_emailcode;
        private System.Windows.Forms.Button forgotpw_button_emailcode;
        private System.Windows.Forms.Button forgotpw_button_submit;
        private System.Windows.Forms.Button forgotpw_button_exit;
    }
}