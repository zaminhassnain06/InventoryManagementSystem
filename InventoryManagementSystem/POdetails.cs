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
    public partial class POdetails : Sample2
    {
        Retrievel retrieve = new Retrievel();
        int ProductId = 0;
        int ProductIdCellClick = 0;
        int POId = 0;
        public POdetails()
        {
            InitializeComponent();
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            groupBoxSearch.Visible = false;
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
        Deletion delete = new Deletion();
        private void POdetails_Load(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetPOList", comboBoxPO, "SupplierName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
            retrieve.GetLists("usp_GetProductListforNonSale", comboBoxSelectProduct, "ProductName", "ID");
            
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetPOList", comboBoxPO, "SupplierName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
        }

        protected override void buttonBack_Click(object sender, EventArgs e)
        {
            PurchaseOrder obj = new PurchaseOrder();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void comboBoxPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPO.SelectedIndex != -1 && comboBoxPO.SelectedIndex != 0)
            {

              
                POId = Convert.ToInt32(comboBoxPO.SelectedValue.ToString());
                retrieve.ShowPOLines(dataGridViewPOLines, PoLineIdGv, ProductIdGv, ProductNameGv, LineNo, ProductPriceGv, ProductQuantityGv, ProductTotalPrice, Convert.ToInt32(comboBoxPO.SelectedValue.ToString()),UnitGv);

                labelGrandTotalValue.Text = (retrieve.GetPoGrossTotal(Convert.ToInt32(comboBoxPO.SelectedValue.ToString()))).ToString();
            }
        }

        private void dataGridViewPOLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewPOLines.Rows[e.RowIndex];
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 8) //0 is index of button columns
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete PO Line.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 
                    if (dr == DialogResult.Yes)
                    {
                       
                        string GrandTotal = labelGrandTotalValue.Text;

                        decimal TotalGrand = (Convert.ToDecimal(GrandTotal) - Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value.ToString()));
                        labelGrandTotalValue.Text = TotalGrand.ToString();
                        delete.Deletewith4Params("usp_delete_POLine", "@PONumber", "@ProductId", "@LineNumber", "@PoCost", Convert.ToInt32(comboBoxPO.SelectedValue.ToString()), Convert.ToInt32(row.Cells["ProductIdGv"].Value), Convert.ToInt32(row.Cells["LineNo"].Value), Convert.ToInt32(row.Cells["ProductPriceGv"].Value));
                        dataGridViewPOLines.Rows.Remove(row);
                        if (dataGridViewPOLines.Rows.Count > 0)
                        {
                            int i = 1;
                            foreach (DataGridViewRow rows in dataGridViewPOLines.Rows)
                            {

                                rows.Cells[1].Value = i;
                                i++;
                            }
                        }
                        retrieve.ShowPOLines(dataGridViewPOLines, PoLineIdGv, ProductIdGv, ProductNameGv, LineNo, ProductPriceGv, ProductQuantityGv, ProductTotalPrice, Convert.ToInt32(comboBoxPO.SelectedValue.ToString()),UnitGv);
                    }
                }

                else if (e.ColumnIndex > 0)
                {

                    comboBoxSelectProduct.SelectedValue = row.Cells["ProductIdGv"].Value.ToString();//
                    ProductId =Convert.ToInt32( row.Cells["ProductIdGv"].Value.ToString()); //product id at cell content  to show whether there is any change in combo or not
                    ProductIdCellClick = Convert.ToInt32(row.Cells["ProductIdGv"].Value.ToString()); 
                    textBoxQuantity.Text = row.Cells["ProductQuantityGv"].Value.ToString();
                    textBoxProdCost.Text = row.Cells["ProductPriceGv"].Value.ToString();
                    textBoxTotalCost.Text = row.Cells["ProductTotalPrice"].Value.ToString();
                    textBoxUnit.Text = row.Cells["UnitGv"].Value.ToString();

                }
                
            
            }
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
            if (textBoxQuantity.Text == "")
            {
                labelQuantityError.Visible = true;
            }
            else
            {

                labelQuantityError.Visible = false;

            }
            if (labelProductDateError.Visible || labelQuantityError.Visible)
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

                            row.Cells["ProductQuantityGv"].Value = textBoxQuantity.Text;

                            if (Convert.ToDecimal(textBoxTotalCost.Text) > Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value))
                            {
                                decimal increase = Convert.ToDecimal(textBoxTotalCost.Text) - Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value);

                                string GrandTotal = labelGrandTotalValue.Text;

                                decimal TotalGrand = Convert.ToDecimal(GrandTotal) + increase;
                                labelGrandTotalValue.Text = TotalGrand.ToString();
                                row.Cells["ProductTotalPrice"].Value = textBoxTotalCost.Text;
                                break;
                            }
                            else if (Convert.ToDecimal(textBoxTotalCost.Text) < Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value))
                            {
                                decimal decrease = Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value) - Convert.ToDecimal(textBoxTotalCost.Text);

                                string GrandTotal = labelGrandTotalValue.Text;

                                decimal TotalGrand = Convert.ToDecimal(GrandTotal) - decrease;
                                labelGrandTotalValue.Text = TotalGrand.ToString();
                                row.Cells["ProductTotalPrice"].Value = textBoxTotalCost.Text;
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
                    drToAdd["Unit"] = textBoxUnit.Text;
                    



                    dataTable.Rows.Add(drToAdd);
                    dataTable.AcceptChanges();

                   labelGrandTotalValue.Text = (Convert.ToDecimal(labelGrandTotalValue.Text) + Convert.ToDecimal(textBoxTotalCost.Text)).ToString();

                }
            }
        }

        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = retrieve.GetId("usp_GetProductID", comboBoxSelectProduct.Text);
            textBoxQuantity.Clear();
            textBoxTotalCost.Clear();
            textBoxProdCost.Clear();

            
           if (dt.Rows.Count > 0)
            {
                ProductId = Convert.ToInt32(dt.Rows[0][0].ToString());

                DataTable dtPrice = new DataTable();
                dtPrice = retrieve.GetProductPrice(ProductId);
                if (dtPrice.Rows.Count > 0)
                {
                    textBoxProdCost.Text = dtPrice.Rows[0][0].ToString();
                }
                foreach (DataGridViewRow row in dataGridViewPOLines.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductIdGv"].Value)==ProductId)
                    { 
                        textBoxQuantity.Text=(row.Cells["ProductQuantityGv"].Value).ToString();
                        textBoxTotalCost.Text =(row.Cells["ProductTotalPrice"].Value).ToString();

                        break;
                    }
                }
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text != "" && textBoxProdCost.Text != "")
            {
                decimal totalcost = Convert.ToDecimal(textBoxQuantity.Text) * Convert.ToDecimal(textBoxProdCost.Text);
                textBoxTotalCost.Text = totalcost.ToString();
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {

            if (dataGridViewPOLines.Rows.Count > 0)
            {
               
                Updation Update = new Updation();
                
                using (TransactionScope tc = new TransactionScope())
                {
                   
                    int PoLines = 0;
                    foreach (DataGridViewRow row in dataGridViewPOLines.Rows)
                    {

                        Update.UpdatePODetails(POId, Convert.ToInt32(row.Cells["ProductIdGv"].Value), Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value), Convert.ToDecimal(row.Cells["ProductQuantityGv"].Value), Convert.ToInt32(row.Cells["LineNo"].Value));
                        PoLines += 1;
                    }
                    if (PoLines > 0)
                    {
                        Update.UpdatePOPrice(POId, Convert.ToDecimal(labelGrandTotalValue.Text));
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPO.SelectedIndex > 0)
                {
                //    string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //    Path += "\\PO_PDF";

                //    if (!System.IO.Directory.Exists(Path))
                //    {
                //        System.IO.Directory.CreateDirectory(Path);
                //    }

                //    string dates = DateTime.Now.ToString();
                //    string rd = dates.Replace("/", ":");
                //    string rdd = rd.Replace(":", "_");

                //    Path += "\\PO_Number_" + POId.ToString() + "_" + rdd + ".pdf";
                //    string supplier = "Supplier : ";
                //    string Address="";
                //    string City="";
                //    string Country="";
                //    string ContactNumber="";
                //    string POCreationDate="";
                //    string ExpectedDelDate="";
                

                //    DataTable dtblSupplier = retrieve.GetPOSupplier(POId);
                //    if (dtblSupplier.Rows.Count > 0)
                //    {
                //        supplier += dtblSupplier.Rows[0][0].ToString();
                //        Address = dtblSupplier.Rows[0][1].ToString();
                //        City = dtblSupplier.Rows[0][2].ToString();
                //        Country = dtblSupplier.Rows[0][3].ToString();
                //        ContactNumber = dtblSupplier.Rows[0][4].ToString();
                //        POCreationDate = dtblSupplier.Rows[0][5].ToString();
                //        ExpectedDelDate = dtblSupplier.Rows[0][6].ToString();
                        
                //    }
                //    DataTable dtbl = retrieve.GetPOLinesforPDFExport(POId);
                //    string Header = "Purchase Order #" + POId.ToString();
                //    PDFReports pdf = new PDFReports();
                //    pdf.ExportDataTableToPdfPORec(dtbl, Path, Header, supplier, labelGrandTotalValue.Text, Address, City, Country, ContactNumber, POCreationDate, ExpectedDelDate);

                //    System.Diagnostics.Process.Start(Path);
                 POReport rpt = new POReport(POId);
                rpt.Show();
                }
                else
                {
                    MainClass.ShowMessage("Please select a Purchase Order first.", "Error", "Error");
                }
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
