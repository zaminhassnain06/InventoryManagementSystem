﻿using System;
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
    public partial class StockOut : Sample2
    {
 
        Retrievel retrieve = new Retrievel();
      
        public StockOut()
        {
            InitializeComponent();
            buttonEdit.Visible = false;
            buttonSave.Visible = false;
            buttonDelete.Visible = false;
            groupBoxSearch.Visible = false;
            ShowDataOnGrid();
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
        public void ShowDataOnGrid()
        {
            retrieve.ShowStock(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks, ReworkedStock, RejectedStock, OnholdStock);
            foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
            {
                if (Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value) < Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
                {
                    rows.Cells["ProductNameGv"].Style.BackColor = Color.LightGreen;
                    rows.Cells["ProductNameGv"].Style.ForeColor = Color.Black;

                    rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
                    rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                }
                else
                {
                    rows.Cells["ProductNameGv"].Style.BackColor = Color.IndianRed;
                    rows.Cells["ProductNameGv"].Style.ForeColor = Color.Black;

                    rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
                    rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                }
            }
        }
        private void StockOut_Load(object sender, EventArgs e)
        {
            retrieve.GetLists("usp_GetProductList", comboBoxSelectProduct, "ProductName", "ID");
        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panelRightSlider);
            
            //    retrieve.GetLists("usp_GetCategoriesList", comboBoxCategory, "Category", "ID");
        }

        public override void buttonView_Click(object sender, EventArgs e)
        {
            retrieve.ShowStock(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks,ReworkedStock,RejectedStock,OnholdStock);

            foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
            {
                if (Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value) < Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
                {

                    rows.Cells["ProductNameGv"].Style.BackColor = Color.LightGreen;
                    rows.Cells["ProductNameGv"].Style.ForeColor = Color.Black;

                    rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
                    rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                }
                else
                {
                    rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
                    rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;

                    rows.Cells["ProductNameGv"].Style.BackColor = Color.IndianRed;
                    rows.Cells["ProductNameGv"].Style.ForeColor = Color.Black;
                }
            }
        }

        private void buttonStocksOut_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(dateTimePickerEntryDate.Text))
            {

                labelEntryDateError.Visible = true;

            }
            else
            {
                labelEntryDateError.Visible = false;
            }
            if (labelProductDateError.Visible || labelQuantityError.Visible || labelEntryDateError.Visible)
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.

            }
            else
            {

                Updation update = new Updation();

                int row = update.UpdateDecreaseAvailableStocks(Convert.ToInt32(comboBoxSelectProduct.SelectedValue.ToString()), Convert.ToDecimal(textBoxQuantity.Text),dateTimePickerEntryDate.Value);
                retrieve.ShowStock(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks,ReworkedStock,RejectedStock,OnholdStock);
                foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
                {
                    if (Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value) < Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
                    {

                        rows.Cells["ProductNameGv"].Style.BackColor = Color.LightGreen;
                        rows.Cells["ProductNameGv"].Style.ForeColor = Color.Black;

                        rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
                        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
                        rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;


                        rows.Cells["ProductNameGv"].Style.BackColor = Color.IndianRed;
                        rows.Cells["ProductNameGv"].Style.ForeColor = Color.Black;
                    }
                }

                if(row>0)
                {
                    MainClass.ShowMessage("Stocks decreased sucessfully", "Success", "Success");
                    textBoxQuantity.Clear(); 
                }
                else
                {
                    MainClass.ShowMessage("Please add stock of the product first through stock in or receiving.", "Error", "Error");
                }



               
            }
        }
        protected override void buttonBack_Click(object sender, EventArgs e)
        {
            stocks obj = new stocks();
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

            if (e.KeyChar == 13 && buttonStocksOut.Visible == true)
            {
                buttonStocksOut.PerformClick();
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
