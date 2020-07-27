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
    public partial class POReceiving : Sample2
    {
        Retrievel retrieve = new Retrievel();
        int ProductId = 0;
        int ProductIdCellClick = 0;
        int POId = 0;
        int ReceivingId = 0;
        Deletion delete = new Deletion();

        public POReceiving()
        {
            InitializeComponent();
            //buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            groupBoxSearch.Visible = false;
            buttonView.Text = "Review Previous Receivings";
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
        private void POReceiving_Load(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetPOListfoReceiving", comboBoxPO, "SupplierName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
            retrieve.GetLists("usp_GetProductListforNonSale", comboBoxSelectProduct, "ProductName", "ID");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetPOList", comboBoxPO, "SupplierName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
        }
        public override void buttonView_Click(object sender, EventArgs e)
        {
            POReceivingDetails RecDet = new POReceivingDetails();
            MainClass.ShowWindow(RecDet, this, MDI.ActiveForm);

        }
        protected override void buttonBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = retrieve.GetId("usp_GetProductID", comboBoxSelectProduct.Text);
            textBoxQuantity.Clear();
            textBoxTotalCost.Clear();
            textBoxProdCost.Clear();
            textBoxQuantityReceived.Clear();

            if (dt.Rows.Count > 0)
            {
                ProductId = Convert.ToInt32(dt.Rows[0][0].ToString());

                DataTable dtPrice = new DataTable();
                dtPrice = retrieve.GetProductPrice(ProductId);
                if (dtPrice.Rows.Count > 0)
                {
                    textBoxProdCost.Text = dtPrice.Rows[0][0].ToString();
                    textBoxUnit.Text = dtPrice.Rows[0][1].ToString();
                }
                foreach (DataGridViewRow row in dataGridViewPOLines.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductIdGv"].Value) == ProductId)
                    {
                        textBoxQuantity.Text = (row.Cells["ProductQuantityGv"].Value).ToString();
                        textBoxTotalCost.Text = (row.Cells["ProductTotalPrice"].Value).ToString();

                        break;
                    }
                }
            }
        }

        private void dataGridViewPOLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }
        public override void buttonEdit_Click(object sender, EventArgs e)
        {
            MainClass.Enable(panelRightSlider);
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectProduct.SelectedIndex == -1)
            {
                labelProductDateError.Visible = true;
            }
            else
            {
                labelProductDateError.Visible = false;
            }
            if (textBoxQuantityReceived.Text == "")
            {
                labelQuntityReceivedError.Visible = true;
            }
            else
            {

                labelQuntityReceivedError.Visible = false;

            }
            if (labelProductDateError.Visible || labelQuntityReceivedError.Visible)
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.

            }
            else
            {
                bool checkDuplicate = false;


                foreach (DataGridViewRow row in dataGridViewPOLines.Rows)
                {
                    if (row.Cells["ProductIdGv"].Value.ToString() == ProductId.ToString())
                    {
                        checkDuplicate = true;

                        row.Cells["QuantityReceivedDgv"].Value = textBoxQuantityReceived.Text;
                        row.Cells["ReceivedQuantityCostDgv"].Value = (Convert.ToDecimal(textBoxQuantityReceived.Text) * Convert.ToDecimal(textBoxProdCost.Text)).ToString();

                        if (Convert.ToDecimal(textBoxQuantityReceived.Text) > Convert.ToDecimal(row.Cells["ProductQuantityGv"].Value))
                        {
                            decimal increase = Convert.ToDecimal(row.Cells["ReceivedQuantityCostDgv"].Value) - Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value);

                            string GrandTotal = labelGrandTotalValue.Text;

                            decimal TotalGrand = Convert.ToDecimal(GrandTotal) + increase;
                            labelGrandTotalValue.Text = TotalGrand.ToString();
                         
                         
                            break;
                        }
                        else if (Convert.ToDecimal(textBoxQuantityReceived.Text) < Convert.ToDecimal(row.Cells["ProductQuantityGv"].Value))
                        {
                            decimal decrease = Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value) - Convert.ToDecimal(row.Cells["ReceivedQuantityCostDgv"].Value);

                            string GrandTotal = labelGrandTotalValue.Text;

                            decimal TotalGrand = Convert.ToDecimal(GrandTotal) - decrease;
                            labelGrandTotalValue.Text = TotalGrand.ToString();
                
                            break;
                        }




                    }
                }
                if (checkDuplicate == false)
                {
                    DataTable dataTable = (DataTable)dataGridViewPOLines.DataSource;
                    DataRow drToAdd = dataTable.NewRow();

                    drToAdd["POLineID"] = ProductId.ToString();
                    drToAdd["ID"] = ProductId.ToString();
                    drToAdd["LineNumber"] = (dataGridViewPOLines.Rows.Count + 1).ToString();
                    drToAdd["ProductName"] = comboBoxSelectProduct.Text;
                    drToAdd["Quantity"] = textBoxQuantity.Text;
                    drToAdd["ProductCost"] = textBoxProdCost.Text;
                    drToAdd["TotalCost"] = textBoxTotalCost.Text;




                    dataTable.Rows.Add(drToAdd);
                    dataTable.AcceptChanges();

                  
                    labelGrandTotalValue.Text = (Convert.ToDecimal(labelGrandTotalValue.Text) + Convert.ToDecimal(textBoxTotalCost.Text)).ToString();

                }
            }
        }

        private void comboBoxPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPO.SelectedIndex != -1 && comboBoxPO.SelectedIndex != 0)
            {


                POId = Convert.ToInt32(comboBoxPO.SelectedValue.ToString());
                retrieve.ShowPOLines(dataGridViewPOLines, PoLineIdGv, ProductIdGv, ProductNameGv, LineNo, ProductPriceGv, ProductQuantityGv, ProductTotalPrice, Convert.ToInt32(comboBoxPO.SelectedValue.ToString()),UnitGv);


                labelGrandTotalValue.Text = (retrieve.GetPoGrossTotal(Convert.ToInt32(comboBoxPO.SelectedValue.ToString()))).ToString();
                comboBoxPO.Text = "";
                textBoxProdCost.Clear();
                textBoxQuantity.Clear();
                textBoxQuantityReceived.Clear();
                textBoxTotalCost.Clear();
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {

            if (dataGridViewPOLines.Rows.Count > 0)
            {
                int quantityReceivedCheck = 0;
                foreach (DataGridViewRow row in dataGridViewPOLines.Rows)
                {
                    if ( row.Cells["QuantityReceivedDgv"].Value==null || row.Cells["QuantityReceivedDgv"].Value==string.Empty  )
                    {
                        break;
                    }
                    quantityReceivedCheck += 1;
                }
                if (quantityReceivedCheck < dataGridViewPOLines.Rows.Count)
                {
                    MainClass.ShowMessage("Please Enter received qunatity for all lines.", "Error", "Error");
                }
                else
                {
                    Updation Update = new Updation();
                    Insertion insert = new Insertion();
                    using (TransactionScope tc = new TransactionScope())
                    {
                        ReceivingId = insert.SaveReceiving(POId, Convert.ToDecimal(labelGrandTotalValue.Text));

                        int recvLines = 0;

                        foreach (DataGridViewRow row in dataGridViewPOLines.Rows)
                        {

                            recvLines += insert.SaveReceiveLine(ReceivingId, Convert.ToInt32(row.Cells["ProductIdGv"].Value), Convert.ToDecimal(row.Cells["ReceivedQuantityCostDgv"].Value), Convert.ToDecimal(row.Cells["QuantityReceivedDgv"].Value), Convert.ToInt32(row.Cells["LineNo"].Value));

                        }
                        if (recvLines > 0)
                        {
                            Update.UpdatePOStatus(POId, 2);
                            MainClass.ShowMessage("Receiving perfromed successfully.", "Success", "Success");
                            CreateReceivingPdfReport(ReceivingId, POId);
                        }
                        else
                        {
                            MainClass.ShowMessage("Unable to perform receiving.", "Error", "Error");
                        }
                        tc.Complete();
                    }
                }

            }
            else
            {
                MainClass.ShowMessage("Please Select a Purchase Order to perform receiving.", "Error", "Error");
            }

        }
        private void CreateReceivingPdfReport(int ReciveId, int PoId)
        {
            try
            {
                //string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //Path += "\\Receiving_PDF";

                //if (!System.IO.Directory.Exists(Path))
                //{
                //    System.IO.Directory.CreateDirectory(Path);
                //}

                //string dates = DateTime.Now.ToString();
                //string rd = dates.Replace("/", ":");
                //string rdd = rd.Replace(":", "_");

                //Path += "\\Receiving_Number_" + ReciveId.ToString() + "_" + rdd + ".pdf";
                //string supplier = "Supplier : ";

                //DataTable dtblSupplier = retrieve.GetPOSupplier(PoId);
                //if (dtblSupplier.Rows.Count > 0)
                //{
                //    supplier += dtblSupplier.Rows[0][0].ToString();
                //}
                //DataTable dtbl = retrieve.GetReceivLinesforPDFExport(ReciveId);
                //string Header = "Receiving #" + ReciveId.ToString();
                //PDFReports pdf = new PDFReports();
                //pdf.ExportDataTableToPdfReceiving(dtbl, Path, Header, supplier, labelGrandTotalValue.Text, PoId);

                //System.Diagnostics.Process.Start(Path);

                ReceivingReport rpt = new ReceivingReport(ReciveId);
                rpt.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void dataGridViewPOLines_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewPOLines.Rows[e.RowIndex];
            comboBoxSelectProduct.SelectedValue = row.Cells["ProductIdGv"].Value.ToString();//
            ProductId = Convert.ToInt32(row.Cells["ProductIdGv"].Value.ToString()); //product id at cell content  to show whether there is any change in combo or not
            ProductIdCellClick = Convert.ToInt32(row.Cells["ProductIdGv"].Value.ToString());
            textBoxQuantity.Text = row.Cells["ProductQuantityGv"].Value.ToString();
            textBoxProdCost.Text = row.Cells["ProductPriceGv"].Value.ToString();
            textBoxTotalCost.Text = row.Cells["ProductTotalPrice"].Value.ToString();
        }

      

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
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
