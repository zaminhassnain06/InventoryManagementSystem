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
    public partial class Users : Sample2
    {
        int edit = 0; //0 is an indication for save operation and 1 is an indifaction for update operation

        int userId = 0;
        Retrievel retrieve = new Retrievel();
        public Users()
        {
            InitializeComponent();
            User_Load();

            ShowDataInGrid();
            makeMneusmall();
            retrieve.GetListsComboStocks("usp_GetUserRoles", comboBoxSelectRole, "UserType", "ID");  
        }

        void makeMneusmall()
        {
            bunifuGradientPannelSidebar.Visible = false;
            bunifuGradientPannelSidebar.Width = 0;
            panelMenu.Width = 1;
            panelRightSlider.Width = panelLeftMiddleMain.Width - panelMenu.Width;
            bunifuTransitionAnimationSideBack.Show(bunifuGradientPannelSidebar);
        }
        private void User_Load()
        {
            MainClass.Disable_Reset(panelRightSlider);
            
        }

        private void ShowDataInGrid()
        {
            retrieve.ShowUsers(dataGridViewUsers, UserIdGV, UsernameGV, PasswordGV, ContactGv, EmailGV, Role,RoleId);
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
                    del.DeleteDetails(userId, "Usp_RemoveUserDetails", "@UserId");
                    retrieve.ShowUsers(dataGridViewUsers, UserIdGV, UsernameGV, PasswordGV, ContactGv, EmailGV, Role, RoleId);
                    MainClass.Disable_Reset(panelRightSlider);
                }
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                labelNameError.Visible = true;
            } 
            else
            {
                labelNameError.Visible = false; 
            }
            if (textBoxPasword.Text == "")
            {
               labelPasswordError.Visible = true;
            }
            else
            {
                labelPasswordError.Visible = false;
            }
            if (textBoxContact.Text == "")
            {
               labelContactNumberError.Visible = true;
            }
            else
            {
                labelContactNumberError.Visible = false;
            }
            if (textBoxEmail.Text == "")
            {
               labelEmailError.Visible = true;
            }
            else
            {
                labelEmailError.Visible = false;
            }
            if (comboBoxSelectRole.SelectedIndex == -1)
            {
                labelRoleError.Visible = true;
            }
            else
            {
                labelRoleError.Visible = false;
            }
            if (labelNameError.Visible || labelPasswordError.Visible || labelContactNumberError.Visible || labelEmailError.Visible || labelRoleError.Visible)
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.
            }
            else
            {
                if(edit==0)  //Code for save operation
                {
                    Insertion insert = new Insertion();
                    insert.SaveUserDetails(textBoxUserName.Text, textBoxPasword.Text, textBoxContact.Text, textBoxEmail.Text,Convert.ToInt32(comboBoxSelectRole.SelectedValue));

                    retrieve.ShowUsers(dataGridViewUsers, UserIdGV, UsernameGV, PasswordGV, ContactGv, EmailGV, Role, RoleId);
                    MainClass.Disable_Reset(panelRightSlider);

                }
                else if(edit==1) //code for update operaiton
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation update = new Updation();
                        update.UpdateUserDetails(textBoxUserName.Text, textBoxPasword.Text, textBoxContact.Text, textBoxEmail.Text, userId, Convert.ToInt32(comboBoxSelectRole.SelectedValue));

                        retrieve.ShowUsers(dataGridViewUsers, UserIdGV, UsernameGV, PasswordGV, ContactGv, EmailGV, Role, RoleId);
                        MainClass.Disable_Reset(panelRightSlider);
                    }
                    
                }
            }

        }

        public override void buttonView_Click(object sender, EventArgs e)
        {
            retrieve.ShowUsers(dataGridViewUsers, UserIdGV, UsernameGV, PasswordGV, ContactGv, EmailGV, Role, RoleId);

        }
        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSearch.Text!="")
            {
                retrieve.ShowUsers(dataGridViewUsers, UserIdGV, UsernameGV, PasswordGV, ContactGv, EmailGV, Role,RoleId, textBoxSearch.Text);

            }
            else
            {
                retrieve.ShowUsers(dataGridViewUsers, UserIdGV, UsernameGV, PasswordGV, ContactGv, EmailGV,Role,RoleId);
            }
           
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                userId =Convert.ToInt32(row.Cells[0].Value.ToString());
                textBoxUserName.Text = row.Cells[1].Value.ToString();
                textBoxPasword.Text = row.Cells[2].Value.ToString();
                textBoxContact.Text = row.Cells[3].Value.ToString();
                textBoxEmail.Text = row.Cells[4].Value.ToString();
                comboBoxSelectRole.SelectedValue = row.Cells[6].Value.ToString();
                MainClass.Disable(panelRightSlider);
            }
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (bunifuGradientPannelSidebar.Width < 50)
            {
                bunifuGradientPannelSidebar.Visible = false;
                bunifuGradientPannelSidebar.Width = 170;
                panelMenu.Width = 175;

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
