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
    public partial class HomeScreen : Sample
    {
        int co = 0;
        int StockNotification = 0;
      
        Retrievel retrieve = new Retrievel();
      
        DataTable dt = new DataTable();
        public HomeScreen()
        {
            InitializeComponent();
            
            if(Retrievel.User_Type_Id==2)
            {
                buttonUser.Visible = false;
            }

            if (Retrievel.User_Type_Id == 3)
            {
                buttonUser.Visible = false;
                Product.Visible = false;
                buttonCat.Visible = false;
                buttonSupplier.Visible = false;
                buttonCustomer.Visible = false;
            }

            Load() ;
        }
        private void Load()
        {
            Updation update = new Updation();
            update.UpdateStockDailyStatus();
          
          
            timer2.Start();
            StockNotification =retrieve.StocksStatusNotification();
            if(StockNotification==1)
            {
                labelNotifcationStatus.Text = "Stocks are at Minimum level.";
                comboBoxProducts.Visible = true;
                
                linkLabelMin.Visible = true;

                retrieve.GetListsComboStocks("Usp_ProductsWithMinValuesofStocks", comboBoxProducts, "ProductName", "ID");
            }
           // labelUser.Text = Retrievel.User_Name;
            
          
        }
       
        private void buttonUser_Click(object sender, EventArgs e)
        {
            Users User = new Users();
            MainClass.ShowWindow(User, this,MDI.ActiveForm);
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            MainClass.ShowWindow(cat, this, MDI.ActiveForm);
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            MainClass.ShowWindow(products, this, MDI.ActiveForm);
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            Supplier supp = new Supplier();
            MainClass.ShowWindow(supp, this, MDI.ActiveForm);
        }

        private void buttonPurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            MainClass.ShowWindow(PO, this, MDI.ActiveForm);
        }

        private void buttonPOReceiving_Click(object sender, EventArgs e)
        {
            POReceiving por = new POReceiving();
            MainClass.ShowWindow(por, this, MDI.ActiveForm);
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            MainClass.ShowWindow(sale, this, MDI.ActiveForm);
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            MainClass.ShowWindow(cust, this, MDI.ActiveForm);
        }

        
       

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(co==0)
            {
                labelNotifcationStatus.ForeColor = Color.Gold;
                co = 1;
            }
            else
            {
                labelNotifcationStatus.ForeColor = Color.Gray;
                co = 0;
            }
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.ShowWindow(log, this, MDI.ActiveForm);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            stocks st = new stocks();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void buttonRework_Click(object sender, EventArgs e)
        {
            StockReworked stockReworked = new StockReworked();
            MainClass.ShowWindow(stockReworked, this, MDI.ActiveForm);
        }

        private void buttonOnhold_Click(object sender, EventArgs e)
        {
            StockOnHold stockOnHold = new StockOnHold();
            MainClass.ShowWindow(stockOnHold, this, MDI.ActiveForm);
        }

        private void buttonRejected_Click(object sender, EventArgs e)
        {
            StockRejected stockRejected = new StockRejected();
            MainClass.ShowWindow(stockRejected, this, MDI.ActiveForm);
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxProducts.SelectedIndex > -1)
            //{
            //    DataTable dt = new DataTable();
            //    dt = retrieve.GetId("usp_GetProductID", comboBoxProducts.Text);
            //    if (dt.Rows.Count > 0)
            //    {
            //        int productId = Convert.ToInt32(dt.Rows[0][0]);
            //        stocks st = new stocks(productId);
            //        MainClass.ShowWindow(st, this, MDI.ActiveForm);
            //    }
            //}
        }
    }
}
