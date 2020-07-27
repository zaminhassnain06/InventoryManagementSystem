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
    public partial class PurchaseOrder : Sample2
    {

        Retrievel retrieve = new Retrievel();
        int ProductId = 0;

 
        public PurchaseOrder()
        {
            InitializeComponent();
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            groupBoxSearch.Visible = false;
            buttonView.Text = "Review Created PO";
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
        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panelRightSlider);
            comboBoxSelectProduct.Enabled = false;
            textBoxQuantity.Enabled = false;
            textBoxTotalCost.Enabled = false;
            textBoxProdCost.Enabled = false;
            textBoxPONumber.Enabled = false;
            textBoxUnit.Enabled = false;
            DataTable dt = new DataTable();
      //      dt = retrieve.GetId("usp_GetPOID", comboBoxSelectProduct.Text);
            //PoNumber = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
            //textBoxPONumber.Text = PoNumber.ToString();
            textBoxPONumber.Text =retrieve.RetrunPoNumber().ToString();

          
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            retrieve.GetLists("usp_GetSupplierList", comboBoxSupplier, "SupplierName", "ID");
            retrieve.GetLists("usp_GetProductListforNonSale", comboBoxSelectProduct, "ProductName", "ID");
            textBoxPONumber.Text =retrieve.RetrunPoNumber().ToString();
            
        }

        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=retrieve.GetId("usp_GetProductID", comboBoxSelectProduct.Text);
            textBoxQuantity.Clear();
            textBoxTotalCost.Clear();
            textBoxProdCost.Clear();
            if(dt.Rows.Count>0)
            {
                ProductId = Convert.ToInt32(dt.Rows[0][0].ToString());
                DataTable dtPrice = new DataTable();
                dtPrice = retrieve.GetProductPrice(ProductId);
                if(dtPrice.Rows.Count>0)
                {
                    textBoxProdCost.Text = dtPrice.Rows[0][0].ToString();
                    textBoxUnit.Text = dtPrice.Rows[0][1].ToString();
                }
            }
            
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if(textBoxQuantity.Text!="" && textBoxProdCost.Text!="")
            {
                decimal totalcost = Convert.ToDecimal(textBoxQuantity.Text) * Convert.ToDecimal(textBoxProdCost.Text);
                textBoxTotalCost.Text = totalcost.ToString();
            }
        }

        private void checkBoxAddProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxSupplier.SelectedIndex < 0)
            {
                labelSupplierError.Visible = true;
                checkBoxAddProduct.Checked = false;
            }
            else { 
            if(checkBoxAddProduct.Checked)
            {
                
                comboBoxSelectProduct.Enabled = true;
                textBoxQuantity.Enabled = true;
                textBoxTotalCost.Enabled = false;
                textBoxProdCost.Enabled = false;

            }
            else
            {
                comboBoxSelectProduct.Enabled = false;
                textBoxQuantity.Enabled = false;
                textBoxTotalCost.Enabled = false;
                textBoxProdCost.Enabled = false;
            }
            }
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxAddProduct.Checked = false;
           comboBoxSelectProduct.Text="";
            textBoxQuantity.Clear();
            textBoxTotalCost.Clear();
            textBoxProdCost.Clear();
            dataGridViewPOLines.Rows.Clear();
          ///  SupplierId = Convert.ToInt32(comboBoxSupplier.SelectedValue.ToString());
            

        }

        private void labelGrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if(comboBoxSupplier.SelectedIndex==-1 )
            {
                labelSupplierError.Visible = true;
            }
            else
            {
                labelSupplierError.Visible = false;
            }
            if(dateTimePickerExpectedDelDate.Text=="")
            {
                labelExpectedDelDateError.Visible = true;
            }
            else
            {
                labelExpectedDelDateError.Visible = false;
            }
        
            if(comboBoxSelectProduct.SelectedIndex==-1)
            {
                labelProductDateError.Visible = true;
            }
            else
            {
                labelProductDateError.Visible = false;
            }
            if(textBoxQuantity.Text=="")
            {
                labelQuantityError.Visible = true;
            }
            else
            {
                
                    labelQuantityError.Visible = false;
                
            }
            if (labelSupplierError.Visible || labelExpectedDelDateError.Visible || labelProductDateError.Visible ||   labelQuantityError.Visible  )
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.

            }
            else
            {
                bool checkDuplicate = false;
             foreach(DataGridViewRow row in dataGridViewPOLines.Rows)
             {
                 if(row.Cells[0].Value.ToString()==ProductId.ToString())
                 {
                     checkDuplicate = true;
                     MainClass.ShowMessage("Product already entered.", "Error", "Error");
                 }

             }
             if (checkDuplicate == false)
             {
                 dataGridViewPOLines.Rows.Add( ProductId, dataGridViewPOLines.Rows.Count+1, comboBoxSelectProduct.Text, textBoxQuantity.Text,textBoxUnit.Text, textBoxProdCost.Text, textBoxTotalCost.Text);
                 labelGrandTotalValue.Text = (Convert.ToDecimal(labelGrandTotalValue.Text) + Convert.ToDecimal(textBoxTotalCost.Text)).ToString();
               
             }
            }
        }

        

      

        public override void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {

            if(dataGridViewPOLines.Rows.Count>0)
            {
                int PoId=0;
                Insertion insert = new Insertion();
                using(TransactionScope tc=new TransactionScope())
                {
                    PoId = insert.SavePO(Convert.ToInt32(comboBoxSupplier.SelectedValue), dateTimePickerExpectedDelDate.Value, Convert.ToDecimal(labelGrandTotalValue.Text), Retrievel.User_ID);
                    int PoLines = 0;
                    foreach (DataGridViewRow row in dataGridViewPOLines.Rows)
                    {
                        PoLines += insert.SavePoLine(PoId, Convert.ToInt32(row.Cells["ProductIdGv"].Value), Convert.ToDecimal(row.Cells["ProductTotalPrice"].Value), Convert.ToDecimal(row.Cells["ProductQuantityGv"].Value), Convert.ToInt32(row.Cells[1].Value), (row.Cells["Unit"].Value).ToString());

                    }
                    if (PoLines > 0)
                    {
                        MainClass.ShowMessage("Purchase Order Created Successfully.", "Success", "Success");
                        dataGridViewPOLines.Rows.Clear();
                        textBoxPONumber.Text = retrieve.RetrunPoNumber().ToString();
                        comboBoxSupplier.Text = "";
                        comboBoxSelectProduct.Text = "";
                        textBoxUnit.Clear();
                        textBoxQuantity.Clear();
                        textBoxProdCost.Clear();
                        textBoxTotalCost.Clear();
                        CreatePOPdfReport(PoId);
                        labelGrandTotalValue.Text = "0.00";
                        
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to create Purchase Order.", "Error", "Error");
                    }
                    tc.Complete();
                }
               
            }

        }
        private void CreatePOPdfReport(int POId)
        {
            try
            {
                //string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //Path += "\\PO_PDF";

                //if (!System.IO.Directory.Exists(Path))
                //{
                //    System.IO.Directory.CreateDirectory(Path);
                //}

                //string dates = DateTime.Now.ToString();
                //string rd = dates.Replace("/", ":");
                //string rdd = rd.Replace(":", "_");

                //Path += "\\PO_Number_" + POId.ToString() + "_" + rdd + ".pdf";
                //string supplier = "Supplier : ";
                //string Address = "";
                //string City = "";
                //string Country = "";
                //string ContactNumber = "";
                //string POCreationDate = "";
                //string ExpectedDelDate = "";
                //DataTable dtblSupplier = retrieve.GetPOSupplier(POId);
                //if (dtblSupplier.Rows.Count > 0)
                //{
                //    supplier += dtblSupplier.Rows[0][0].ToString();
                //    Address = dtblSupplier.Rows[0][1].ToString();
                //    City = dtblSupplier.Rows[0][2].ToString();
                //    Country = dtblSupplier.Rows[0][3].ToString();
                //    ContactNumber = dtblSupplier.Rows[0][4].ToString();
                //    POCreationDate = dtblSupplier.Rows[0][5].ToString();
                //    ExpectedDelDate = dtblSupplier.Rows[0][6].ToString();
                //}
                //DataTable dtbl = retrieve.GetPOLinesforPDFExport(POId);
                //string Header = "Purchase Order #" + POId.ToString();
                //PDFReports pdf = new PDFReports();
                ////pdf.ExportDataTableToPdfPO(dtbl, Path, Header, supplier, labelGrandTotalValue.Text);
                //pdf.ExportDataTableToPdfPORec(dtbl, Path, Header, supplier, labelGrandTotalValue.Text, Address, City, Country, ContactNumber, POCreationDate, ExpectedDelDate);

                //System.Diagnostics.Process.Start(Path);
                POReport rpt = new POReport(POId);
                rpt.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        public override void buttonView_Click(object sender, EventArgs e)
        {
            POdetails POD=new POdetails();
            MainClass.ShowWindow(POD, this, MDI.ActiveForm);

        }

        private void dataGridViewPOLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1 && e.ColumnIndex!=-1)
            {
                if(e.ColumnIndex==7)
                {
                    DataGridViewRow row = dataGridViewPOLines.Rows[e.RowIndex];
                    string GrandTotal = labelGrandTotalValue.Text.ToString();
                    
                    decimal TotalGrand = (Convert.ToDecimal(GrandTotal) - Convert.ToDecimal(row.Cells[6].Value.ToString())) ;
                    labelGrandTotalValue.Text = TotalGrand.ToString();
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
