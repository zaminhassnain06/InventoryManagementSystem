using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;


namespace InventoryManagementSystem
{
    public partial class Sales : Sample2
    {
       
        Retrievel retrieve = new Retrievel();
        int ProductId = 0;

        decimal AvailableStock;
        public Sales()
        {
            InitializeComponent();
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            groupBoxSearch.Visible = false;
            buttonView.Text = "Review Created Sales Invoice";
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
        private void Sales_Load(object sender, EventArgs e)
        {

            retrieve.GetLists("usp_GetCustomerList", comboBoxCustomer, "CustomerName", "ID");
            retrieve.GetLists("usp_GetProductListforSale", comboBoxSelectProduct, "ProductName", "ID");
            textBoxSalesNumber.Text = retrieve.RetrunSalesNumber().ToString();

        }


        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panelRightSlider);
           
            comboBoxSelectProduct.Enabled = false;
            textBoxQuantity.Enabled = false;
            textBoxTotalCost.Enabled = false;
            textBoxProdCost.Enabled = false;
            textBoxSalesNumber.Enabled = false;
            textBoxUnit.Enabled = false;
            textBoxAvailableStock.Enabled = false;
            DataTable dt = new DataTable();

            textBoxSalesNumber.Text = retrieve.RetrunSalesNumber().ToString();


        }

        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = retrieve.GetId("usp_GetProductID", comboBoxSelectProduct.Text);
            textBoxQuantity.Clear();
            textBoxTotalCost.Clear();
            textBoxProdCost.Clear();
            textBoxUnit.Clear();
            if (dt.Rows.Count > 0)
            {
                ProductId = Convert.ToInt32(dt.Rows[0][0].ToString());
                DataTable dtPrice = new DataTable();
                dtPrice = retrieve.GetProductPriceUnitStock(ProductId);
                if (dtPrice.Rows.Count > 0)
                {
                    textBoxProdCost.Text = dtPrice.Rows[0][3].ToString();
                    textBoxUnit.Text = dtPrice.Rows[0][1].ToString();
                    textBoxAvailableStock.Text = dtPrice.Rows[0][2].ToString();
                    AvailableStock =Convert.ToDecimal(dtPrice.Rows[0][2].ToString());
                }
            }
            foreach (DataGridViewRow row in dataGridViewSalesLines.Rows)
            {
                if (Convert.ToInt32(row.Cells["ProductIdGv"].Value) == ProductId)
                {
                    textBoxQuantity.Text = (row.Cells["ProductQuantityGv"].Value).ToString();
                    textBoxTotalCost.Text = (row.Cells["ProductTotalPrice"].Value).ToString();

                    break;
                }
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text != "" && textBoxProdCost.Text != "")
            {
                decimal totalcost = Convert.ToDecimal(textBoxQuantity.Text) * Convert.ToDecimal(textBoxProdCost.Text);
                textBoxTotalCost.Text = totalcost.ToString();
                if(Convert.ToDecimal(textBoxQuantity.Text)>AvailableStock)
                {
                    MainClass.ShowMessage("Quantity not availabe in stocks.", "Error", "Error");
                    buttonAddToCart.Enabled = false;
                }
                else
                {
                   
                    buttonAddToCart.Enabled = true;

                }
            }
        }

        private void checkBoxAddProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddProduct.Checked)
            {
                comboBoxSelectProduct.Enabled = true;
                textBoxQuantity.Enabled = true;
                textBoxTotalCost.Enabled = false;
                textBoxProdCost.Enabled = false;
                textBoxUnit.Enabled = false;
                textBoxAvailableStock.Enabled = false;

            }
            else
            {
                comboBoxSelectProduct.Enabled = false;
                textBoxQuantity.Enabled = false;
                textBoxTotalCost.Enabled = false;
                textBoxProdCost.Enabled = false;
                textBoxUnit.Enabled = false;
                textBoxAvailableStock.Enabled = false;
            }
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxAddProduct.Checked = false;
            comboBoxSelectProduct.Text = "";
            textBoxQuantity.Clear();
            textBoxTotalCost.Clear();
            textBoxProdCost.Clear();
            textBoxUnit.Clear();
            dataGridViewSalesLines.Rows.Clear();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedIndex == -1)
            {
                labelSupplierError.Visible = true;
            }
            else
            {
                labelSupplierError.Visible = false;
            }
            //if (dateTimePickerExpectedDelDate.Text == "")
            //{
            //    labelExpectedDelDateError.Visible = true;
            //}
            //else
            //{
            //    labelExpectedDelDateError.Visible = false;
            //}

            if (comboBoxSelectProduct.SelectedIndex == -1)
            {
                labelProductDateError.Visible = true;
            }
            else
            {
                labelProductDateError.Visible = false;
            }
            if (textBoxQuantity.Text == "")
            {
                labelQuantityError.Visible = true;
            }
            else
            {

                labelQuantityError.Visible = false;

            }
            if (labelSupplierError.Visible || labelProductDateError.Visible || labelQuantityError.Visible)
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.

            }
            else
            {
                bool checkDuplicate = false;
                foreach (DataGridViewRow row in dataGridViewSalesLines.Rows)
                {
                    if (row.Cells[0].Value.ToString() == ProductId.ToString())
                    {
                        checkDuplicate = true;
                        MainClass.ShowMessage("Product already entered.", "Error", "Error");
                    }

                }
                if (checkDuplicate == false)
                {
                    dataGridViewSalesLines.Rows.Add(ProductId, dataGridViewSalesLines.Rows.Count + 1, comboBoxSelectProduct.Text, textBoxQuantity.Text,textBoxUnit.Text ,textBoxProdCost.Text, textBoxTotalCost.Text);
                    labelGrandTotalValue.Text = (Convert.ToDecimal(labelGrandTotalValue.Text) + Convert.ToDecimal(textBoxTotalCost.Text)).ToString();

                }
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {

            if (dataGridViewSalesLines.Rows.Count>0)
            {
                int SalesID = 0;
                Insertion insert = new Insertion();
                using (TransactionScope tc = new TransactionScope())
                {
                    SalesID = insert.SaveSales(Convert.ToInt32(comboBoxCustomer.SelectedValue), Convert.ToDecimal(labelGrandTotalValue.Text), Retrievel.User_ID);
                    int SalesLines = 0;
                    foreach (DataGridViewRow row in dataGridViewSalesLines.Rows)
                    {
                        SalesLines += insert.SaveSalesLine(SalesID, Convert.ToInt32(row.Cells["ProductIdGv"].Value), Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value), Convert.ToDecimal(row.Cells["ProductQuantityGv"].Value), row.Cells["Unit"].Value.ToString(), Convert.ToInt32(row.Cells[1].Value));
                        if(SalesLines>0) //decrease the stock
                        { 
                            Updation update = new Updation();

                            int rowsDec = update.UpdateDecreaseAvailableStocks(Convert.ToInt32(row.Cells["ProductIdGv"].Value), Convert.ToDecimal(row.Cells["ProductQuantityGv"].Value));
                        }
                    }
                    if (SalesLines > 0)
                    {
                       
                        MainClass.ShowMessage("Sales Invoice Created Successfully.", "Success", "Success");
                        dataGridViewSalesLines.Rows.Clear();
                        textBoxSalesNumber.Text = retrieve.RetrunSalesNumber().ToString();
                        comboBoxCustomer.Text = "";
                        comboBoxSelectProduct.Text = "";
                        textBoxUnit.Clear();
                        textBoxQuantity.Clear();
                        textBoxProdCost.Clear();
                        textBoxTotalCost.Clear();
                        CreateSalesPdfReport(SalesID);
                        labelGrandTotalValue.Text = "0.00";
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to create Sales Invoice.", "Error", "Error");
                    }
                    tc.Complete();
                }

            }

        }
        private void CreateSalesPdfReport(int salesID)
        {
            try
            {
                //string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //Path += "\\Sales_PDF";

                //if (!System.IO.Directory.Exists(Path))
                //{
                //    System.IO.Directory.CreateDirectory(Path);
                //}

                //string dates = DateTime.Now.ToString();
                //string rd = dates.Replace("/", ":");
                //string rdd = rd.Replace(":", "_");

                //Path += "\\Sales_Number_" + salesID.ToString() + "_" + rdd + ".pdf";
                //string Customer = "Customer : ";

                //DataTable dtblCust = retrieve.GetSalesCustomerId(salesID);
                //if (dtblCust.Rows.Count > 0)
                //{
                //    Customer += dtblCust.Rows[0][0].ToString();
                //}
                //DataTable dtbl = retrieve.GetSalesLinesforPDFExport(salesID);
                //string Header = "Sales Invoice #" + salesID.ToString();
                //PDFReports pdf = new PDFReports();
                //pdf.ExportDataTableToPdfSales(dtbl, Path, Header, Customer, labelGrandTotalValue.Text);

                //System.Diagnostics.Process.Start(Path);
                SalesReport rpt = new SalesReport(salesID);
                rpt.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        public override void buttonView_Click(object sender, EventArgs e)
        {
            SalesDetails saleDet = new SalesDetails();
            MainClass.ShowWindow(saleDet, this, MDI.ActiveForm);

        }

        private void dataGridViewSalesLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 7)
                {
                    DataGridViewRow row = dataGridViewSalesLines.Rows[e.RowIndex];
                    string GrandTotal = labelGrandTotalValue.Text.ToString();

                    decimal TotalGrand = (Convert.ToDecimal(GrandTotal) - Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value.ToString()));
                    labelGrandTotalValue.Text = TotalGrand.ToString();
                    dataGridViewSalesLines.Rows.Remove(row);
                    if (dataGridViewSalesLines.Rows.Count > 0)
                    {
                        int i = 1;
                        foreach (DataGridViewRow rows in dataGridViewSalesLines.Rows)
                        {

                            rows.Cells["LineNo"].Value = i;
                            i++;
                        }
                    }

                }

            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && textBoxQuantity.Text.IndexOf('.') != -1)//check if user has entered more than one dot .
            {
                e.Handled = true;
                return;
            }
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 46))  //46 is ASCCI Code for dot "." 
            {

                e.Handled = true;
            }

            if (e.KeyChar == 13 && buttonAddToCart.Visible == true)
            {
                buttonAddToCart.PerformClick();
            }
            
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
