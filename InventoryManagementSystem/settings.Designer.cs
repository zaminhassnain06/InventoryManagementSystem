namespace InventoryManagementSystem
{
    partial class settings
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
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.labelDB = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkBoxIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panelRightTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.buttonSave);
            this.LeftPanel.Controls.Add(this.checkBoxIntegratedSecurity);
            this.LeftPanel.Controls.Add(this.textBoxPassword);
            this.LeftPanel.Controls.Add(this.labelPassword);
            this.LeftPanel.Controls.Add(this.textBoxUserId);
            this.LeftPanel.Controls.Add(this.labelUserId);
            this.LeftPanel.Controls.Add(this.textBoxDB);
            this.LeftPanel.Controls.Add(this.labelDB);
            this.LeftPanel.Controls.Add(this.textBoxServer);
            this.LeftPanel.Controls.Add(this.labelServer);
            this.LeftPanel.Size = new System.Drawing.Size(250, 630);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelServer, 0);
            this.LeftPanel.Controls.SetChildIndex(this.textBoxServer, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelDB, 0);
            this.LeftPanel.Controls.SetChildIndex(this.textBoxDB, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelUserId, 0);
            this.LeftPanel.Controls.SetChildIndex(this.textBoxUserId, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelPassword, 0);
            this.LeftPanel.Controls.SetChildIndex(this.textBoxPassword, 0);
            this.LeftPanel.Controls.SetChildIndex(this.checkBoxIntegratedSecurity, 0);
            this.LeftPanel.Controls.SetChildIndex(this.buttonSave, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1112, 579);
            // 
            // panelRightTop
            // 
            this.panelRightTop.Size = new System.Drawing.Size(1112, 55);
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(12, 269);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(39, 15);
            this.labelServer.TabIndex = 2;
            this.labelServer.Text = "Server";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(12, 287);
            this.textBoxServer.MaxLength = 100;
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(220, 23);
            this.textBoxServer.TabIndex = 3;
            // 
            // textBoxDB
            // 
            this.textBoxDB.Location = new System.Drawing.Point(12, 337);
            this.textBoxDB.MaxLength = 100;
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(220, 23);
            this.textBoxDB.TabIndex = 4;
            // 
            // labelDB
            // 
            this.labelDB.AutoSize = true;
            this.labelDB.Location = new System.Drawing.Point(12, 319);
            this.labelDB.Name = "labelDB";
            this.labelDB.Size = new System.Drawing.Size(55, 15);
            this.labelDB.TabIndex = 4;
            this.labelDB.Text = "Database";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(12, 386);
            this.textBoxUserId.MaxLength = 100;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(220, 23);
            this.textBoxUserId.TabIndex = 5;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(12, 368);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(40, 15);
            this.labelUserId.TabIndex = 6;
            this.labelUserId.Text = "UserId";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 435);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(220, 23);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 417);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // checkBoxIntegratedSecurity
            // 
            this.checkBoxIntegratedSecurity.AutoSize = true;
            this.checkBoxIntegratedSecurity.Location = new System.Drawing.Point(12, 467);
            this.checkBoxIntegratedSecurity.Name = "checkBoxIntegratedSecurity";
            this.checkBoxIntegratedSecurity.Size = new System.Drawing.Size(125, 19);
            this.checkBoxIntegratedSecurity.TabIndex = 7;
            this.checkBoxIntegratedSecurity.Text = "Integrated Security";
            this.checkBoxIntegratedSecurity.UseVisualStyleBackColor = true;
            this.checkBoxIntegratedSecurity.CheckedChanged += new System.EventHandler(this.checkBoxIntegratedSecurity_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(12, 505);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(220, 36);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363  , 678);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "settings";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panelRightTop.ResumeLayout(false);
            this.ResumeLayout(false);
           

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBoxDB;
        private System.Windows.Forms.Label labelDB;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxIntegratedSecurity;
    }
}