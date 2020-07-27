using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InventoryManagementSystem
{
    public partial class Product : Sample2
    {
        int edit = 0; //0 is an indication for save operation and 1 is an indifaction for update operation
        Retrievel retrieve = new Retrievel();
        int ProductId = 0;
       // short stat;
        int CategoryId = 0;
     
        public Product()
        {
            InitializeComponent();
            Products_Load();
            ShowDataInGrid();
            makeMneusmall();
        }

        void makeMneusmall()
        {
            bunifuGradientPannelSidebar.Visible = false;
            bunifuGradientPannelSidebar.Width = 0;
            panelMenu.Width = 1;
            panelRightSlider.Width = panelLeftMiddleMain.Width - panelMenu.Width;
            bunifuTransitionAnimationSideBack.Show(bunifuGradientPannelSidebar);
        }
        private void Products_Load()
        {
            //  MainClass.Disable_Reset(panelRightSlider);
            retrieve.GetLists("usp_GetCategoriesList", comboBoxCategory, "Category", "ID");
          
        }

        private void ShowDataInGrid()
        {
            retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv, SalesPriceGv);
        }
        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panelRightSlider);
            edit = 0;
            retrieve.GetLists("usp_GetCategoriesList", comboBoxCategory, "Category", "ID");
        }

        public override void buttonEdit_Click(object sender, EventArgs e)
        {
            edit = 1;

            MainClass.Enable(panelRightSlider);
           // retrieve.GetLists("usp_GetCategoriesList", comboBoxCategory, "Category", "ID");
        }

        public override void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void buttonDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion del = new Deletion();
                    del.DeleteDetails(ProductId, "Usp_RemoveCategoryProductDetails", "@Id");
                    retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv,SalesPriceGv);
                    MainClass.Disable_Reset(panelRightSlider);
                }
            }
        }

        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv,SalesPriceGv ,textBoxSearch.Text);

            }
            else
            {
                retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv, SalesPriceGv);
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxProductName.Text == "")
            {
                labelProductNameError.Visible = true;
            }
            else
            {
                labelProductNameError.Visible = false;
            }

            if (textBoxProductCode.Text == "")
            {
                labelProductCodeError.Visible = true;
            }
            else
            {
                labelProductCodeError.Visible = false;
            }
            if (textBoxPrice.Text == "")
            {
                labelPurchasePriceError.Visible = true;
            }
            else
            {
                labelPurchasePriceError.Visible = false;
            }
            if (textBoxUnit.Text == "")
            {
                labelUnitError.Visible = true;
            }
            else
            {
                labelUnitError.Visible = false;
            }
           
            if (textBoxMinimumValue.Text == "")
            {
                labelMinValueError.Visible = true;
            }
            else
            {
                labelMinValueError.Visible = false;
            }
            if (textBoxSalesPrice.Text == "")
            {
                labelSalePriceError.Visible = true;
            }
            else
            {
                labelSalePriceError.Visible = false;
            }

            if (comboBoxCategory.SelectedIndex == -1)
            {
                labelCategoryError.Visible = true;
            }
            else
            {
                labelCategoryError.Visible = false;
            }

            if (labelProductNameError.Visible || labelProductCodeError.Visible || labelPurchasePriceError.Visible || labelUnitError.Visible || labelMinValueError.Visible || labelCategoryError.Visible || labelSalePriceError.Visible)
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.
            }
            else
            {
                
                if (edit == 0)  //Code for save operation
                {
                    Insertion insert = new Insertion();
                    insert.SaveProductDetails(textBoxProductName.Text, textBoxProductCode.Text,Convert.ToDecimal(textBoxPrice.Text),textBoxUnit.Text,Convert.ToDecimal(textBoxMinimumValue.Text),Convert.ToInt32(comboBoxCategory.SelectedValue),Convert.ToDecimal(textBoxSalesPrice.Text),true);


                    retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv, SalesPriceGv);
                    //MainClass.Disable_Reset(panelRightSlider);

                }
                else if (edit == 1) //code for update operaiton
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation update = new Updation();
                        update.UpdateProductDetails(textBoxProductName.Text, textBoxProductCode.Text, Convert.ToDecimal(textBoxPrice.Text), textBoxUnit.Text, Convert.ToDecimal(textBoxMinimumValue.Text), CategoryId, ProductId,Convert.ToDecimal(textBoxSalesPrice.Text)) ;


                        retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv, SalesPriceGv);
                        //   MainClass.Disable_Reset(panelRightSlider);
                    }

                }
            }

        }

        public override void buttonView_Click(object sender, EventArgs e)
        {
            retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv, SalesPriceGv);

        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex!=-1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewProduct.Rows[e.RowIndex];
                ProductId = Convert.ToInt32(row.Cells[0].Value.ToString());
                textBoxProductName.Text = row.Cells[1].Value.ToString();
                textBoxProductCode.Text = row.Cells[2].Value.ToString();
                textBoxPrice.Text = row.Cells[3].Value.ToString();
                textBoxUnit.Text = row.Cells[4].Value.ToString();             
                textBoxMinimumValue.Text = row.Cells[6].Value.ToString();
                comboBoxCategory.SelectedValue = row.Cells["ProductCatIdGv"].Value.ToString();
                CategoryId = Convert.ToInt32(row.Cells["ProductCatIdGv"].Value.ToString());
                comboBoxCategory.Text = row.Cells[7].Value.ToString();
                MainClass.Disable(panelRightSlider);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex > 0)
            {
                CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue.ToString());
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && textBoxPrice.Text.IndexOf('.') != -1)//check if user has entered more than one dot .
            {
                e.Handled = true;
                return;
            }
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 46))  //46 is ASCCI Code for dot "." 
            {

                e.Handled = true;
            }

        }


        private void textBoxMinimumValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && textBoxMinimumValue.Text.IndexOf('.') != -1)//check if user has entered more than one dot .
            {
                e.Handled = true;
                return;
            }
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 46))  //46 is ASCCI Code for dot "." 
            {

                e.Handled = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxPath.Text = FileDialog.FileName;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string pathCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBoxPath.Text + "; Extended Properties=\"Excel 8.0;HDR=Yes\";";
            OleDbConnection conn = new OleDbConnection(pathCon);
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EntrySheet$]", conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            Insertion insert = new Insertion();
            foreach (DataRow row in dt.Rows)
            {
                DataTable dtcategoryId = retrieve.GetId("usp_GetCategoryId",row[5].ToString());
                insert.SaveProductDetails(row[0].ToString(), row[1].ToString(), Convert.ToDecimal(row[2]), row[3].ToString(), Convert.ToDecimal(row[4]), Convert.ToInt32(dtcategoryId.Rows[0][0].ToString()),Convert.ToDecimal(row[5]) );
            }
            retrieve.ShowProducts(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductPriceGv, ProductUnitGv, ProductMinValGv, ProductCatNameGv, ProductCatIdGv, SalesPriceGv);
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (bunifuGradientPannelSidebar.Width < 50)
            {
                bunifuGradientPannelSidebar.Visible = false;
                bunifuGradientPannelSidebar.Width = 148;
                panelMenu.Width = 150;

                panelRightSlider.Width = panelLeftMiddleMain.Width - panelMenu.Width;
                bunifuTransitionAnimationSideBar.Show(bunifuGradientPannelSidebar);
            }
            else
            {
                bunifuGradientPannelSidebar.Visible = false;
                bunifuGradientPannelSidebar.Width = 0;
                panelMenu.Width = 1;
                panelRightSlider.Width = panelLeftMiddleMain.Width - panelMenu.Width;
                bunifuTransitionAnimationSideBack.Show(bunifuGradientPannelSidebar);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            MainClass.ShowWindow(PO, this, MDI.ActiveForm);
        }

        private void bunifuFlatButtonSales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            MainClass.ShowWindow(sale, this, MDI.ActiveForm);
        }

        private void bunifuFlatButtonStocks_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void bunifuFlatButtonPORecv_Click(object sender, EventArgs e)
        {
            POReceiving por = new POReceiving();
            MainClass.ShowWindow(por, this, MDI.ActiveForm);
        }

        private void bunifuFlatButtonStocksIn_Click(object sender, EventArgs e)
        {
            StockIn stkin = new StockIn();
            MainClass.ShowWindow(stkin, this, MDI.ActiveForm);
        }

        private void bunifuFlatButtonStocksOut_Click(object sender, EventArgs e)
        {
            StockOut StkOut = new StockOut();
            MainClass.ShowWindow(StkOut, this, MDI.ActiveForm);
        }

        private void bunifuFlatButtonProd_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            MainClass.ShowWindow(products, this, MDI.ActiveForm);
        }

        private void buttonMenuPO_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            MainClass.ShowWindow(PO, this, MDI.ActiveForm);
        }

        private void buttonMenuSales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            MainClass.ShowWindow(sale, this, MDI.ActiveForm);
        }

        private void buttonMenuStock_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void buttonMenuRecv_Click(object sender, EventArgs e)
        {
            POReceiving por = new POReceiving();
            MainClass.ShowWindow(por, this, MDI.ActiveForm);
        }

        private void buttonMenuStockIn_Click(object sender, EventArgs e)
        {
            StockIn stkin = new StockIn();
            MainClass.ShowWindow(stkin, this, MDI.ActiveForm);
        }

        private void buttonMenuStockOut_Click(object sender, EventArgs e)
        {
            StockOut StkOut = new StockOut();
            MainClass.ShowWindow(StkOut, this, MDI.ActiveForm);
        }

        private void buttonMenuProducts_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            MainClass.ShowWindow(products, this, MDI.ActiveForm);
        }
    }
}
