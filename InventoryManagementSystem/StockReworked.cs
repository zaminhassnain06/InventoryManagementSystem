using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class StockReworked : Sample2
    {
        
        Retrievel retrieve = new Retrievel();
     
        public StockReworked()
        {
            InitializeComponent();
            buttonEdit.Visible = false;
            buttonSave.Visible = false;
            buttonDelete.Visible = false;
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
        private void ShowDataInGrid()
        {
            retrieve.ShowReworkedStock(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks, ReworkedStock, RejectedStock, OnholdStock);
        }
        private void StockIn_Load(object sender, EventArgs e)
        {
            retrieve.GetLists("usp_GetProductList", comboBoxSelectProduct, "ProductName", "ID");
        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panelRightSlider);
          
        }

        public override void buttonView_Click(object sender, EventArgs e)
        {
            retrieve.ShowReworkedStock(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks,ReworkedStock,RejectedStock,OnholdStock);

            //foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
            //{
            //    if (Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value) < Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
            //    {
            //        rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
            //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
            //    }
            //    else
            //    {
            //        rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
            //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
            //    }
            //}
        }

        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                retrieve.ShowReworkedStock(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks, ReworkedStock,RejectedStock,OnholdStock,textBoxSearch.Text);
                //foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
                //{
                //    if (Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value) < Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
                //    {
                //        rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
                //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                //    }
                //    else
                //    {
                //        rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
                //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                //    }
                //}
            }
            else
            {
                retrieve.ShowReworkedStock(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks,ReworkedStock,RejectedStock,OnholdStock);
                //foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
                //{
                //    if (Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value) < Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
                //    {
                //        rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
                //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                //    }
                //    else
                //    {
                //        rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
                //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                //    }
                //}
            }
        }

        private void buttonAddToStocks_Click(object sender, EventArgs e)
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
                
                Updation update = new Updation();

                update.UpdateIncreaseInReworkedStocks(Convert.ToInt32(comboBoxSelectProduct.SelectedValue.ToString()), Convert.ToDecimal(textBoxQuantity.Text), dateTimePickerEntryDate.Value);
                ShowDataInGrid();
                //foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
                //{
                //    if(Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value)< Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
                //    {
                //        rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
                //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                //    }
                //    else
                //    {
                //        rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
                //        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                //    }
                //}

                MainClass.ShowMessage("Reworked Stocks added sucessfully", "Success", "Success");
                textBoxQuantity.Clear();
            }
        }
        protected override void buttonBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxQuantity.Clear();
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

            if (e.KeyChar == 13 && buttonAddToStocks.Visible == true)
            {
                buttonAddToStocks.PerformClick();
            }
        }

        private void buttonResolveReworkedStock_Click(object sender, EventArgs e)
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

                Updation update = new Updation();

                int rows = update.UpdateResolveInReworkedStocks(Convert.ToInt32(comboBoxSelectProduct.SelectedValue.ToString()), Convert.ToDecimal(textBoxQuantity.Text), dateTimePickerEntryDate.Value);
                if(rows>0)
                {
                    ShowDataInGrid();
                     MainClass.ShowMessage("Reworked Stocks added sucessfully", "Success", "Success");
                     textBoxQuantity.Clear();
                }
                else
                {
                    MainClass.ShowMessage("Please Add Reworked Stocks First.", "Error", "Error");

                }
               
               
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
