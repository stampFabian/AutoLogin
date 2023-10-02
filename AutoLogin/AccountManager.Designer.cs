using System.ComponentModel;

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
            this.saveBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.accNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(551, 385);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(228, 53);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(289, 385);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(228, 53);
            this.undoBtn.TabIndex = 1;
            this.undoBtn.Text = "undo changes";
            this.undoBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(24, 385);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(228, 53);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(113, 84);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(577, 268);
            this.dataGrid1.TabIndex = 3;
            this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
            // 
            // accNameLbl
            // 
            this.accNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNameLbl.Location = new System.Drawing.Point(24, 28);
            this.accNameLbl.Name = "accNameLbl";
            this.accNameLbl.Size = new System.Drawing.Size(154, 43);
            this.accNameLbl.TabIndex = 4;
            this.accNameLbl.Text = "see btn name";
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accNameLbl);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label accNameLbl;

        private System.Windows.Forms.DataGrid dataGrid1;

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button cancelBtn;

        #endregion
    }
}