namespace InventoryManagementSystem
{
    partial class StockReworked
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReworked));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxSelectProduct = new System.Windows.Forms.ComboBox();
            this.labelProductDateError = new System.Windows.Forms.Label();
            this.labelQuantityError = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.ProductIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCodeGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMinValGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReworkedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RejectedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnholdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddToStocks = new System.Windows.Forms.Button();
            this.buttonResolveReworkedStock = new System.Windows.Forms.Button();
            this.dateTimePickerEntryDate = new System.Windows.Forms.DateTimePicker();
            this.labelEntryDate = new System.Windows.Forms.Label();
            this.labelEntryDateError = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.panelLeftMiddleMain = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bunifuGradientPannelSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonMenuProducts = new System.Windows.Forms.Button();
            this.buttonMenuStockOut = new System.Windows.Forms.Button();
            this.buttonMenuStockIn = new System.Windows.Forms.Button();
            this.buttonMenuRecv = new System.Windows.Forms.Button();
            this.buttonMenuStock = new System.Windows.Forms.Button();
            this.buttonMenuSales = new System.Windows.Forms.Button();
            this.buttonMenuPO = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRightSlider = new System.Windows.Forms.Panel();
            this.labelMenuLabel = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.bunifuTransitionAnimationSideBar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransitionAnimationSideBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LeftPanel.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelLeftMiddleMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.bunifuGradientPannelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRightSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxSearch, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxSearch, BunifuAnimatorNS.DecorationType.None);
            // 
            // buttonBack
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonBack, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonBack, BunifuAnimatorNS.DecorationType.None);
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.panelLeftMiddleMain);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftMiddleMain, 0);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Controls.Add(this.labelMenuLabel);
            this.panelLeftTop.Controls.Add(this.pictureBoxMenu);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelLeftTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelLeftTop, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftTop.Controls.SetChildIndex(this.buttonBack, 0);
            this.panelLeftTop.Controls.SetChildIndex(this.pictureBoxMenu, 0);
            this.panelLeftTop.Controls.SetChildIndex(this.labelMenuLabel, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridViewProduct);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.rightPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.rightPanel, BunifuAnimatorNS.DecorationType.None);
            this.rightPanel.Controls.SetChildIndex(this.panelRightTop, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridViewProduct, 0);
            // 
            // panelRightTop
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelRightTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelRightTop, BunifuAnimatorNS.DecorationType.None);
            // 
            // textBoxQuantity
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxQuantity, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxQuantity, BunifuAnimatorNS.DecorationType.None);
            this.textBoxQuantity.Enabled = false;
            this.textBoxQuantity.Location = new System.Drawing.Point(47, 190);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(180, 23);
            this.textBoxQuantity.TabIndex = 4;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // comboBoxSelectProduct
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.comboBoxSelectProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.comboBoxSelectProduct, BunifuAnimatorNS.DecorationType.None);
            this.comboBoxSelectProduct.Enabled = false;
            this.comboBoxSelectProduct.FormattingEnabled = true;
            this.comboBoxSelectProduct.Location = new System.Drawing.Point(47, 78);
            this.comboBoxSelectProduct.Name = "comboBoxSelectProduct";
            this.comboBoxSelectProduct.Size = new System.Drawing.Size(180, 23);
            this.comboBoxSelectProduct.TabIndex = 2;
            this.comboBoxSelectProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectProduct_SelectedIndexChanged);
            // 
            // labelProductDateError
            // 
            this.labelProductDateError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProductDateError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProductDateError, BunifuAnimatorNS.DecorationType.None);
            this.labelProductDateError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductDateError.ForeColor = System.Drawing.Color.Red;
            this.labelProductDateError.Location = new System.Drawing.Point(207, 40);
            this.labelProductDateError.Name = "labelProductDateError";
            this.labelProductDateError.Size = new System.Drawing.Size(20, 28);
            this.labelProductDateError.TabIndex = 34;
            this.labelProductDateError.Text = "*";
            this.labelProductDateError.Visible = false;
            // 
            // labelQuantityError
            // 
            this.labelQuantityError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelQuantityError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelQuantityError, BunifuAnimatorNS.DecorationType.None);
            this.labelQuantityError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityError.ForeColor = System.Drawing.Color.Red;
            this.labelQuantityError.Location = new System.Drawing.Point(207, 159);
            this.labelQuantityError.Name = "labelQuantityError";
            this.labelQuantityError.Size = new System.Drawing.Size(20, 28);
            this.labelQuantityError.TabIndex = 35;
            this.labelQuantityError.Text = "*";
            this.labelQuantityError.Visible = false;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdGv,
            this.ProductNameGv,
            this.ProductCodeGv,
            this.ProductUnitGv,
            this.ProductMinValGv,
            this.ReworkedStock,
            this.RejectedStock,
            this.OnholdStock,
            this.AvailableStocks});
            this.dataGridViewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.dataGridViewProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.dataGridViewProduct, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1113, 578);
            this.dataGridViewProduct.TabIndex = 5;
            // 
            // ProductIdGv
            // 
            this.ProductIdGv.HeaderText = "ProductId";
            this.ProductIdGv.Name = "ProductIdGv";
            this.ProductIdGv.ReadOnly = true;
            this.ProductIdGv.Visible = false;
            // 
            // ProductNameGv
            // 
            this.ProductNameGv.HeaderText = "Product Name";
            this.ProductNameGv.Name = "ProductNameGv";
            this.ProductNameGv.ReadOnly = true;
            // 
            // ProductCodeGv
            // 
            this.ProductCodeGv.HeaderText = "Product Code";
            this.ProductCodeGv.Name = "ProductCodeGv";
            this.ProductCodeGv.ReadOnly = true;
            // 
            // ProductUnitGv
            // 
            this.ProductUnitGv.HeaderText = "Unit";
            this.ProductUnitGv.Name = "ProductUnitGv";
            this.ProductUnitGv.ReadOnly = true;
            // 
            // ProductMinValGv
            // 
            this.ProductMinValGv.HeaderText = "Minimum Value";
            this.ProductMinValGv.Name = "ProductMinValGv";
            this.ProductMinValGv.ReadOnly = true;
            this.ProductMinValGv.Visible = false;
            // 
            // ReworkedStock
            // 
            this.ReworkedStock.HeaderText = "Reworked Stocks";
            this.ReworkedStock.Name = "ReworkedStock";
            this.ReworkedStock.ReadOnly = true;
            // 
            // RejectedStock
            // 
            this.RejectedStock.HeaderText = "Rejected Stocks";
            this.RejectedStock.Name = "RejectedStock";
            this.RejectedStock.ReadOnly = true;
            // 
            // OnholdStock
            // 
            this.OnholdStock.HeaderText = "On Hold Stocks";
            this.OnholdStock.Name = "OnholdStock";
            this.OnholdStock.ReadOnly = true;
            // 
            // AvailableStocks
            // 
            this.AvailableStocks.HeaderText = "Available Stocks";
            this.AvailableStocks.Name = "AvailableStocks";
            // 
            // buttonAddToStocks
            // 
            this.buttonAddToStocks.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAddToStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonAddToStocks, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonAddToStocks, BunifuAnimatorNS.DecorationType.None);
            this.buttonAddToStocks.Enabled = false;
            this.buttonAddToStocks.FlatAppearance.BorderSize = 2;
            this.buttonAddToStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToStocks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddToStocks.Location = new System.Drawing.Point(45, 227);
            this.buttonAddToStocks.Name = "buttonAddToStocks";
            this.buttonAddToStocks.Size = new System.Drawing.Size(180, 38);
            this.buttonAddToStocks.TabIndex = 5;
            this.buttonAddToStocks.Text = "ADD TO REWORKED STOCKS";
            this.buttonAddToStocks.UseVisualStyleBackColor = false;
            this.buttonAddToStocks.Click += new System.EventHandler(this.buttonAddToStocks_Click);
            // 
            // buttonResolveReworkedStock
            // 
            this.buttonResolveReworkedStock.BackColor = System.Drawing.Color.DarkGray;
            this.buttonResolveReworkedStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonResolveReworkedStock, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonResolveReworkedStock, BunifuAnimatorNS.DecorationType.None);
            this.buttonResolveReworkedStock.Enabled = false;
            this.buttonResolveReworkedStock.FlatAppearance.BorderSize = 2;
            this.buttonResolveReworkedStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResolveReworkedStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonResolveReworkedStock.Location = new System.Drawing.Point(45, 289);
            this.buttonResolveReworkedStock.Name = "buttonResolveReworkedStock";
            this.buttonResolveReworkedStock.Size = new System.Drawing.Size(180, 38);
            this.buttonResolveReworkedStock.TabIndex = 6;
            this.buttonResolveReworkedStock.Text = "RESOLVE REWORKED STOCKS";
            this.buttonResolveReworkedStock.UseVisualStyleBackColor = false;
            this.buttonResolveReworkedStock.Click += new System.EventHandler(this.buttonResolveReworkedStock_Click);
            // 
            // dateTimePickerEntryDate
            // 
            this.dateTimePickerEntryDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.dateTimePickerEntryDate, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.dateTimePickerEntryDate, BunifuAnimatorNS.DecorationType.None);
            this.dateTimePickerEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEntryDate.Location = new System.Drawing.Point(47, 131);
            this.dateTimePickerEntryDate.Name = "dateTimePickerEntryDate";
            this.dateTimePickerEntryDate.Size = new System.Drawing.Size(180, 23);
            this.dateTimePickerEntryDate.TabIndex = 3;
            // 
            // labelEntryDate
            // 
            this.labelEntryDate.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelEntryDate, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelEntryDate, BunifuAnimatorNS.DecorationType.None);
            this.labelEntryDate.ForeColor = System.Drawing.Color.White;
            this.labelEntryDate.Location = new System.Drawing.Point(44, 113);
            this.labelEntryDate.Name = "labelEntryDate";
            this.labelEntryDate.Size = new System.Drawing.Size(31, 15);
            this.labelEntryDate.TabIndex = 42;
            this.labelEntryDate.Text = "Date";
            // 
            // labelEntryDateError
            // 
            this.labelEntryDateError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelEntryDateError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelEntryDateError, BunifuAnimatorNS.DecorationType.None);
            this.labelEntryDateError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntryDateError.ForeColor = System.Drawing.Color.Red;
            this.labelEntryDateError.Location = new System.Drawing.Point(207, 100);
            this.labelEntryDateError.Name = "labelEntryDateError";
            this.labelEntryDateError.Size = new System.Drawing.Size(20, 28);
            this.labelEntryDateError.TabIndex = 44;
            this.labelEntryDateError.Text = "*";
            this.labelEntryDateError.Visible = false;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelSelect, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelSelect, BunifuAnimatorNS.DecorationType.None);
            this.labelSelect.ForeColor = System.Drawing.Color.White;
            this.labelSelect.Location = new System.Drawing.Point(44, 53);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(83, 15);
            this.labelSelect.TabIndex = 45;
            this.labelSelect.Text = "Select Product";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelQty, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelQty, BunifuAnimatorNS.DecorationType.None);
            this.labelQty.ForeColor = System.Drawing.Color.White;
            this.labelQty.Location = new System.Drawing.Point(42, 170);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(53, 15);
            this.labelQty.TabIndex = 46;
            this.labelQty.Text = "Quantity";
            // 
            // panelLeftMiddleMain
            // 
            this.panelLeftMiddleMain.AutoScroll = true;
            this.panelLeftMiddleMain.Controls.Add(this.panelMenu);
            this.panelLeftMiddleMain.Controls.Add(this.panelRightSlider);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftMiddleMain.Location = new System.Drawing.Point(1, 56);
            this.panelLeftMiddleMain.Name = "panelLeftMiddleMain";
            this.panelLeftMiddleMain.Size = new System.Drawing.Size(248, 620);
            this.panelLeftMiddleMain.TabIndex = 47;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.bunifuGradientPannelSidebar);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(40, 620);
            this.panelMenu.TabIndex = 48;
            // 
            // bunifuGradientPannelSidebar
            // 
            this.bunifuGradientPannelSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPannelSidebar.BackgroundImage")));
            this.bunifuGradientPannelSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPannelSidebar.Controls.Add(this.buttonMenuProducts);
            this.bunifuGradientPannelSidebar.Controls.Add(this.buttonMenuStockOut);
            this.bunifuGradientPannelSidebar.Controls.Add(this.buttonMenuStockIn);
            this.bunifuGradientPannelSidebar.Controls.Add(this.buttonMenuRecv);
            this.bunifuGradientPannelSidebar.Controls.Add(this.buttonMenuStock);
            this.bunifuGradientPannelSidebar.Controls.Add(this.buttonMenuSales);
            this.bunifuGradientPannelSidebar.Controls.Add(this.buttonMenuPO);
            this.bunifuGradientPannelSidebar.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPannelSidebar.Controls.Add(this.label1);
            this.bunifuGradientPannelSidebar.Controls.Add(this.pictureBox1);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.bunifuGradientPannelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.bunifuGradientPannelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPannelSidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientTopRight = System.Drawing.Color.Yellow;
            this.bunifuGradientPannelSidebar.Location = new System.Drawing.Point(-9, 3);
            this.bunifuGradientPannelSidebar.Name = "bunifuGradientPannelSidebar";
            this.bunifuGradientPannelSidebar.Quality = 10;
            this.bunifuGradientPannelSidebar.Size = new System.Drawing.Size(195, 615);
            this.bunifuGradientPannelSidebar.TabIndex = 5;
            // 
            // buttonMenuProducts
            // 
            this.buttonMenuProducts.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonMenuProducts, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonMenuProducts, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuProducts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMenuProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuProducts.ForeColor = System.Drawing.Color.White;
            this.buttonMenuProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuProducts.Location = new System.Drawing.Point(10, 454);
            this.buttonMenuProducts.Name = "buttonMenuProducts";
            this.buttonMenuProducts.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuProducts.TabIndex = 58;
            this.buttonMenuProducts.Text = "Products";
            this.buttonMenuProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuProducts.UseVisualStyleBackColor = false;
            this.buttonMenuProducts.Click += new System.EventHandler(this.buttonMenuProducts_Click);
            // 
            // buttonMenuStockOut
            // 
            this.buttonMenuStockOut.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonMenuStockOut, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonMenuStockOut, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuStockOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMenuStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuStockOut.ForeColor = System.Drawing.Color.White;
            this.buttonMenuStockOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuStockOut.Location = new System.Drawing.Point(11, 389);
            this.buttonMenuStockOut.Name = "buttonMenuStockOut";
            this.buttonMenuStockOut.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuStockOut.TabIndex = 57;
            this.buttonMenuStockOut.Text = "Stocks Out";
            this.buttonMenuStockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuStockOut.UseVisualStyleBackColor = false;
            this.buttonMenuStockOut.Click += new System.EventHandler(this.buttonMenuStockOut_Click);
            // 
            // buttonMenuStockIn
            // 
            this.buttonMenuStockIn.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonMenuStockIn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonMenuStockIn, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuStockIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMenuStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuStockIn.ForeColor = System.Drawing.Color.White;
            this.buttonMenuStockIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuStockIn.Location = new System.Drawing.Point(10, 327);
            this.buttonMenuStockIn.Name = "buttonMenuStockIn";
            this.buttonMenuStockIn.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuStockIn.TabIndex = 56;
            this.buttonMenuStockIn.Text = "Stocks In";
            this.buttonMenuStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuStockIn.UseVisualStyleBackColor = false;
            this.buttonMenuStockIn.Click += new System.EventHandler(this.buttonMenuStockIn_Click);
            // 
            // buttonMenuRecv
            // 
            this.buttonMenuRecv.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonMenuRecv, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonMenuRecv, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuRecv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMenuRecv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuRecv.ForeColor = System.Drawing.Color.White;
            this.buttonMenuRecv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuRecv.Location = new System.Drawing.Point(10, 266);
            this.buttonMenuRecv.Name = "buttonMenuRecv";
            this.buttonMenuRecv.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuRecv.TabIndex = 55;
            this.buttonMenuRecv.Text = "PO Receivings";
            this.buttonMenuRecv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuRecv.UseVisualStyleBackColor = false;
            this.buttonMenuRecv.Click += new System.EventHandler(this.buttonMenuRecv_Click);
            // 
            // buttonMenuStock
            // 
            this.buttonMenuStock.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonMenuStock, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonMenuStock, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuStock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMenuStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuStock.ForeColor = System.Drawing.Color.White;
            this.buttonMenuStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuStock.Location = new System.Drawing.Point(10, 194);
            this.buttonMenuStock.Name = "buttonMenuStock";
            this.buttonMenuStock.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuStock.TabIndex = 54;
            this.buttonMenuStock.Text = "Stock";
            this.buttonMenuStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuStock.UseVisualStyleBackColor = false;
            this.buttonMenuStock.Click += new System.EventHandler(this.buttonMenuStock_Click);
            // 
            // buttonMenuSales
            // 
            this.buttonMenuSales.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonMenuSales, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonMenuSales, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuSales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMenuSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuSales.ForeColor = System.Drawing.Color.White;
            this.buttonMenuSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuSales.Location = new System.Drawing.Point(11, 129);
            this.buttonMenuSales.Name = "buttonMenuSales";
            this.buttonMenuSales.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuSales.TabIndex = 53;
            this.buttonMenuSales.Text = "Sales";
            this.buttonMenuSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuSales.UseVisualStyleBackColor = false;
            this.buttonMenuSales.Click += new System.EventHandler(this.buttonMenuSales_Click);
            // 
            // buttonMenuPO
            // 
            this.buttonMenuPO.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonMenuPO, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonMenuPO, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuPO.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMenuPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuPO.ForeColor = System.Drawing.Color.White;
            this.buttonMenuPO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenuPO.Location = new System.Drawing.Point(11, 75);
            this.buttonMenuPO.Name = "buttonMenuPO";
            this.buttonMenuPO.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuPO.TabIndex = 52;
            this.buttonMenuPO.Text = "Purchase Order";
            this.buttonMenuPO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuPO.UseVisualStyleBackColor = false;
            this.buttonMenuPO.Click += new System.EventHandler(this.buttonMenuPO_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 42);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(182, 27);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.Menuicon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelRightSlider
            // 
            this.panelRightSlider.Controls.Add(this.labelEntryDate);
            this.panelRightSlider.Controls.Add(this.buttonAddToStocks);
            this.panelRightSlider.Controls.Add(this.labelQty);
            this.panelRightSlider.Controls.Add(this.buttonResolveReworkedStock);
            this.panelRightSlider.Controls.Add(this.labelSelect);
            this.panelRightSlider.Controls.Add(this.textBoxQuantity);
            this.panelRightSlider.Controls.Add(this.labelQuantityError);
            this.panelRightSlider.Controls.Add(this.dateTimePickerEntryDate);
            this.panelRightSlider.Controls.Add(this.comboBoxSelectProduct);
            this.panelRightSlider.Controls.Add(this.labelEntryDateError);
            this.panelRightSlider.Controls.Add(this.labelProductDateError);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.panelRightSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSlider.Location = new System.Drawing.Point(0, 0);
            this.panelRightSlider.Name = "panelRightSlider";
            this.panelRightSlider.Size = new System.Drawing.Size(248, 620);
            this.panelRightSlider.TabIndex = 47;
            // 
            // labelMenuLabel
            // 
            this.labelMenuLabel.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.labelMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuLabel.Location = new System.Drawing.Point(59, 22);
            this.labelMenuLabel.Name = "labelMenuLabel";
            this.labelMenuLabel.Size = new System.Drawing.Size(39, 15);
            this.labelMenuLabel.TabIndex = 15;
            this.labelMenuLabel.Text = "Menu";
            // 
            // pictureBoxMenu
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxMenu.Image = global::InventoryManagementSystem.Properties.Resources.Menuicon;
            this.pictureBoxMenu.Location = new System.Drawing.Point(3, 17);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(45, 20);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 14;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // bunifuTransitionAnimationSideBar
            // 
            this.bunifuTransitionAnimationSideBar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuTransitionAnimationSideBar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransitionAnimationSideBar.DefaultAnimation = animation1;
            // 
            // bunifuTransitionAnimationSideBack
            // 
            this.bunifuTransitionAnimationSideBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransitionAnimationSideBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransitionAnimationSideBack.DefaultAnimation = animation2;
            // 
            // StockReworked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 678);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "StockReworked";
            this.Text = "StockReworked";
            this.Load += new System.EventHandler(this.StockIn_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelLeftMiddleMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.bunifuGradientPannelSidebar.ResumeLayout(false);
            this.bunifuGradientPannelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRightSlider.ResumeLayout(false);
            this.panelRightSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxSelectProduct;
        private System.Windows.Forms.Label labelProductDateError;
        private System.Windows.Forms.Label labelQuantityError;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonAddToStocks;
        private System.Windows.Forms.Button buttonResolveReworkedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCodeGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMinValGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReworkedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn RejectedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnholdStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStocks;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryDate;
        private System.Windows.Forms.Label labelEntryDate;
        private System.Windows.Forms.Label labelEntryDateError;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Panel panelLeftMiddleMain;
        private System.Windows.Forms.Panel panelRightSlider;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelMenuLabel;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPannelSidebar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransitionAnimationSideBar;
        private BunifuAnimatorNS.BunifuTransition bunifuTransitionAnimationSideBack;
        private System.Windows.Forms.Button buttonMenuProducts;
        private System.Windows.Forms.Button buttonMenuStockOut;
        private System.Windows.Forms.Button buttonMenuStockIn;
        private System.Windows.Forms.Button buttonMenuRecv;
        private System.Windows.Forms.Button buttonMenuStock;
        private System.Windows.Forms.Button buttonMenuSales;
        private System.Windows.Forms.Button buttonMenuPO;
    }
}