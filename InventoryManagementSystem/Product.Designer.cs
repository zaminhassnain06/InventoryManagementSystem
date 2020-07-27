namespace InventoryManagementSystem
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPurchasePrice = new System.Windows.Forms.Label();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductNameError = new System.Windows.Forms.Label();
            this.labelPurchasePriceError = new System.Windows.Forms.Label();
            this.labelUnitError = new System.Windows.Forms.Label();
            this.labelProductCodeError = new System.Windows.Forms.Label();
            this.textBoxMinimumValue = new System.Windows.Forms.TextBox();
            this.labelMinimumValue = new System.Windows.Forms.Label();
            this.labelMinValueError = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCategoryError = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.ProductIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCodeGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPriceGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMinValGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCatNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCatIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxSalesPrice = new System.Windows.Forms.TextBox();
            this.labelSalesPrice = new System.Windows.Forms.Label();
            this.labelSalePriceError = new System.Windows.Forms.Label();
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
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftMiddleMain, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panelLeftTop, 0);
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
            // textBoxUnit
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxUnit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxUnit, BunifuAnimatorNS.DecorationType.None);
            this.textBoxUnit.Location = new System.Drawing.Point(43, 263);
            this.textBoxUnit.MaxLength = 50;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(180, 23);
            this.textBoxUnit.TabIndex = 6;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelUnit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelUnit, BunifuAnimatorNS.DecorationType.None);
            this.labelUnit.Location = new System.Drawing.Point(40, 242);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(29, 15);
            this.labelUnit.TabIndex = 21;
            this.labelUnit.Text = "Unit";
            // 
            // textBoxPrice
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxPrice, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxPrice, BunifuAnimatorNS.DecorationType.None);
            this.textBoxPrice.Location = new System.Drawing.Point(43, 152);
            this.textBoxPrice.MaxLength = 20;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(180, 23);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPurchasePrice
            // 
            this.labelPurchasePrice.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelPurchasePrice, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelPurchasePrice, BunifuAnimatorNS.DecorationType.None);
            this.labelPurchasePrice.Location = new System.Drawing.Point(40, 134);
            this.labelPurchasePrice.Name = "labelPurchasePrice";
            this.labelPurchasePrice.Size = new System.Drawing.Size(84, 15);
            this.labelPurchasePrice.TabIndex = 20;
            this.labelPurchasePrice.Text = "Purchase Price";
            // 
            // textBoxProductCode
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxProductCode, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxProductCode, BunifuAnimatorNS.DecorationType.None);
            this.textBoxProductCode.Location = new System.Drawing.Point(43, 101);
            this.textBoxProductCode.MaxLength = 50;
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(180, 23);
            this.textBoxProductCode.TabIndex = 3;
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProductCode, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProductCode, BunifuAnimatorNS.DecorationType.None);
            this.labelProductCode.Location = new System.Drawing.Point(40, 77);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(35, 15);
            this.labelProductCode.TabIndex = 18;
            this.labelProductCode.Text = "Code";
            // 
            // textBoxProductName
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxProductName, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxProductName, BunifuAnimatorNS.DecorationType.None);
            this.textBoxProductName.Location = new System.Drawing.Point(43, 47);
            this.textBoxProductName.MaxLength = 100;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(180, 23);
            this.textBoxProductName.TabIndex = 2;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProductName, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProductName, BunifuAnimatorNS.DecorationType.None);
            this.labelProductName.Location = new System.Drawing.Point(40, 29);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(82, 15);
            this.labelProductName.TabIndex = 15;
            this.labelProductName.Text = "Product name";
            // 
            // labelProductNameError
            // 
            this.labelProductNameError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProductNameError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProductNameError, BunifuAnimatorNS.DecorationType.None);
            this.labelProductNameError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductNameError.ForeColor = System.Drawing.Color.Red;
            this.labelProductNameError.Location = new System.Drawing.Point(193, 16);
            this.labelProductNameError.Name = "labelProductNameError";
            this.labelProductNameError.Size = new System.Drawing.Size(20, 28);
            this.labelProductNameError.TabIndex = 22;
            this.labelProductNameError.Text = "*";
            this.labelProductNameError.Visible = false;
            // 
            // labelPurchasePriceError
            // 
            this.labelPurchasePriceError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelPurchasePriceError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelPurchasePriceError, BunifuAnimatorNS.DecorationType.None);
            this.labelPurchasePriceError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchasePriceError.ForeColor = System.Drawing.Color.Red;
            this.labelPurchasePriceError.Location = new System.Drawing.Point(193, 125);
            this.labelPurchasePriceError.Name = "labelPurchasePriceError";
            this.labelPurchasePriceError.Size = new System.Drawing.Size(20, 28);
            this.labelPurchasePriceError.TabIndex = 24;
            this.labelPurchasePriceError.Text = "*";
            this.labelPurchasePriceError.Visible = false;
            // 
            // labelUnitError
            // 
            this.labelUnitError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelUnitError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelUnitError, BunifuAnimatorNS.DecorationType.None);
            this.labelUnitError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitError.ForeColor = System.Drawing.Color.Red;
            this.labelUnitError.Location = new System.Drawing.Point(193, 231);
            this.labelUnitError.Name = "labelUnitError";
            this.labelUnitError.Size = new System.Drawing.Size(20, 28);
            this.labelUnitError.TabIndex = 25;
            this.labelUnitError.Text = "*";
            this.labelUnitError.Visible = false;
            // 
            // labelProductCodeError
            // 
            this.labelProductCodeError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelProductCodeError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelProductCodeError, BunifuAnimatorNS.DecorationType.None);
            this.labelProductCodeError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductCodeError.ForeColor = System.Drawing.Color.Red;
            this.labelProductCodeError.Location = new System.Drawing.Point(193, 73);
            this.labelProductCodeError.Name = "labelProductCodeError";
            this.labelProductCodeError.Size = new System.Drawing.Size(20, 28);
            this.labelProductCodeError.TabIndex = 23;
            this.labelProductCodeError.Text = "*";
            this.labelProductCodeError.Visible = false;
            // 
            // textBoxMinimumValue
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxMinimumValue, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxMinimumValue, BunifuAnimatorNS.DecorationType.None);
            this.textBoxMinimumValue.Location = new System.Drawing.Point(43, 315);
            this.textBoxMinimumValue.MaxLength = 50;
            this.textBoxMinimumValue.Name = "textBoxMinimumValue";
            this.textBoxMinimumValue.Size = new System.Drawing.Size(180, 23);
            this.textBoxMinimumValue.TabIndex = 7;
            this.textBoxMinimumValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinimumValue_KeyPress);
            // 
            // labelMinimumValue
            // 
            this.labelMinimumValue.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelMinimumValue, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelMinimumValue, BunifuAnimatorNS.DecorationType.None);
            this.labelMinimumValue.Location = new System.Drawing.Point(40, 297);
            this.labelMinimumValue.Name = "labelMinimumValue";
            this.labelMinimumValue.Size = new System.Drawing.Size(92, 15);
            this.labelMinimumValue.TabIndex = 30;
            this.labelMinimumValue.Text = "Minimum Value";
            // 
            // labelMinValueError
            // 
            this.labelMinValueError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelMinValueError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelMinValueError, BunifuAnimatorNS.DecorationType.None);
            this.labelMinValueError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinValueError.ForeColor = System.Drawing.Color.Red;
            this.labelMinValueError.Location = new System.Drawing.Point(193, 286);
            this.labelMinValueError.Name = "labelMinValueError";
            this.labelMinValueError.Size = new System.Drawing.Size(20, 28);
            this.labelMinValueError.TabIndex = 31;
            this.labelMinValueError.Text = "*";
            this.labelMinValueError.Visible = false;
            // 
            // comboBoxCategory
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.comboBoxCategory, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.comboBoxCategory, BunifuAnimatorNS.DecorationType.None);
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(43, 372);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(180, 23);
            this.comboBoxCategory.TabIndex = 8;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelCategory, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelCategory, BunifuAnimatorNS.DecorationType.None);
            this.labelCategory.Location = new System.Drawing.Point(40, 354);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 15);
            this.labelCategory.TabIndex = 33;
            this.labelCategory.Text = "Category";
            // 
            // labelCategoryError
            // 
            this.labelCategoryError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelCategoryError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelCategoryError, BunifuAnimatorNS.DecorationType.None);
            this.labelCategoryError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryError.ForeColor = System.Drawing.Color.Red;
            this.labelCategoryError.Location = new System.Drawing.Point(193, 341);
            this.labelCategoryError.Name = "labelCategoryError";
            this.labelCategoryError.Size = new System.Drawing.Size(20, 28);
            this.labelCategoryError.TabIndex = 34;
            this.labelCategoryError.Text = "*";
            this.labelCategoryError.Visible = false;
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
            this.ProductPriceGv,
            this.SalesPriceGv,
            this.ProductUnitGv,
            this.ProductMinValGv,
            this.ProductCatNameGv,
            this.ProductCatIdGv});
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
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1113, 578);
            this.dataGridViewProduct.TabIndex = 4;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
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
            // ProductPriceGv
            // 
            this.ProductPriceGv.HeaderText = "Purchase Price";
            this.ProductPriceGv.Name = "ProductPriceGv";
            this.ProductPriceGv.ReadOnly = true;
            // 
            // SalesPriceGv
            // 
            this.SalesPriceGv.HeaderText = "Sales Price";
            this.SalesPriceGv.Name = "SalesPriceGv";
            this.SalesPriceGv.ReadOnly = true;
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
            // 
            // ProductCatNameGv
            // 
            this.ProductCatNameGv.HeaderText = "Category Name";
            this.ProductCatNameGv.Name = "ProductCatNameGv";
            this.ProductCatNameGv.ReadOnly = true;
            // 
            // ProductCatIdGv
            // 
            this.ProductCatIdGv.HeaderText = "ProductCatId";
            this.ProductCatIdGv.Name = "ProductCatIdGv";
            this.ProductCatIdGv.Visible = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonBrowse, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonBrowse, BunifuAnimatorNS.DecorationType.None);
            this.buttonBrowse.FlatAppearance.BorderSize = 2;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBrowse.Location = new System.Drawing.Point(43, 425);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(180, 38);
            this.buttonBrowse.TabIndex = 9;
            this.buttonBrowse.Text = "BROWSE XLS FILE";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxPath
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxPath, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxPath, BunifuAnimatorNS.DecorationType.None);
            this.textBoxPath.Location = new System.Drawing.Point(43, 489);
            this.textBoxPath.MaxLength = 100;
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(180, 23);
            this.textBoxPath.TabIndex = 10;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.DarkGray;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.buttonExport, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.buttonExport, BunifuAnimatorNS.DecorationType.None);
            this.buttonExport.FlatAppearance.BorderSize = 2;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExport.Location = new System.Drawing.Point(43, 529);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(180, 38);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "IMPORT AND SAVE FILE DATA";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxSalesPrice
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxSalesPrice, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxSalesPrice, BunifuAnimatorNS.DecorationType.None);
            this.textBoxSalesPrice.Location = new System.Drawing.Point(43, 206);
            this.textBoxSalesPrice.MaxLength = 20;
            this.textBoxSalesPrice.Name = "textBoxSalesPrice";
            this.textBoxSalesPrice.Size = new System.Drawing.Size(180, 23);
            this.textBoxSalesPrice.TabIndex = 5;
            // 
            // labelSalesPrice
            // 
            this.labelSalesPrice.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelSalesPrice, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelSalesPrice, BunifuAnimatorNS.DecorationType.None);
            this.labelSalesPrice.Location = new System.Drawing.Point(40, 187);
            this.labelSalesPrice.Name = "labelSalesPrice";
            this.labelSalesPrice.Size = new System.Drawing.Size(62, 15);
            this.labelSalesPrice.TabIndex = 39;
            this.labelSalesPrice.Text = "Sales Price";
            // 
            // labelSalePriceError
            // 
            this.labelSalePriceError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelSalePriceError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelSalePriceError, BunifuAnimatorNS.DecorationType.None);
            this.labelSalePriceError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalePriceError.ForeColor = System.Drawing.Color.Red;
            this.labelSalePriceError.Location = new System.Drawing.Point(193, 178);
            this.labelSalePriceError.Name = "labelSalePriceError";
            this.labelSalePriceError.Size = new System.Drawing.Size(20, 28);
            this.labelSalePriceError.TabIndex = 40;
            this.labelSalePriceError.Text = "*";
            this.labelSalePriceError.Visible = false;
            // 
            // panelLeftMiddleMain
            // 
            this.panelLeftMiddleMain.Controls.Add(this.panelMenu);
            this.panelLeftMiddleMain.Controls.Add(this.panelRightSlider);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftMiddleMain.Location = new System.Drawing.Point(1, 56);
            this.panelLeftMiddleMain.Name = "panelLeftMiddleMain";
            this.panelLeftMiddleMain.Size = new System.Drawing.Size(245, 619);
            this.panelLeftMiddleMain.TabIndex = 41;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.bunifuGradientPannelSidebar);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(40, 619);
            this.panelMenu.TabIndex = 0;
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
            this.bunifuGradientPannelSidebar.Location = new System.Drawing.Point(-1, 2);
            this.bunifuGradientPannelSidebar.Name = "bunifuGradientPannelSidebar";
            this.bunifuGradientPannelSidebar.Quality = 10;
            this.bunifuGradientPannelSidebar.Size = new System.Drawing.Size(135, 615);
            this.bunifuGradientPannelSidebar.TabIndex = 1;
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
            this.buttonMenuProducts.Location = new System.Drawing.Point(3, 453);
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
            this.buttonMenuStockOut.Location = new System.Drawing.Point(4, 388);
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
            this.buttonMenuStockIn.Location = new System.Drawing.Point(3, 326);
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
            this.buttonMenuRecv.Location = new System.Drawing.Point(3, 265);
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
            this.buttonMenuStock.Location = new System.Drawing.Point(3, 193);
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
            this.buttonMenuSales.Location = new System.Drawing.Point(4, 128);
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
            this.buttonMenuPO.Location = new System.Drawing.Point(4, 74);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 41);
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
            this.pictureBox1.Location = new System.Drawing.Point(2, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelRightSlider
            // 
            this.panelRightSlider.AutoScroll = true;
            this.panelRightSlider.Controls.Add(this.labelProductNameError);
            this.panelRightSlider.Controls.Add(this.labelUnit);
            this.panelRightSlider.Controls.Add(this.labelCategory);
            this.panelRightSlider.Controls.Add(this.labelSalePriceError);
            this.panelRightSlider.Controls.Add(this.labelSalesPrice);
            this.panelRightSlider.Controls.Add(this.labelProductCodeError);
            this.panelRightSlider.Controls.Add(this.labelProductCode);
            this.panelRightSlider.Controls.Add(this.buttonExport);
            this.panelRightSlider.Controls.Add(this.comboBoxCategory);
            this.panelRightSlider.Controls.Add(this.labelCategoryError);
            this.panelRightSlider.Controls.Add(this.textBoxMinimumValue);
            this.panelRightSlider.Controls.Add(this.textBoxPath);
            this.panelRightSlider.Controls.Add(this.labelMinimumValue);
            this.panelRightSlider.Controls.Add(this.buttonBrowse);
            this.panelRightSlider.Controls.Add(this.labelUnitError);
            this.panelRightSlider.Controls.Add(this.textBoxSalesPrice);
            this.panelRightSlider.Controls.Add(this.textBoxProductName);
            this.panelRightSlider.Controls.Add(this.textBoxPrice);
            this.panelRightSlider.Controls.Add(this.labelProductName);
            this.panelRightSlider.Controls.Add(this.labelPurchasePrice);
            this.panelRightSlider.Controls.Add(this.textBoxProductCode);
            this.panelRightSlider.Controls.Add(this.labelPurchasePriceError);
            this.panelRightSlider.Controls.Add(this.labelMinValueError);
            this.panelRightSlider.Controls.Add(this.textBoxUnit);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.panelRightSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSlider.Location = new System.Drawing.Point(0, 0);
            this.panelRightSlider.Name = "panelRightSlider";
            this.panelRightSlider.Size = new System.Drawing.Size(245, 619);
            this.panelRightSlider.TabIndex = 38;
            // 
            // labelMenuLabel
            // 
            this.labelMenuLabel.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.labelMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuLabel.Location = new System.Drawing.Point(67, 25);
            this.labelMenuLabel.Name = "labelMenuLabel";
            this.labelMenuLabel.Size = new System.Drawing.Size(39, 15);
            this.labelMenuLabel.TabIndex = 7;
            this.labelMenuLabel.Text = "Menu";
            // 
            // pictureBoxMenu
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxMenu.Image = global::InventoryManagementSystem.Properties.Resources.Menuicon;
            this.pictureBoxMenu.Location = new System.Drawing.Point(4, 22);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(45, 20);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 6;
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
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 678);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Product";
            this.Text = "Product";
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

        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPurchasePrice;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductNameError;
        private System.Windows.Forms.Label labelPurchasePriceError;
        private System.Windows.Forms.Label labelUnitError;
        private System.Windows.Forms.Label labelProductCodeError;
        private System.Windows.Forms.Label labelCategoryError;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxMinimumValue;
        private System.Windows.Forms.Label labelMinimumValue;
        private System.Windows.Forms.Label labelMinValueError;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxSalesPrice;
        private System.Windows.Forms.Label labelSalesPrice;
        private System.Windows.Forms.Label labelSalePriceError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCodeGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPriceGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMinValGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCatNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCatIdGv;
        private System.Windows.Forms.Panel panelLeftMiddleMain;
        private System.Windows.Forms.Panel panelRightSlider;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPannelSidebar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMenuLabel;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
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