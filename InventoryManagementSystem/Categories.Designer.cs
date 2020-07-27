﻿namespace InventoryManagementSystem
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.labelisSales = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelCategoryNameError = new System.Windows.Forms.Label();
            this.labelIsSalesError = new System.Windows.Forms.Label();
            this.comboBoxIsSales = new System.Windows.Forms.ComboBox();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.catIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatGVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatGVStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labelMenuLabel = new System.Windows.Forms.Label();
            this.pictureBoxMenuMenu = new System.Windows.Forms.PictureBox();
            this.panelRightSlider = new System.Windows.Forms.Panel();
            this.bunifuTransitionAnimationSideBar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.bunifuTransitionAnimationSideBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LeftPanel.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.panelLeftMiddleMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.bunifuGradientPannelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMenu)).BeginInit();
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
            this.panelLeftTop.Controls.Add(this.label1);
            this.panelLeftTop.Controls.Add(this.pictureBoxMenu);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelLeftTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelLeftTop, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftTop.TabIndex = 0;
            this.panelLeftTop.Controls.SetChildIndex(this.buttonBack, 0);
            this.panelLeftTop.Controls.SetChildIndex(this.pictureBoxMenu, 0);
            this.panelLeftTop.Controls.SetChildIndex(this.label1, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridViewCat);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.rightPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.rightPanel, BunifuAnimatorNS.DecorationType.None);
            this.rightPanel.Controls.SetChildIndex(this.panelRightTop, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridViewCat, 0);
            // 
            // panelRightTop
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelRightTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelRightTop, BunifuAnimatorNS.DecorationType.None);
            // 
            // labelisSales
            // 
            this.labelisSales.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelisSales, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelisSales, BunifuAnimatorNS.DecorationType.None);
            this.labelisSales.Location = new System.Drawing.Point(42, 83);
            this.labelisSales.Name = "labelisSales";
            this.labelisSales.Size = new System.Drawing.Size(44, 15);
            this.labelisSales.TabIndex = 1;
            this.labelisSales.Text = "Is Sales";
            // 
            // textBoxCategoryName
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.textBoxCategoryName, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.textBoxCategoryName, BunifuAnimatorNS.DecorationType.None);
            this.textBoxCategoryName.Location = new System.Drawing.Point(45, 53);
            this.textBoxCategoryName.MaxLength = 100;
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(180, 23);
            this.textBoxCategoryName.TabIndex = 0;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelCategoryName, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelCategoryName, BunifuAnimatorNS.DecorationType.None);
            this.labelCategoryName.Location = new System.Drawing.Point(42, 35);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(88, 15);
            this.labelCategoryName.TabIndex = 0;
            this.labelCategoryName.Text = "Category name";
            // 
            // labelCategoryNameError
            // 
            this.labelCategoryNameError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelCategoryNameError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelCategoryNameError, BunifuAnimatorNS.DecorationType.None);
            this.labelCategoryNameError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryNameError.ForeColor = System.Drawing.Color.Red;
            this.labelCategoryNameError.Location = new System.Drawing.Point(205, 24);
            this.labelCategoryNameError.Name = "labelCategoryNameError";
            this.labelCategoryNameError.Size = new System.Drawing.Size(20, 28);
            this.labelCategoryNameError.TabIndex = 28;
            this.labelCategoryNameError.Text = "*";
            this.labelCategoryNameError.Visible = false;
            // 
            // labelIsSalesError
            // 
            this.labelIsSalesError.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelIsSalesError, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelIsSalesError, BunifuAnimatorNS.DecorationType.None);
            this.labelIsSalesError.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsSalesError.ForeColor = System.Drawing.Color.Red;
            this.labelIsSalesError.Location = new System.Drawing.Point(205, 79);
            this.labelIsSalesError.Name = "labelIsSalesError";
            this.labelIsSalesError.Size = new System.Drawing.Size(20, 28);
            this.labelIsSalesError.TabIndex = 29;
            this.labelIsSalesError.Text = "*";
            this.labelIsSalesError.Visible = false;
            // 
            // comboBoxIsSales
            // 
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.comboBoxIsSales, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.comboBoxIsSales, BunifuAnimatorNS.DecorationType.None);
            this.comboBoxIsSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsSales.FormattingEnabled = true;
            this.comboBoxIsSales.Items.AddRange(new object[] {
            "Sales",
            "Non Sales"});
            this.comboBoxIsSales.Location = new System.Drawing.Point(45, 101);
            this.comboBoxIsSales.Name = "comboBoxIsSales";
            this.comboBoxIsSales.Size = new System.Drawing.Size(180, 23);
            this.comboBoxIsSales.TabIndex = 1;
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.AllowUserToAddRows = false;
            this.dataGridViewCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIdGV,
            this.CatGVName,
            this.CatGVStatus});
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.dataGridViewCat, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.dataGridViewCat, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCat.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCat.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersVisible = false;
            this.dataGridViewCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCat.Size = new System.Drawing.Size(1113, 578);
            this.dataGridViewCat.TabIndex = 0;
            this.dataGridViewCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCat_CellClick);
            // 
            // catIdGV
            // 
            this.catIdGV.HeaderText = "catId";
            this.catIdGV.Name = "catIdGV";
            this.catIdGV.ReadOnly = true;
            this.catIdGV.Visible = false;
            // 
            // CatGVName
            // 
            this.CatGVName.HeaderText = "Category Name";
            this.CatGVName.Name = "CatGVName";
            this.CatGVName.ReadOnly = true;
            // 
            // CatGVStatus
            // 
            this.CatGVStatus.HeaderText = "Status";
            this.CatGVStatus.Name = "CatGVStatus";
            this.CatGVStatus.ReadOnly = true;
            // 
            // panelLeftMiddleMain
            // 
            this.panelLeftMiddleMain.Controls.Add(this.panelMenu);
            this.panelLeftMiddleMain.Controls.Add(this.panelRightSlider);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelLeftMiddleMain, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftMiddleMain.Location = new System.Drawing.Point(3, 61);
            this.panelLeftMiddleMain.Name = "panelLeftMiddleMain";
            this.panelLeftMiddleMain.Size = new System.Drawing.Size(245, 610);
            this.panelLeftMiddleMain.TabIndex = 30;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.bunifuGradientPannelSidebar);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(40, 610);
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
            this.bunifuGradientPannelSidebar.Controls.Add(this.labelMenuLabel);
            this.bunifuGradientPannelSidebar.Controls.Add(this.pictureBoxMenuMenu);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.bunifuGradientPannelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.bunifuGradientPannelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPannelSidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPannelSidebar.GradientTopRight = System.Drawing.Color.Yellow;
            this.bunifuGradientPannelSidebar.Location = new System.Drawing.Point(0, 3);
            this.bunifuGradientPannelSidebar.Name = "bunifuGradientPannelSidebar";
            this.bunifuGradientPannelSidebar.Quality = 10;
            this.bunifuGradientPannelSidebar.Size = new System.Drawing.Size(140, 600);
            this.bunifuGradientPannelSidebar.TabIndex = 0;
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
            this.buttonMenuProducts.Location = new System.Drawing.Point(2, 437);
            this.buttonMenuProducts.Name = "buttonMenuProducts";
            this.buttonMenuProducts.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuProducts.TabIndex = 6;
            this.buttonMenuProducts.Text = "Products";
            this.buttonMenuProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuProducts.UseVisualStyleBackColor = false;
            this.buttonMenuProducts.Click += new System.EventHandler(this.button7_Click);
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
            this.buttonMenuStockOut.Location = new System.Drawing.Point(3, 372);
            this.buttonMenuStockOut.Name = "buttonMenuStockOut";
            this.buttonMenuStockOut.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuStockOut.TabIndex = 5;
            this.buttonMenuStockOut.Text = "Stocks Out";
            this.buttonMenuStockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuStockOut.UseVisualStyleBackColor = false;
            this.buttonMenuStockOut.Click += new System.EventHandler(this.button6_Click);
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
            this.buttonMenuStockIn.Location = new System.Drawing.Point(2, 310);
            this.buttonMenuStockIn.Name = "buttonMenuStockIn";
            this.buttonMenuStockIn.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuStockIn.TabIndex = 4;
            this.buttonMenuStockIn.Text = "Stocks In";
            this.buttonMenuStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuStockIn.UseVisualStyleBackColor = false;
            this.buttonMenuStockIn.Click += new System.EventHandler(this.button5_Click);
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
            this.buttonMenuRecv.Location = new System.Drawing.Point(2, 249);
            this.buttonMenuRecv.Name = "buttonMenuRecv";
            this.buttonMenuRecv.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuRecv.TabIndex = 3;
            this.buttonMenuRecv.Text = "PO Receivings";
            this.buttonMenuRecv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuRecv.UseVisualStyleBackColor = false;
            this.buttonMenuRecv.Click += new System.EventHandler(this.button4_Click);
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
            this.buttonMenuStock.Location = new System.Drawing.Point(2, 177);
            this.buttonMenuStock.Name = "buttonMenuStock";
            this.buttonMenuStock.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuStock.TabIndex = 2;
            this.buttonMenuStock.Text = "Stock";
            this.buttonMenuStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuStock.UseVisualStyleBackColor = false;
            this.buttonMenuStock.Click += new System.EventHandler(this.button3_Click);
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
            this.buttonMenuSales.Location = new System.Drawing.Point(3, 112);
            this.buttonMenuSales.Name = "buttonMenuSales";
            this.buttonMenuSales.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuSales.TabIndex = 1;
            this.buttonMenuSales.Text = "Sales";
            this.buttonMenuSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuSales.UseVisualStyleBackColor = false;
            this.buttonMenuSales.Click += new System.EventHandler(this.button2_Click);
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
            this.buttonMenuPO.Location = new System.Drawing.Point(3, 58);
            this.buttonMenuPO.Name = "buttonMenuPO";
            this.buttonMenuPO.Size = new System.Drawing.Size(135, 40);
            this.buttonMenuPO.TabIndex = 0;
            this.buttonMenuPO.Text = "Purchase Order";
            this.buttonMenuPO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenuPO.UseVisualStyleBackColor = false;
            this.buttonMenuPO.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 29);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(156, 23);
            this.bunifuSeparator1.TabIndex = 30;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // labelMenuLabel
            // 
            this.labelMenuLabel.AutoSize = true;
            this.labelMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.labelMenuLabel, BunifuAnimatorNS.DecorationType.None);
            this.labelMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMenuLabel.Location = new System.Drawing.Point(54, 8);
            this.labelMenuLabel.Name = "labelMenuLabel";
            this.labelMenuLabel.Size = new System.Drawing.Size(39, 15);
            this.labelMenuLabel.TabIndex = 5;
            this.labelMenuLabel.Text = "Menu";
            // 
            // pictureBoxMenuMenu
            // 
            this.pictureBoxMenuMenu.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.pictureBoxMenuMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.pictureBoxMenuMenu, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxMenuMenu.Image = global::InventoryManagementSystem.Properties.Resources.Menuicon;
            this.pictureBoxMenuMenu.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMenuMenu.Name = "pictureBoxMenuMenu";
            this.pictureBoxMenuMenu.Size = new System.Drawing.Size(45, 20);
            this.pictureBoxMenuMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenuMenu.TabIndex = 6;
            this.pictureBoxMenuMenu.TabStop = false;
            // 
            // panelRightSlider
            // 
            this.panelRightSlider.AutoScroll = true;
            this.panelRightSlider.Controls.Add(this.comboBoxIsSales);
            this.panelRightSlider.Controls.Add(this.labelCategoryNameError);
            this.panelRightSlider.Controls.Add(this.labelIsSalesError);
            this.panelRightSlider.Controls.Add(this.labelisSales);
            this.panelRightSlider.Controls.Add(this.textBoxCategoryName);
            this.panelRightSlider.Controls.Add(this.labelCategoryName);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.panelRightSlider, BunifuAnimatorNS.DecorationType.None);
            this.panelRightSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSlider.Location = new System.Drawing.Point(0, 0);
            this.panelRightSlider.Name = "panelRightSlider";
            this.panelRightSlider.Size = new System.Drawing.Size(245, 610);
            this.panelRightSlider.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menu";
            // 
            // pictureBoxMenu
            // 
            this.bunifuTransitionAnimationSideBar.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this.pictureBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxMenu.Image = global::InventoryManagementSystem.Properties.Resources.Menuicon;
            this.pictureBoxMenu.Location = new System.Drawing.Point(6, 17);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(45, 20);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 4;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
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
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 678);
            this.bunifuTransitionAnimationSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransitionAnimationSideBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.panelLeftMiddleMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.bunifuGradientPannelSidebar.ResumeLayout(false);
            this.bunifuGradientPannelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuMenu)).EndInit();
            this.panelRightSlider.ResumeLayout(false);
            this.panelRightSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIsSales;
        private System.Windows.Forms.Label labelisSales;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label labelIsSalesError;
        private System.Windows.Forms.Label labelCategoryNameError;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatGVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatGVStatus;
        private System.Windows.Forms.Panel panelLeftMiddleMain;
        private System.Windows.Forms.Panel panelRightSlider;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPannelSidebar;
        private System.Windows.Forms.Label labelMenuLabel;
        private System.Windows.Forms.PictureBox pictureBoxMenuMenu;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransitionAnimationSideBar;
        private BunifuAnimatorNS.BunifuTransition bunifuTransitionAnimationSideBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenuPO;
        private System.Windows.Forms.Button buttonMenuSales;
        private System.Windows.Forms.Button buttonMenuProducts;
        private System.Windows.Forms.Button buttonMenuStockOut;
        private System.Windows.Forms.Button buttonMenuStockIn;
        private System.Windows.Forms.Button buttonMenuRecv;
        private System.Windows.Forms.Button buttonMenuStock;
    }
}