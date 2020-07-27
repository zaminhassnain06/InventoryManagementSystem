using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace InventoryManagementSystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        public static String cs = ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString;
        private void MDI_Load(object sender, EventArgs e)
        {
            string Path=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(File.Exists(Path+"\\InventoryManagementSystem\\connect") )
            {
                Login log = new Login();
                MainClass.ShowWindow(log, this);
            }
            else
            {
                settings set=new settings();
                MainClass.ShowWindow(set,this);
            }
            

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            MainClass.ShowWindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.ShowWindow(log, this);
          //  logoutToolStripMenuItem.Enabled = false;
        }

       

        private void createPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            MainClass.ShowWindow(PO, this);
           // createPOToolStripMenuItem.Enabled = false;
        }

        private void viewPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POReceiving POD = new POReceiving();
            MainClass.ShowWindow(POD, this);
        //    viewPOToolStripMenuItem.Enabled = false;
        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sa = new Sales();
            MainClass.ShowWindow(sa, this);
           // salesInvoiceToolStripMenuItem.Enabled = false;
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            MainClass.ShowWindow(st, this);
          //  stocksToolStripMenuItem.Enabled = false;
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            MainClass.ShowWindow(prod, this);
           // productsToolStripMenuItem.Enabled = false;
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            MainClass.ShowWindow(cat, this);
          //  categoriesToolStripMenuItem.Enabled = false;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier Supply = new Supplier();
            MainClass.ShowWindow(Supply, this);
           // supplierToolStripMenuItem.Enabled = false;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            MainClass.ShowWindow(cust, this);
          //  customerToolStripMenuItem.Enabled = false;

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            MainClass.ShowWindow(usr, this);
         //   userToolStripMenuItem.Enabled = false;
        }

      

        
    }
}
