namespace InventoryManagementSystem
{
    partial class POReceiving
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POReceiving));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.labelSelectPO = new System.Windows.Forms.Label();
            this.comboBoxPO = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPO = new System.Windows.Forms.DateTimePicker();
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.textBoxProdCost = new System.Windows.Forms.TextBox();
            this.labelProdCost = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantityOrdered = new System.Windows.Forms.Label();
            this.comboBoxSelectProduct = new System.Windows.Forms.ComboBox();
            this.labelSelectProduct = new System.Windows.Forms.Label();
            this.labelProductDateError = new System.Windows.Forms.Label();
            this.labelQuantityError = new System.Windows.Forms.Label();
            this.textBoxQuantityReceived = new System.Windows.Forms.TextBox();
            this.labelQuantityReceived = new System.Windows.Forms.Label();
            this.labelQuntityReceivedError = new System.Windows.Forms.Label();
            this.dataGridViewPOLines = new System.Windows.Forms.DataGridView();
            this.PoLineIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceivedDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedQuantityCostDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelGrossTotal = new System.Windows.Forms.Label();
            this.labelGrandTotalValue = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
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
            this.pictureBoxMenuonSideBar = new System.Windows.Forms.PictureBox();
            this.panelRightSlider = new System.Windows.Forms.Panel();
            this.labelMenuLabel = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.bunifuTransitionAnimationSideBar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransitionAnimationSideBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LeftPanel.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOLines)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelLeftMiddleMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.bunifuGradientPannelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuonSideBar)).BeginInit();
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
            this.LeftPanel.Controls.Add(this.labelProductDateError);
            this.LeftPanel.Controls.Add(this.labelQuntityReceivedError);
            this.LeftPanel.Controls.Add(this.labelQuantityError);
            this.LeftPanel.Controls.Add(this.panelLeftMiddleMain);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftMiddleMain, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelQuantityError, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelQuntityReceivedError, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.labelProductDateError, 0);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Controls.Add(this.labelMenuLabel);
            this.panelLeftTop.Controls.Add(this.pictureBoxMenu);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelLeftTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelLeftTop, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftTop.Controls.SetChildIndex(this.pictureBoxMenu, 0);
            this.panelLeftTop.Controls.SetChildIndex(this.buttonBack, 0);
            this.panelLeftTop.Controls.SetChildIndex(this.labelMenuLabel, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel2);
            this.rightPanel.Controls.Add(this.dataGridViewPOLines);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.rightPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.rightPanel, BunifuAnimatorNS.DecorationType.None);
            this.rightPanel.Controls.SetChildIndex(this.panelRightTop, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridViewPOLines, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            // 
            // panelRightTop
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelRightTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelRightTop, BunifuAnimatorNS.DecorationType.None);
            // 
            // labelSelectPO
            // 
            this.labelSelectPO.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelSelectPO, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelSelectPO, BunifuAnimatorNS.DecorationType.None);
            this.labelSelectPO.Location = new System.Drawing.Point(41, 77);
            this.labelSelectPO.Name = "labelSelectPO";
            this.labelSelectPO.Size = new System.Drawing.Size(57, 15);
            this.labelSelectPO.TabIndex = 8;
            this.labelSelectPO.Text = "Select PO";
            // 
            // comboBoxPO
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.comboBoxPO, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.comboBoxPO, BunifuAnimatorNS.DecorationType.None);
            this.comboBoxPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPO.Location = new System.Drawing.Point(44, 107);
            this.comboBoxPO.Name = "comboBoxPO";
            this.comboBoxPO.Size = new System.Drawing.Size(180, 23);
            this.comboBoxPO.TabIndex = 3;
            this.comboBoxPO.SelectedIndexChanged += new System.EventHandler(this.comboBoxPO_SelectedIndexChanged);
            // 
            // dateTimePickerPO
            // 
            this.dateTimePickerPO.CustomFormat = "MMMM- yyyy";
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.dateTimePickerPO, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.dateTimePickerPO, BunifuAnimatorNS.DecorationType.None);
            this.dateTimePickerPO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPO.Location = new System.Drawing.Point(44, 39);
            this.dateTimePickerPO.Name = "dateTimePickerPO";
            this.dateTimePickerPO.ShowUpDown = true;
            this.dateTimePickerPO.Size = new System.Drawing.Size(180, 23);
            this.dateTimePickerPO.TabIndex = 2;
            this.dateTimePickerPO.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelSelectDate, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelSelectDate, BunifuAnimatorNS.DecorationType.None);
            this.labelSelectDate.Location = new System.Drawing.Point(41, 21);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(65, 15);
            this.labelSelectDate.TabIndex = 6;
            this.labelSelectDate.Text = "Select Date";
            // 
            // textBoxTotalCost
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxTotalCost, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxTotalCost, BunifuAnimatorNS.DecorationType.None);
            this.textBoxTotalCost.Location = new System.Drawing.Point(43, 455);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(180, 23);
            this.textBoxTotalCost.TabIndex = 8;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelTotalCost, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelTotalCost, BunifuAnimatorNS.DecorationType.None);
            this.labelTotalCost.Location = new System.Drawing.Point(41, 437);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(63, 15);
            this.labelTotalCost.TabIndex = 38;
            this.labelTotalCost.Text = "Total Price";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonAddToCart, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonAddToCart, BunifuAnimatorNS.DecorationType.None);
            this.buttonAddToCart.FlatAppearance.BorderSize = 2;
            this.buttonAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddToCart.Location = new System.Drawing.Point(44, 553);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(180, 38);
            this.buttonAddToCart.TabIndex = 10;
            this.buttonAddToCart.Text = "ADD TO CART";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // labelProductInfo
            // 
            this.labelProductInfo.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProductInfo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProductInfo, BunifuAnimatorNS.DecorationType.None);
            this.labelProductInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductInfo.Location = new System.Drawing.Point(40, 149);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(166, 21);
            this.labelProductInfo.TabIndex = 36;
            this.labelProductInfo.Text = "Product Information";
            // 
            // textBoxProdCost
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxProdCost, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxProdCost, BunifuAnimatorNS.DecorationType.None);
            this.textBoxProdCost.Enabled = false;
            this.textBoxProdCost.Location = new System.Drawing.Point(46, 396);
            this.textBoxProdCost.Name = "textBoxProdCost";
            this.textBoxProdCost.Size = new System.Drawing.Size(180, 23);
            this.textBoxProdCost.TabIndex = 7;
            // 
            // labelProdCost
            // 
            this.labelProdCost.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProdCost, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProdCost, BunifuAnimatorNS.DecorationType.None);
            this.labelProdCost.Location = new System.Drawing.Point(41, 378);
            this.labelProdCost.Name = "labelProdCost";
            this.labelProdCost.Size = new System.Drawing.Size(109, 15);
            this.labelProdCost.TabIndex = 34;
            this.labelProdCost.Text = "Unit Purchase Price";
            // 
            // textBoxQuantity
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxQuantity, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxQuantity, BunifuAnimatorNS.DecorationType.None);
            this.textBoxQuantity.Enabled = false;
            this.textBoxQuantity.Location = new System.Drawing.Point(46, 341);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(180, 23);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // labelQuantityOrdered
            // 
            this.labelQuantityOrdered.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelQuantityOrdered, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelQuantityOrdered, BunifuAnimatorNS.DecorationType.None);
            this.labelQuantityOrdered.Location = new System.Drawing.Point(41, 319);
            this.labelQuantityOrdered.Name = "labelQuantityOrdered";
            this.labelQuantityOrdered.Size = new System.Drawing.Size(99, 15);
            this.labelQuantityOrdered.TabIndex = 32;
            this.labelQuantityOrdered.Text = "Quantity Ordered";
            // 
            // comboBoxSelectProduct
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.comboBoxSelectProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.comboBoxSelectProduct, BunifuAnimatorNS.DecorationType.None);
            this.comboBoxSelectProduct.FormattingEnabled = true;
            this.comboBoxSelectProduct.Location = new System.Drawing.Point(44, 227);
            this.comboBoxSelectProduct.Name = "comboBoxSelectProduct";
            this.comboBoxSelectProduct.Size = new System.Drawing.Size(180, 23);
            this.comboBoxSelectProduct.TabIndex = 4;
            this.comboBoxSelectProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectProduct_SelectedIndexChanged);
            // 
            // labelSelectProduct
            // 
            this.labelSelectProduct.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelSelectProduct, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelSelectProduct, BunifuAnimatorNS.DecorationType.None);
            this.labelSelectProduct.Location = new System.Drawing.Point(41, 202);
            this.labelSelectProduct.Name = "labelSelectProduct";
            this.labelSelectProduct.Size = new System.Drawing.Size(83, 15);
            this.labelSelectProduct.TabIndex = 30;
            this.labelSelectProduct.Text = "Select Product";
            // 
            // labelProductDateError
            // 
            this.labelProductDateError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProductDateError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProductDateError, BunifuAnimatorNS.DecorationType.None);
            this.labelProductDateError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductDateError.ForeColor = System.Drawing.Color.Red;
            this.labelProductDateError.Location = new System.Drawing.Point(203, 256);
            this.labelProductDateError.Name = "labelProductDateError";
            this.labelProductDateError.Size = new System.Drawing.Size(20, 28);
            this.labelProductDateError.TabIndex = 40;
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
            this.labelQuantityError.Location = new System.Drawing.Point(205, 371);
            this.labelQuantityError.Name = "labelQuantityError";
            this.labelQuantityError.Size = new System.Drawing.Size(20, 28);
            this.labelQuantityError.TabIndex = 41;
            this.labelQuantityError.Text = "*";
            this.labelQuantityError.Visible = false;
            // 
            // textBoxQuantityReceived
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxQuantityReceived, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxQuantityReceived, BunifuAnimatorNS.DecorationType.None);
            this.textBoxQuantityReceived.Location = new System.Drawing.Point(44, 284);
            this.textBoxQuantityReceived.Name = "textBoxQuantityReceived";
            this.textBoxQuantityReceived.Size = new System.Drawing.Size(180, 23);
            this.textBoxQuantityReceived.TabIndex = 5;
            // 
            // labelQuantityReceived
            // 
            this.labelQuantityReceived.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelQuantityReceived, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelQuantityReceived, BunifuAnimatorNS.DecorationType.None);
            this.labelQuantityReceived.Location = new System.Drawing.Point(41, 264);
            this.labelQuantityReceived.Name = "labelQuantityReceived";
            this.labelQuantityReceived.Size = new System.Drawing.Size(103, 15);
            this.labelQuantityReceived.TabIndex = 42;
            this.labelQuantityReceived.Text = "Quantity Received";
            // 
            // labelQuntityReceivedError
            // 
            this.labelQuntityReceivedError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelQuntityReceivedError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelQuntityReceivedError, BunifuAnimatorNS.DecorationType.None);
            this.labelQuntityReceivedError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuntityReceivedError.ForeColor = System.Drawing.Color.Red;
            this.labelQuntityReceivedError.Location = new System.Drawing.Point(202, 314);
            this.labelQuntityReceivedError.Name = "labelQuntityReceivedError";
            this.labelQuntityReceivedError.Size = new System.Drawing.Size(20, 28);
            this.labelQuntityReceivedError.TabIndex = 44;
            this.labelQuntityReceivedError.Text = "*";
            this.labelQuntityReceivedError.Visible = false;
            // 
            // dataGridViewPOLines
            // 
            this.dataGridViewPOLines.AllowUserToAddRows = false;
            this.dataGridViewPOLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPOLines.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPOLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPOLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPOLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoLineIdGv,
            this.ProductIdGv,
            this.LineNo,
            this.ProductNameGv,
            this.ProductPriceGv,
            this.ProductTotalPrice,
            this.ProductQuantityGv,
            this.QuantityReceivedDgv,
            this.UnitGv,
            this.ReceivedQuantityCostDgv});
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.dataGridViewPOLines, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.dataGridViewPOLines, BunifuAnimatorNS.DecorationType.None);
            this.dataGridViewPOLines.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPOLines.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPOLines.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewPOLines.Name = "dataGridViewPOLines";
            this.dataGridViewPOLines.RowHeadersVisible = false;
            this.dataGridViewPOLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPOLines.Size = new System.Drawing.Size(1113, 380);
            this.dataGridViewPOLines.TabIndex = 5;
            this.dataGridViewPOLines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPOLines_CellClick_1);
            // 
            // PoLineIdGv
            // 
            this.PoLineIdGv.HeaderText = "POLineId";
            this.PoLineIdGv.Name = "PoLineIdGv";
            this.PoLineIdGv.ReadOnly = true;
            this.PoLineIdGv.Visible = false;
            // 
            // ProductIdGv
            // 
            this.ProductIdGv.HeaderText = "ProductId";
            this.ProductIdGv.Name = "ProductIdGv";
            this.ProductIdGv.ReadOnly = true;
            this.ProductIdGv.Visible = false;
            // 
            // LineNo
            // 
            this.LineNo.HeaderText = "Line No.";
            this.LineNo.Name = "LineNo";
            this.LineNo.ReadOnly = true;
            // 
            // ProductNameGv
            // 
            this.ProductNameGv.HeaderText = "Product Name";
            this.ProductNameGv.Name = "ProductNameGv";
            this.ProductNameGv.ReadOnly = true;
            // 
            // ProductPriceGv
            // 
            this.ProductPriceGv.HeaderText = "Unit Purchase Price";
            this.ProductPriceGv.Name = "ProductPriceGv";
            this.ProductPriceGv.ReadOnly = true;
            // 
            // ProductTotalPrice
            // 
            this.ProductTotalPrice.HeaderText = "Product Total Price";
            this.ProductTotalPrice.Name = "ProductTotalPrice";
            this.ProductTotalPrice.ReadOnly = true;
            // 
            // ProductQuantityGv
            // 
            this.ProductQuantityGv.HeaderText = "Quantity Ordered";
            this.ProductQuantityGv.Name = "ProductQuantityGv";
            this.ProductQuantityGv.ReadOnly = true;
            // 
            // QuantityReceivedDgv
            // 
            this.QuantityReceivedDgv.HeaderText = "Quantity Received";
            this.QuantityReceivedDgv.Name = "QuantityReceivedDgv";
            this.QuantityReceivedDgv.ReadOnly = true;
            // 
            // UnitGv
            // 
            this.UnitGv.HeaderText = "Unit";
            this.UnitGv.Name = "UnitGv";
            this.UnitGv.ReadOnly = true;
            // 
            // ReceivedQuantityCostDgv
            // 
            this.ReceivedQuantityCostDgv.HeaderText = "Received Quantity Price";
            this.ReceivedQuantityCostDgv.Name = "ReceivedQuantityCostDgv";
            this.ReceivedQuantityCostDgv.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelGrossTotal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelGrandTotalValue, 1, 0);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 480);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1113, 198);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // labelGrossTotal
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelGrossTotal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelGrossTotal, BunifuAnimatorNS.DecorationType.None);
            this.labelGrossTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGrossTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrossTotal.Location = new System.Drawing.Point(3, 0);
            this.labelGrossTotal.Name = "labelGrossTotal";
            this.labelGrossTotal.Size = new System.Drawing.Size(550, 198);
            this.labelGrossTotal.TabIndex = 0;
            this.labelGrossTotal.Text = "Gross Total Rs.";
            this.labelGrossTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGrandTotalValue
            // 
            this.labelGrandTotalValue.AutoSize = true;
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelGrandTotalValue, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelGrandTotalValue, BunifuAnimatorNS.DecorationType.None);
            this.labelGrandTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGrandTotalValue.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotalValue.Location = new System.Drawing.Point(559, 0);
            this.labelGrandTotalValue.Name = "labelGrandTotalValue";
            this.labelGrandTotalValue.Size = new System.Drawing.Size(551, 198);
            this.labelGrandTotalValue.TabIndex = 1;
            this.labelGrandTotalValue.Text = "0.00";
            this.labelGrandTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUnit
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxUnit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxUnit, BunifuAnimatorNS.DecorationType.None);
            this.textBoxUnit.Enabled = false;
            this.textBoxUnit.Location = new System.Drawing.Point(43, 506);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(180, 23);
            this.textBoxUnit.TabIndex = 9;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelUnit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelUnit, BunifuAnimatorNS.DecorationType.None);
            this.labelUnit.Location = new System.Drawing.Point(43, 481);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(29, 15);
            this.labelUnit.TabIndex = 45;
            this.labelUnit.Text = "Unit";
            // 
            // panelLeftMiddleMain
            // 
            this.panelLeftMiddleMain.Controls.Add(this.panelMenu);
            this.panelLeftMiddleMain.Controls.Add(this.panelRightSlider);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftMiddleMain.Location = new System.Drawing.Point(1, 58);
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
            this.panelMenu.TabIndex = 1;
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
            this.bunifuGradientPannelSidebar.Controls.Add(this.pictureBoxMenuonSideBar);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.bunifuGradientPannelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.bunifuGradientPannelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPannelSidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientTopRight = System.Drawing.Color.Yellow;
            this.bunifuGradientPannelSidebar.Location = new System.Drawing.Point(0, 4);
            this.bunifuGradientPannelSidebar.Name = "bunifuGradientPannelSidebar";
            this.bunifuGradientPannelSidebar.Quality = 10;
            this.bunifuGradientPannelSidebar.Size = new System.Drawing.Size(148, 618);
            this.bunifuGradientPannelSidebar.TabIndex = 0;
            this.bunifuGradientPannelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
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
            this.buttonMenuProducts.Location = new System.Drawing.Point(6, 465);
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
            this.buttonMenuStockOut.Location = new System.Drawing.Point(7, 400);
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
            this.buttonMenuStockIn.Location = new System.Drawing.Point(6, 338);
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
            this.buttonMenuRecv.Location = new System.Drawing.Point(6, 277);
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
            this.buttonMenuStock.Location = new System.Drawing.Point(6, 205);
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
            this.buttonMenuSales.Location = new System.Drawing.Point(7, 140);
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
            this.buttonMenuPO.Location = new System.Drawing.Point(7, 86);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 43);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(145, 23);
            this.bunifuSeparator1.TabIndex = 13;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBoxMenuonSideBar
            // 
            this.pictureBoxMenuonSideBar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.pictureBoxMenuonSideBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.pictureBoxMenuonSideBar, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxMenuonSideBar.Image = global::InventoryManagementSystem.Properties.Resources.Menuicon;
            this.pictureBoxMenuonSideBar.Location = new System.Drawing.Point(1, 12);
            this.pictureBoxMenuonSideBar.Name = "pictureBoxMenuonSideBar";
            this.pictureBoxMenuonSideBar.Size = new System.Drawing.Size(50, 20);
            this.pictureBoxMenuonSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenuonSideBar.TabIndex = 12;
            this.pictureBoxMenuonSideBar.TabStop = false;
            // 
            // panelRightSlider
            // 
            this.panelRightSlider.AutoScroll = true;
            this.panelRightSlider.Controls.Add(this.labelSelectDate);
            this.panelRightSlider.Controls.Add(this.labelSelectPO);
            this.panelRightSlider.Controls.Add(this.dateTimePickerPO);
            this.panelRightSlider.Controls.Add(this.comboBoxPO);
            this.panelRightSlider.Controls.Add(this.labelUnit);
            this.panelRightSlider.Controls.Add(this.textBoxUnit);
            this.panelRightSlider.Controls.Add(this.labelProductInfo);
            this.panelRightSlider.Controls.Add(this.labelSelectProduct);
            this.panelRightSlider.Controls.Add(this.buttonAddToCart);
            this.panelRightSlider.Controls.Add(this.labelTotalCost);
            this.panelRightSlider.Controls.Add(this.textBoxTotalCost);
            this.panelRightSlider.Controls.Add(this.textBoxQuantityReceived);
            this.panelRightSlider.Controls.Add(this.comboBoxSelectProduct);
            this.panelRightSlider.Controls.Add(this.labelQuantityReceived);
            this.panelRightSlider.Controls.Add(this.labelProdCost);
            this.panelRightSlider.Controls.Add(this.textBoxProdCost);
            this.panelRightSlider.Controls.Add(this.textBoxQuantity);
            this.panelRightSlider.Controls.Add(this.labelQuantityOrdered);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.panelRightSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSlider.Location = new System.Drawing.Point(0, 0);
            this.panelRightSlider.Name = "panelRightSlider";
            this.panelRightSlider.Size = new System.Drawing.Size(248, 620);
            this.panelRightSlider.TabIndex = 0;
            // 
            // labelMenuLabel
            // 
            this.labelMenuLabel.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.labelMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuLabel.Location = new System.Drawing.Point(66, 25);
            this.labelMenuLabel.Name = "labelMenuLabel";
            this.labelMenuLabel.Size = new System.Drawing.Size(39, 15);
            this.labelMenuLabel.TabIndex = 5;
            this.labelMenuLabel.Text = "Menu";
            // 
            // pictureBoxMenu
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxMenu.Image = global::InventoryManagementSystem.Properties.Resources.Menuicon;
            this.pictureBoxMenu.Location = new System.Drawing.Point(3, 22);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(45, 20);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 4;
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
            // POReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 678);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "POReceiving";
            this.Text = "POReceiving";
            this.Load += new System.EventHandler(this.POReceiving_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOLines)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelLeftMiddleMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.bunifuGradientPannelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuonSideBar)).EndInit();
            this.panelRightSlider.ResumeLayout(false);
            this.panelRightSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSelectPO;
        private System.Windows.Forms.ComboBox comboBoxPO;
        private System.Windows.Forms.DateTimePicker dateTimePickerPO;
        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelProductInfo;
        private System.Windows.Forms.TextBox textBoxProdCost;
        private System.Windows.Forms.Label labelProdCost;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantityOrdered;
        private System.Windows.Forms.ComboBox comboBoxSelectProduct;
        private System.Windows.Forms.Label labelSelectProduct;
        private System.Windows.Forms.Label labelProductDateError;
        private System.Windows.Forms.Label labelQuantityError;
        private System.Windows.Forms.TextBox textBoxQuantityReceived;
        private System.Windows.Forms.Label labelQuantityReceived;
        private System.Windows.Forms.Label labelQuntityReceivedError;
        private System.Windows.Forms.DataGridView dataGridViewPOLines;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelGrossTotal;
        private System.Windows.Forms.Label labelGrandTotalValue;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoLineIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReceivedDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedQuantityCostDgv;
        private System.Windows.Forms.Panel panelLeftMiddleMain;
        private System.Windows.Forms.Panel panelRightSlider;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPannelSidebar;
        private System.Windows.Forms.Label labelMenuLabel;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pictureBoxMenuonSideBar;
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