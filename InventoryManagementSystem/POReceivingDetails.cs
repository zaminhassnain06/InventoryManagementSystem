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
    public partial class POReceivingDetails : Sample2
    {
        Retrievel retrieve = new Retrievel();
        
        Deletion delete = new Deletion();
        int POId = 0;
        int ReceivingId = 0;
        public POReceivingDetails()
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
        private void POReceiving_Load(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetPOListfoReceivedPO", comboBoxPO, "SupplierName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
          //  retrieve.GetLists("usp_GetProductListforNonSale", comboBoxSelectProduct, "ProductName", "ID");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            retrieve.GetListWith2Param("usp_GetPOList", comboBoxPO, "SupplierName", "ID", "@month", "@year", dateTimePickerPO.Value.Month, dateTimePickerPO.Value.Year);
        }

        protected override void buttonBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

      
     
        public override void buttonEdit_Click(object sender, EventArgs e)
        {
            MainClass.Enable(panelRightSlider);
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

        private void comboBoxPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPO.SelectedIndex != -1 && comboBoxPO.SelectedIndex != 0)
            {


                POId = Convert.ToInt32(comboBoxPO.SelectedValue.ToString());
                retrieve.ShowRecivLines(dataGridViewPOLines, PoLineIdGv, ProductIdGv, ProductNameGv, LineNo, ProductPriceGv, ProductQuantityGv, ProductTotalPrice, Convert.ToInt32(comboBoxPO.SelectedValue.ToString()), UnitGv, QuantityReceivedDgv, ReceivedQuantityCostDgv);
                ReceivingId = retrieve.RetrunRecivId(POId);

                labelGrandTotalValue.Text = (retrieve.GetPoGrossTotal(Convert.ToInt32(comboBoxPO.SelectedValue.ToString()))).ToString();
                comboBoxPO.Text = "";
              ////  textBoxProdCost.Clear();
               // textBoxQuantity.Clear();
              //  textBoxQuantityReceived.Clear();
            //textBoxTotalCost.Clear();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (comboBoxPO.SelectedIndex > 0)
            {
                ///   CreateReceivingPdfReport(ReceivingId, POId);
                ReceivingReport rpt = new ReceivingReport(ReceivingId);
                rpt.Show();
            }
            else
            {
                MainClass.ShowMessage("Please Select a Purchase Order first.", "Error", "Error");
            }
        }

    
    

      
    }
}
