using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace InventoryManagementSystem
{
    class MainClass
    {
        private static string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string s = File.ReadAllText(Path + "\\connect");
        public static SqlConnection con = new SqlConnection(s);
        public static void ShowWindow(Form OpenWin, Form CloseWin, Form MDIWin)
        {
            CloseWin.Close();
            OpenWin.MdiParent = MDIWin;
            OpenWin.WindowState = FormWindowState.Maximized;
            OpenWin.WindowState = FormWindowState.Maximized;
            
            OpenWin.Show();
        }

        public static void ShowWindow(Form OpenWin,  Form MDIWin)
        {
           
            OpenWin.MdiParent = MDIWin;
            OpenWin.WindowState = FormWindowState.Maximized;
            MDIWin.WindowState = FormWindowState.Maximized;
            OpenWin.Show();
        }
        public static void Disable_Reset(Panel pannel)
        {
            foreach (Control c in pannel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textbox = (TextBox)c;
                    textbox.Enabled = false;
                    textbox.Clear();
                }
                if (c is ComboBox)
                {
                    ComboBox cbox = (ComboBox)c;
                    cbox.Enabled = false;
                    cbox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    rbtn.Enabled = false;
                    rbtn.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cbox = (CheckBox)c;
                    cbox.Enabled = false;
                    cbox.Checked = false;

                }
                


            }
        }

        public static void Disable(Panel pannel)
        {
            foreach (Control c in pannel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textbox = (TextBox)c;
                    textbox.Enabled = false;
                   
                }
                if (c is ComboBox)
                {
                    ComboBox cbox = (ComboBox)c;
                    cbox.Enabled = false;
                   
                }
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    rbtn.Enabled = false;
                  
                }
                if (c is CheckBox)
                {
                    CheckBox cbox = (CheckBox)c;
                    cbox.Enabled = false;
                   

                }
                

            }

        }      
        
        public static void Enable_Reset(Panel pannel)
        {
            foreach (Control c in pannel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textbox = (TextBox)c;
                    textbox.Enabled = true;
                    textbox.Clear();
                }
                if (c is ComboBox)
                {
                    ComboBox cbox = (ComboBox)c;
                    cbox.Enabled = true;
                    cbox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    rbtn.Enabled = true;
                    rbtn.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cbox = (CheckBox)c;
                    cbox.Enabled = true;
                    cbox.Checked = false;

                }
               if(c is Button)
               {
                   Button btn = (Button)c;
                   btn.Enabled = true;
               }


            }
        
        }

        public static void Enable(Panel pannel)
        {
            foreach (Control c in pannel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textbox = (TextBox)c;
                    textbox.Enabled = true;
                  
                }
                if (c is ComboBox)
                {
                    ComboBox cbox = (ComboBox)c;
                    cbox.Enabled = true;
                   
                }
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)c;
                    rbtn.Enabled = true;
                   
                }
                if (c is CheckBox)
                {
                    CheckBox cbox = (CheckBox)c;
                    cbox.Enabled = true;
                

                }
              


            }

        }
        public static DialogResult ShowMessage(string message,string heading, string type)
        {
            if(type=="Success")
            {
                return MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

