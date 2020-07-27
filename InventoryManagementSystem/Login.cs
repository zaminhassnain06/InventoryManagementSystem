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
    public partial class Login : Sample
    {
      
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
             if(textBoxUserName.Text=="")
            {
                labelUserNameError.Visible = true;
            }
             else
             {
                  labelUserNameError.Visible = false;
             }
             if(textBoxPassword.Text=="")
            {
                labelPasswordError.Visible = true;
            }
             else
             {
                 labelPasswordError.Visible = false;
             }
           if( labelUserNameError.Visible || labelPasswordError.Visible)
           {
               MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.
           }
           else
           {
               
                   if (Retrievel.GetUserDetails(textBoxUserName.Text, textBoxPassword.Text))
                   {

                      
                      
                       HomeScreen obj = new HomeScreen();

                       MainClass.ShowWindow(obj, this, MDI.ActiveForm);
                       
                   }
               
           }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                labelUserNameError.Visible = true;
            }
            else
            {
                labelUserNameError.Visible = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                labelPasswordError.Visible = true;
            }
            else
            {
                labelPasswordError.Visible = false;
            }

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
