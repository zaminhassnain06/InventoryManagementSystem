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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        protected virtual void buttonBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);
        }

        public virtual void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        public virtual void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        public virtual void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void buttonSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void buttonView_Click(object sender, EventArgs e)
        {

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

       

        private void createPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            MainClass.ShowWindow(PO, this, MDI.ActiveForm);
        }

        private void pOReceivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POReceiving POD = new POReceiving();
            MainClass.ShowWindow(POD, this, MDI.ActiveForm);
        }

        private void createSalesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sa = new Sales();
            MainClass.ShowWindow(sa, this, MDI.ActiveForm);
        }

        private void stocksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            MainClass.ShowWindow(prod, this, MDI.ActiveForm);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Categories cat = new Categories();
            MainClass.ShowWindow(cat, this, MDI.ActiveForm);
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier Supply = new Supplier();
            MainClass.ShowWindow(Supply, this, MDI.ActiveForm);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            MainClass.ShowWindow(cust, this, MDI.ActiveForm);
        }

        private void reviewCreatedPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POdetails POD = new POdetails();
            MainClass.ShowWindow(POD, this, MDI.ActiveForm);
        }

        private void reviewReceivedPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POReceivingDetails RecDet = new POReceivingDetails();
            MainClass.ShowWindow(RecDet, this, MDI.ActiveForm);
        }

        private void reviewCreatedSalesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesDetails saleDet = new SalesDetails();
            MainClass.ShowWindow(saleDet, this, MDI.ActiveForm);
        }

        private void stocksInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIn stkin = new StockIn();
            MainClass.ShowWindow(stkin, this, MDI.ActiveForm);
        }

        private void stocksOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOut StkOut = new StockOut();
            MainClass.ShowWindow(StkOut, this, MDI.ActiveForm);
        }

        private void stocksOnHoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOnHold stockOnHold = new StockOnHold();
            MainClass.ShowWindow(stockOnHold, this, MDI.ActiveForm);
        }

        private void stocksReworkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReworked stockReworked = new StockReworked();
            MainClass.ShowWindow(stockReworked, this, MDI.ActiveForm);
        }

        private void stocksRejectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOnHold stockOnHold = new StockOnHold();
            MainClass.ShowWindow(stockOnHold, this, MDI.ActiveForm);
        }

          
        
    }

      
    
}

