namespace InventoryManagementSystem
{
    partial class HomeScreen
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCat = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonPurchaseOrder = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonPOReceiving = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonRework = new System.Windows.Forms.Button();
            this.buttonOnhold = new System.Windows.Forms.Button();
            this.buttonRejected = new System.Windows.Forms.Button();
            this.labelNotifcationStatus = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelNotification = new System.Windows.Forms.Label();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.DevelopedBy = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.linkLabelMin = new System.Windows.Forms.LinkLabel();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panelRightTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.linkLabelMin);
            this.LeftPanel.Controls.Add(this.comboBoxProducts);
            this.LeftPanel.Controls.Add(this.DevelopedBy);
            this.LeftPanel.Controls.Add(this.labelNotification);
            this.LeftPanel.Controls.Add(this.labelNotifcationStatus);
            this.LeftPanel.Size = new System.Drawing.Size(250, 678);
            this.LeftPanel.Controls.SetChildIndex(this.labelNotifcationStatus, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelNotification, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DevelopedBy, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.comboBoxProducts, 0);
            this.LeftPanel.Controls.SetChildIndex(this.linkLabelMin, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(1113, 678);
            this.rightPanel.Controls.SetChildIndex(this.panelRightTop, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // panelRightTop
            // 
            this.panelRightTop.Controls.Add(this.buttonlogout);
            this.panelRightTop.Size = new System.Drawing.Size(1113, 55);
            this.panelRightTop.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCat, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSales, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPurchaseOrder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Product, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSupplier, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPOReceiving, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCustomer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonRework, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOnhold, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRejected, 2, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 623);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonCat
            // 
            this.buttonCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCat.FlatAppearance.BorderSize = 2;
            this.buttonCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCat.Image = global::InventoryManagementSystem.Properties.Resources.cati;
            this.buttonCat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCat.Location = new System.Drawing.Point(891, 127);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(219, 118);
            this.buttonCat.TabIndex = 11;
            this.buttonCat.Text = "Category";
            this.buttonCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCat.UseVisualStyleBackColor = true;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSales.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSales.FlatAppearance.BorderSize = 2;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSales.Image = global::InventoryManagementSystem.Properties.Resources.sales;
            this.buttonSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSales.Location = new System.Drawing.Point(669, 3);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(216, 118);
            this.buttonSales.TabIndex = 5;
            this.buttonSales.Text = "Sales";
            this.buttonSales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonPurchaseOrder
            // 
            this.buttonPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPurchaseOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonPurchaseOrder.FlatAppearance.BorderSize = 2;
            this.buttonPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchaseOrder.Image = global::InventoryManagementSystem.Properties.Resources.invoice;
            this.buttonPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPurchaseOrder.Location = new System.Drawing.Point(225, 3);
            this.buttonPurchaseOrder.Name = "buttonPurchaseOrder";
            this.buttonPurchaseOrder.Size = new System.Drawing.Size(216, 118);
            this.buttonPurchaseOrder.TabIndex = 23;
            this.buttonPurchaseOrder.Text = "Purchase Orders";
            this.buttonPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPurchaseOrder.UseVisualStyleBackColor = true;
            this.buttonPurchaseOrder.Click += new System.EventHandler(this.buttonPurchaseOrder_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStock.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonStock.FlatAppearance.BorderSize = 2;
            this.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.Image = global::InventoryManagementSystem.Properties.Resources.stocks;
            this.buttonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStock.Location = new System.Drawing.Point(3, 3);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(216, 118);
            this.buttonStock.TabIndex = 2;
            this.buttonStock.Text = "Stocks";
            this.buttonStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // Product
            // 
            this.Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Product.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Product.FlatAppearance.BorderSize = 2;
            this.Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Image = global::InventoryManagementSystem.Properties.Resources.produser;
            this.Product.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Product.Location = new System.Drawing.Point(891, 3);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(219, 118);
            this.Product.TabIndex = 6;
            this.Product.Text = "Products";
            this.Product.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonUser.FlatAppearance.BorderSize = 2;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.Image = global::InventoryManagementSystem.Properties.Resources._13698448141519590102add_user_12;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.Location = new System.Drawing.Point(225, 251);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(216, 118);
            this.buttonUser.TabIndex = 13;
            this.buttonUser.Text = "Users";
            this.buttonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSupplier.FlatAppearance.BorderSize = 2;
            this.buttonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplier.Image = global::InventoryManagementSystem.Properties.Resources.TheSupplier;
            this.buttonSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSupplier.Location = new System.Drawing.Point(669, 127);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(216, 118);
            this.buttonSupplier.TabIndex = 10;
            this.buttonSupplier.Text = "Suppliers";
            this.buttonSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonPOReceiving
            // 
            this.buttonPOReceiving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPOReceiving.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonPOReceiving.FlatAppearance.BorderSize = 2;
            this.buttonPOReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPOReceiving.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPOReceiving.Image = global::InventoryManagementSystem.Properties.Resources.PoRecv;
            this.buttonPOReceiving.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPOReceiving.Location = new System.Drawing.Point(447, 3);
            this.buttonPOReceiving.Name = "buttonPOReceiving";
            this.buttonPOReceiving.Size = new System.Drawing.Size(216, 118);
            this.buttonPOReceiving.TabIndex = 4;
            this.buttonPOReceiving.Text = "PO Receiving";
            this.buttonPOReceiving.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPOReceiving.UseVisualStyleBackColor = true;
            this.buttonPOReceiving.Click += new System.EventHandler(this.buttonPOReceiving_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCustomer.FlatAppearance.BorderSize = 2;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.Image = global::InventoryManagementSystem.Properties.Resources.Customer;
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCustomer.Location = new System.Drawing.Point(3, 251);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(216, 118);
            this.buttonCustomer.TabIndex = 12;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonRework
            // 
            this.buttonRework.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRework.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRework.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRework.Image = global::InventoryManagementSystem.Properties.Resources.reworkstock;
            this.buttonRework.Location = new System.Drawing.Point(3, 127);
            this.buttonRework.Name = "buttonRework";
            this.buttonRework.Size = new System.Drawing.Size(216, 118);
            this.buttonRework.TabIndex = 7;
            this.buttonRework.Text = "Stocks Reworked";
            this.buttonRework.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRework.UseVisualStyleBackColor = true;
            this.buttonRework.Click += new System.EventHandler(this.buttonRework_Click);
            // 
            // buttonOnhold
            // 
            this.buttonOnhold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOnhold.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonOnhold.FlatAppearance.BorderSize = 2;
            this.buttonOnhold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnhold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOnhold.Image = global::InventoryManagementSystem.Properties.Resources.onHoldStock;
            this.buttonOnhold.Location = new System.Drawing.Point(225, 127);
            this.buttonOnhold.Name = "buttonOnhold";
            this.buttonOnhold.Size = new System.Drawing.Size(216, 118);
            this.buttonOnhold.TabIndex = 8;
            this.buttonOnhold.Text = "Stocks Onhold";
            this.buttonOnhold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonOnhold.UseVisualStyleBackColor = true;
            this.buttonOnhold.Click += new System.EventHandler(this.buttonOnhold_Click);
            // 
            // buttonRejected
            // 
            this.buttonRejected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRejected.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRejected.FlatAppearance.BorderSize = 2;
            this.buttonRejected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRejected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRejected.Image = global::InventoryManagementSystem.Properties.Resources.RejectedStock;
            this.buttonRejected.Location = new System.Drawing.Point(447, 127);
            this.buttonRejected.Name = "buttonRejected";
            this.buttonRejected.Size = new System.Drawing.Size(216, 118);
            this.buttonRejected.TabIndex = 9;
            this.buttonRejected.Text = "Stocks Rejected";
            this.buttonRejected.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRejected.UseVisualStyleBackColor = true;
            this.buttonRejected.Click += new System.EventHandler(this.buttonRejected_Click);
            // 
            // labelNotifcationStatus
            // 
            this.labelNotifcationStatus.AutoSize = true;
            this.labelNotifcationStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotifcationStatus.Location = new System.Drawing.Point(3, 122);
            this.labelNotifcationStatus.Name = "labelNotifcationStatus";
            this.labelNotifcationStatus.Size = new System.Drawing.Size(151, 21);
            this.labelNotifcationStatus.TabIndex = 2;
            this.labelNotifcationStatus.Text = "Stocks are upto date";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotification.Location = new System.Drawing.Point(3, 72);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(110, 21);
            this.labelNotification.TabIndex = 25;
            this.labelNotification.Text = "Notifications";
            // 
            // buttonlogout
            // 
            this.buttonlogout.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonlogout.FlatAppearance.BorderSize = 2;
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Location = new System.Drawing.Point(1031, 2);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(80, 50);
            this.buttonlogout.TabIndex = 10;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // DevelopedBy
            // 
            this.DevelopedBy.AutoSize = true;
            this.DevelopedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopedBy.Location = new System.Drawing.Point(3, 648);
            this.DevelopedBy.Name = "DevelopedBy";
            this.DevelopedBy.Size = new System.Drawing.Size(227, 21);
            this.DevelopedBy.TabIndex = 26;
            this.DevelopedBy.Text = "Developed by PMS Consultants";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.ItemHeight = 15;
            this.comboBoxProducts.Location = new System.Drawing.Point(7, 198);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(220, 23);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.Visible = false;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // linkLabelMin
            // 
            this.linkLabelMin.AutoSize = true;
            this.linkLabelMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelMin.Location = new System.Drawing.Point(3, 157);
            this.linkLabelMin.Name = "linkLabelMin";
            this.linkLabelMin.Size = new System.Drawing.Size(204, 19);
            this.linkLabelMin.TabIndex = 29;
            this.linkLabelMin.TabStop = true;
            this.linkLabelMin.Text = "Products below Minimum Value";
            this.linkLabelMin.Visible = false;
            this.linkLabelMin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 678);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panelRightTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonPurchaseOrder;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonPOReceiving;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Label labelNotifcationStatus;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelNotification;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Label DevelopedBy;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.LinkLabel linkLabelMin;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonRework;
        private System.Windows.Forms.Button buttonOnhold;
        private System.Windows.Forms.Button buttonRejected;
    }
}