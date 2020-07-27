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
    public partial class SalesDetails : Sample2
    {
        Retrievel retrieve = new Retrievel();
       
        int SalesId = 0;
        
        Deletion delete = new Deletion();
        public SalesDetails()
        {
            InitializeComponent();
            tableLayoutPanel1.Visible = false;
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

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetSalesList", comboBoxSalesNumber, "CustomerName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
         //   retrieve.GetLists("usp_GetProductListforSale", comboBoxSelectProduct, "ProductName", "ID");

        }

        private void comboBoxSalesNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSalesNumber.SelectedIndex != -1 && comboBoxSalesNumber.SelectedIndex != 0)
            {
                SalesId = Convert.ToInt32(comboBoxSalesNumber.SelectedValue.ToString());
                retrieve.ShowSalesLines(dataGridViewSalesLines, PoLineIdGv, ProductIdGv, ProductNameGv, LineNo, ProductPriceGv, ProductQuantityGv, ProductTotalPrice, UnitGv, Convert.ToInt32(comboBoxSalesNumber.SelectedValue.ToString()));
                labelGrandTotalValue.Text = (retrieve.GetSalesGrossTotal(Convert.ToInt32(comboBoxSalesNumber.SelectedValue.ToString()))).ToString();
            }
        }

        protected override void buttonBack_Click(object sender, EventArgs e)
        {
           Sales obj = new Sales();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void dateTimePickerPO_ValueChanged(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetSalesList", comboBoxSalesNumber, "CustomerName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
        }

       
        public override void buttonEdit_Click(object sender, EventArgs e)
        {
            MainClass.Enable(panelRightSlider);
        }
        
        public override void buttonSave_Click(object sender, EventArgs e)
        {

            if (dataGridViewSalesLines.Rows.Count > 0)
            {

                Updation Update = new Updation();

                using (TransactionScope tc = new TransactionScope())
                {

                    int PoLines = 0;
                    foreach (DataGridViewRow row in dataGridViewSalesLines.Rows)
                    {

                        Update.UpdatePODetails(SalesId, Convert.ToInt32(row.Cells["ProductIdGv"].Value), Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value), Convert.ToDecimal(row.Cells["ProductQuantityGv"].Value), Convert.ToInt32(row.Cells[3].Value));
                        PoLines += 1;
                    }
                    if (PoLines > 0)
                    {
                        Update.UpdatePOPrice(SalesId, Convert.ToDecimal(labelGrandTotalValue.Text));
                        MainClass.ShowMessage("Purchase Order Updated Successfully.", "Success", "Success");
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to Update Purchase Order.", "Error", "Error");
                    }
                    tc.Complete();
                }

            }

        }

        
        private void buttonExport_Click(object sender, EventArgs e)
        {
            if(comboBoxSalesNumber.SelectedIndex>0)
            {
                CreateSalesPdfReport(SalesId);
            }
            else
            {
                MainClass.ShowMessage("Please Select a Sales Invoice first.", "Error", "Error");
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
            StockIn stkin = new StockIn();
            MainClass.ShowWindow(stkin, this, MDI.ActiveForm);
        }

        private void buttonMenuProducts_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            MainClass.ShowWindow(products, this, MDI.ActiveForm);
        }

        
    }
}
