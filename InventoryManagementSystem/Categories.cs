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
    public partial class Categories : Sample2
    {
        int edit = 0; //0 is an indication for save operation and 1 is an indifaction for update operation

        int CategoryId = 0;
        short stat;
        Retrievel retrieve = new Retrievel();
        public Categories()
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
            retrieve.ShowCategories(dataGridViewCat, catIdGV, CatGVName, CatGVStatus);
        }
        private void Categories_Load(object sender, EventArgs e)
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
                    del.DeleteDetails(CategoryId, "Usp_RemoveCategoryDetails", "@Id");
                    retrieve.ShowCategories(dataGridViewCat, catIdGV, CatGVName, CatGVStatus);
                    MainClass.Disable_Reset(panelRightSlider);
                }
            }
        }

        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                 retrieve.ShowCategories(dataGridViewCat, catIdGV, CatGVName, CatGVStatus, textBoxSearch.Text);

            }
            else
            {
                retrieve.ShowCategories(dataGridViewCat, catIdGV, CatGVName, CatGVStatus);
            }
        }

        public override void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCategoryName.Text == "")
            {
                labelCategoryNameError.Visible = true;
            }
            else
            {
                labelCategoryNameError.Visible = false;
            }

            if (comboBoxIsSales.SelectedIndex==-1)
            {
                labelIsSalesError.Visible = true;
            }
            else
            {
                labelIsSalesError.Visible = false;
            }

            if (labelCategoryNameError.Visible || labelIsSalesError.Visible)
            {
                MainClass.ShowMessage("Fields with * are mandatory", "Error", "Error"); //Error is the type of message.
            }
            else
            {
                if(comboBoxIsSales.SelectedIndex==1)
                {
                    stat = 0;
                }
                else if (comboBoxIsSales.SelectedIndex==0)
                {
                    stat = 1;
                }
                if (edit == 0)  //Code for save operation
                {
                    Insertion insert = new Insertion();
                    insert.SaveCategoryDetails(textBoxCategoryName.Text, stat);


                    retrieve.ShowCategories(dataGridViewCat, catIdGV, CatGVName, CatGVStatus);
                    MainClass.Disable_Reset(panelRightSlider);

                }
                else if (edit == 1) //code for update operaiton
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation update = new Updation();
                        update.UpdateCategoryDetails(textBoxCategoryName.Text, stat, CategoryId);
                   

                        retrieve.ShowCategories(dataGridViewCat, catIdGV, CatGVName, CatGVStatus);
                        MainClass.Disable_Reset(panelRightSlider);
                    }

                }
            }
        }

        public override void buttonView_Click(object sender, EventArgs e)
        {
            retrieve.ShowCategories(dataGridViewCat, catIdGV, CatGVName, CatGVStatus);
        }

        private void dataGridViewCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewCat.Rows[e.RowIndex];
                CategoryId = Convert.ToInt32(row.Cells[0].Value.ToString());
                textBoxCategoryName.Text = row.Cells[1].Value.ToString();
               comboBoxIsSales.SelectedItem = row.Cells[2].Value.ToString();
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

    

       

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            MainClass.ShowWindow(PO, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            MainClass.ShowWindow(sale, this, MDI.ActiveForm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            MainClass.ShowWindow(products, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stocks st = new stocks();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            POReceiving por = new POReceiving();
            MainClass.ShowWindow(por, this, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StockIn stkin = new StockIn();
            MainClass.ShowWindow(stkin, this, MDI.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StockOut StkOut = new StockOut();
            MainClass.ShowWindow(StkOut, this, MDI.ActiveForm);
        }

      
        

        
    }
}
