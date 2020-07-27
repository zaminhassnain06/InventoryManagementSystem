using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string source = "";
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(checkBoxIntegratedSecurity.Checked)
            {

                if (textBoxServer.Text != "" && textBoxDB.Text != "")
                {
                    source = "Data Source= " + textBoxServer.Text + "; Initial Catalog= " + textBoxDB.Text + "; Integrated Security=true ; MultipleActiveResultSets = true;";

                    File.WriteAllText(Path+"\\connect", source);
                    DialogResult dr = MessageBox.Show("Settings saved successfully.", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }

                else
                    MessageBox.Show("Please give complete data to continue.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxServer.Text != "" && textBoxDB.Text != "" && textBoxUserId.Text!="" && textBoxPassword.Text!="")
                {

                    source = "Data Source= " + textBoxServer.Text + "; Initial Catalog= " + textBoxDB.Text + "; User ID= " + textBoxUserId.Text + "; Password=" + textBoxPassword.Text + " ; MultipleActiveResultSets = true;";

                    File.WriteAllText(Path + "\\connect", source);
                    DialogResult dr = MessageBox.Show("Settings saved successfully.", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }

                else
                    MessageBox.Show("Please give complete data to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void checkBoxIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIntegratedSecurity.Checked)
            {
                textBoxPassword.Enabled = false;
                textBoxUserId.Enabled = false;
                textBoxPassword.Clear();
                textBoxUserId.Clear() ;
            }
            else
            {
                textBoxPassword.Enabled = true;
                textBoxUserId.Enabled = true;

            }
        }
    }
}
