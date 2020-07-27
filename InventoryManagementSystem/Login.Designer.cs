namespace InventoryManagementSystem
{
    partial class Login
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
            this.labelUserNameLogin = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUserNameError = new System.Windows.Forms.Label();
            this.labelPasswordError = new System.Windows.Forms.Label();
            this.IMS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxPMSLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPMSLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.labelLogin);
            this.LeftPanel.Controls.Add(this.pictureBoxPMSLogo);
            this.LeftPanel.Controls.Add(this.buttonLogin);
            this.LeftPanel.Controls.Add(this.textBoxPassword);
            this.LeftPanel.Controls.Add(this.labelPassword);
            this.LeftPanel.Controls.Add(this.textBoxUserName);
            this.LeftPanel.Controls.Add(this.labelUserNameLogin);
            this.LeftPanel.Controls.Add(this.labelUserNameError);
            this.LeftPanel.Controls.Add(this.labelPasswordError);
            this.LeftPanel.Size = new System.Drawing.Size(250, 678);
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            this.LeftPanel.Controls.SetChildIndex(this.labelPasswordError, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelUserNameError, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelUserNameLogin, 0);
            this.LeftPanel.Controls.SetChildIndex(this.textBoxUserName, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelPassword, 0);
            this.LeftPanel.Controls.SetChildIndex(this.textBoxPassword, 0);
            this.LeftPanel.Controls.SetChildIndex(this.buttonLogin, 0);
            this.LeftPanel.Controls.SetChildIndex(this.pictureBoxPMSLogo, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelLogin, 0);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Controls.Add(this.label1);
            this.panelLeftTop.Controls.Add(this.IMS);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.pictureBox1);
            this.rightPanel.Size = new System.Drawing.Size(1113, 678);
            this.rightPanel.Controls.SetChildIndex(this.panelRightTop, 0);
            this.rightPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // panelRightTop
            // 
            this.panelRightTop.Size = new System.Drawing.Size(1113, 55);
            // 
            // labelUserNameLogin
            // 
            this.labelUserNameLogin.AutoSize = true;
            this.labelUserNameLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameLogin.Location = new System.Drawing.Point(12, 289);
            this.labelUserNameLogin.Name = "labelUserNameLogin";
            this.labelUserNameLogin.Size = new System.Drawing.Size(80, 20);
            this.labelUserNameLogin.TabIndex = 2;
            this.labelUserNameLogin.Text = "Username";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(12, 317);
            this.textBoxUserName.MaxLength = 30;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(220, 23);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 371);
            this.textBoxPassword.MaxLength = 30;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(220, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(12, 343);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(12, 410);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(220, 28);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUserNameError
            // 
            this.labelUserNameError.AutoSize = true;
            this.labelUserNameError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameError.ForeColor = System.Drawing.Color.Red;
            this.labelUserNameError.Location = new System.Drawing.Point(212, 289);
            this.labelUserNameError.Name = "labelUserNameError";
            this.labelUserNameError.Size = new System.Drawing.Size(20, 28);
            this.labelUserNameError.TabIndex = 23;
            this.labelUserNameError.Text = "*";
            this.labelUserNameError.Visible = false;
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.AutoSize = true;
            this.labelPasswordError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordError.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordError.Location = new System.Drawing.Point(212, 340);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.Size = new System.Drawing.Size(20, 28);
            this.labelPasswordError.TabIndex = 24;
            this.labelPasswordError.Text = "*";
            this.labelPasswordError.Visible = false;
            // 
            // IMS
            // 
            this.IMS.AutoSize = true;
            this.IMS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMS.Location = new System.Drawing.Point(6, 19);
            this.IMS.Name = "IMS";
            this.IMS.Size = new System.Drawing.Size(241, 21);
            this.IMS.TabIndex = 25;
            this.IMS.Text = "Inventory Managment System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Inventory Managment System";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(86, 62);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 21);
            this.labelLogin.TabIndex = 29;
            this.labelLogin.Text = "Login";
            this.labelLogin.Visible = false;
            // 
            // pictureBoxPMSLogo
            // 
            this.pictureBoxPMSLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPMSLogo.Image = global::InventoryManagementSystem.Properties.Resources.Login1;
            this.pictureBoxPMSLogo.Location = new System.Drawing.Point(51, 128);
            this.pictureBoxPMSLogo.Name = "pictureBoxPMSLogo";
            this.pictureBoxPMSLogo.Size = new System.Drawing.Size(115, 120);
            this.pictureBoxPMSLogo.TabIndex = 28;
            this.pictureBoxPMSLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.inventoryicon;
            this.pictureBox1.Location = new System.Drawing.Point(348, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 678);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Login";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPMSLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserNameLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUserNameError;
        private System.Windows.Forms.Label labelPasswordError;
        private System.Windows.Forms.Label IMS;
        private System.Windows.Forms.PictureBox pictureBoxPMSLogo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label1;
    
    }
}