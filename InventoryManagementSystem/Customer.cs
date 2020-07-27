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
    public partial class Customer : Sample2
    {
        int edit = 0; //0 is an indication for save operation and 1 is an indifaction for update operation
        Retrievel retrieve = new Retrievel();
        int CustomerId = 0;

        public Customer()
        {
            InitializeComponent();
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
            retrieve.ShowCustomer(dataGridViewCustomer, CustomerIdGv, CustomerNameGv, CustomerCodeGv, CustomerContactNumberGv, CustomerEmailGv, CustomerAddresseGv, CustomerCityGv, CustomerCountryGv, CustomerPaymentMethodGv, CustomerDeliveryMethodGv, CustomerDeliveryLeadTimeIdGv);
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            MainClass.Disable_Reset(panelRightSlider);
        }

        public override void buttonAdd_Click(object sender, EventArgs e)
        {
            MainClass.Enable_Reset(panelRightSlider);
            edit = 0;
         
        }

        public override void buttonEdit_Click(object sender, EventArgs e)
        {
            edit = 1;

            MainClass.Enable(panelRightSlider);
       
        }

        public override void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void buttonDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion del = new Deletion();
                    del.DeleteDetails(CustomerId, "Usp_RemoveCustomerDetails", "@CustomerId");
                    retrieve.ShowCustomer(dataGridViewCustomer, CustomerIdGv, CustomerNameGv, CustomerCodeGv, CustomerContactNumberGv, CustomerEmailGv, CustomerAddresseGv, CustomerCityGv, CustomerCountryGv, CustomerPaymentMethodGv, CustomerDeliveryMethodGv, CustomerDeliveryLeadTimeIdGv);
                    MainClass.Disable_Reset(panelRightSlider);
                }
            }
        }

        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
              retrieve.ShowCustomer(dataGridViewCustomer, CustomerIdGv, CustomerNameGv, CustomerCodeGv, CustomerContactNumberGv, CustomerEmailGv, CustomerAddresseGv, CustomerCityGv, CustomerCountryGv, CustomerPaymentMethodGv, CustomerDeliveryMethodGv, CustomerDeliveryLeadTimeIdGv, textBoxSearch.Text);

            }
            else
            {
               retrieve.ShowCustomer(dataGridViewCustomer, CustomerIdGv, CustomerNameGv, CustomerCodeGv, CustomerContactNumberGv, CustomerEmailGv, CustomerAddresseGv, CustomerCityGv, CustomerCountryGv, CustomerPaymentMethodGv, CustomerDeliveryMethodGv, CustomerDeliveryLeadTimeIdGv);
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxCustomerName.Text == "")
            {
                labelCustomerNameError.Visible = true;
            }
            else
            {
                labelCustomerNameError.Visible = false;
            }

            if (textBoxCustomerCode.Text == "")
            {
                labelCustomerCodeError.Visible = true;
            }
            else
            {
                labelCustomerCodeError.Visible = false;
            }
            if (textBoxCustomerContactNumber.Text == "")
            {
                labelCustomerContactError.Visible = true;
            }
            else
            {
                labelCustomerContactError.Visible = false;
            }
            if (textBoxCustomerEmail.Text == "")
            {
                labelCustomerEmailError.Visible = true;
            }
            else
            {
                labelCustomerEmailError.Visible = false;
            }
            if (textBoxAddress.Text == "")
            {
                labelAddressError.Visible = true;
            }
            else
            {
                labelAddressError.Visible = false;
            }
            if (textBoxCustomerCity.Text == "")
            {
                labelCustomerCityError.Visible = true;
            }
            else
            {
                labelCustomerCityError.Visible = false;
            }

            if (textBoxCountry.Text == "")
            {
                labelCountryError.Visible = true;
            }
            else
            {
                labelCountryError.Visible = false;
            }
            if (textBoxPayment.Text == "")
            {
                labelPaymentError.Visible = true;
            }
            else
            {
                labelPaymentError.Visible = false;
            }

            if (textBoxDeliveryMethod.Text == "")
            {
                labelDelMethodError.Visible = true;
            }
            else
            {
                labelDelMethodError.Visible = false;
            }
            if (textBoxDelLeadTime.Text == "")
            {
                labelDelLeadTimeError.Visible = true;
            }
            else
            {
                labelDelLeadTimeError.Visible = false;
            }

            if (labelCustomerNameError.Visible || labelCustomerCodeError.Visible || labelCustomerContactError.Visible || labelCustomerEmailError.Visible || labelAddressError.Visible || labelCustomerCityError.Visible || labelCountryError.Visible || labelDelMethodError.Visible || labelPaymentError.Visible || labelDelLeadTimeError.Visible)
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.
            }
            else
            {

                if (edit == 0)  //Code for save operation
                {
                    Insertion insert = new Insertion();
                    insert.SaveCustomerDetails(textBoxCustomerName.Text, textBoxCustomerCode.Text, textBoxCustomerContactNumber.Text, textBoxCustomerEmail.Text, textBoxAddress.Text, textBoxCustomerCity.Text, textBoxCountry.Text, textBoxPayment.Text, textBoxDeliveryMethod.Text, textBoxDelLeadTime.Text,Convert.ToDecimal(textBoxDelLeadTime.Text));


                    retrieve.ShowCustomer(dataGridViewCustomer, CustomerIdGv, CustomerNameGv, CustomerCodeGv, CustomerContactNumberGv, CustomerEmailGv, CustomerAddresseGv, CustomerCityGv, CustomerCountryGv, CustomerPaymentMethodGv, CustomerDeliveryMethodGv, CustomerDeliveryLeadTimeIdGv);
                    MainClass.Disable_Reset(panelRightSlider);

                }
                else if (edit == 1) //code for update operaiton
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation update = new Updation();
                        update.UpdateCustomerDetails(textBoxCustomerName.Text, textBoxCustomerCode.Text, textBoxCustomerContactNumber.Text, textBoxCustomerEmail.Text, textBoxAddress.Text, textBoxCustomerCity.Text, textBoxCountry.Text, textBoxPayment.Text, textBoxDeliveryMethod.Text, textBoxDelLeadTime.Text, Convert.ToDecimal(textBoxDelLeadTime.Text),CustomerId);

                         retrieve.ShowCustomer(dataGridViewCustomer, CustomerIdGv, CustomerNameGv, CustomerCodeGv, CustomerContactNumberGv, CustomerEmailGv, CustomerAddresseGv, CustomerCityGv, CustomerCountryGv, CustomerPaymentMethodGv, CustomerDeliveryMethodGv, CustomerDeliveryLeadTimeIdGv);
                         MainClass.Disable_Reset(panelRightSlider);
                    }

                }
            }

        }

        public override void buttonView_Click(object sender, EventArgs e)
        {

            retrieve.ShowCustomer(dataGridViewCustomer, CustomerIdGv, CustomerNameGv, CustomerCodeGv, CustomerContactNumberGv, CustomerEmailGv, CustomerAddresseGv, CustomerCityGv, CustomerCountryGv, CustomerPaymentMethodGv, CustomerDeliveryMethodGv, CustomerDeliveryLeadTimeIdGv);

        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewCustomer.Rows[e.RowIndex];
                CustomerId = Convert.ToInt32(row.Cells[0].Value.ToString());
                textBoxCustomerName.Text = row.Cells[1].Value.ToString();
                textBoxCustomerCode.Text = row.Cells[2].Value.ToString();
                textBoxCustomerContactNumber.Text = row.Cells[3].Value.ToString();
                textBoxCustomerEmail.Text = row.Cells[4].Value.ToString();
                textBoxAddress.Text = row.Cells[5].Value.ToString();
                textBoxCustomerCity.Text = row.Cells[6].Value.ToString();
                textBoxCountry.Text = row.Cells[7].Value.ToString();
                textBoxPayment.Text = row.Cells[8].Value.ToString();
                textBoxDeliveryMethod.Text = row.Cells[9].Value.ToString();
                textBoxDelLeadTime.Text = row.Cells[10].Value.ToString();
                MainClass.Disable(panelRightSlider);
            }
        }

        private void textBoxDelLeadTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && textBoxDelLeadTime.Text.IndexOf('.') != -1)//check if user has entered more than one dot .
            {
                e.Handled = true;
                return;
            }
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != 46))  //46 is ASCCI Code for dot "." 
            {

                e.Handled = true;
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
