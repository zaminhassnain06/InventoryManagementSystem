using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace InventoryManagementSystem
{
    public partial class stocks : Sample2
    {
        Retrievel retrieve = new Retrievel();
        int ProductId = 0;
        decimal availableStock;
        decimal minStocks;
        decimal profitAmount;
        public stocks()
        {
            InitializeComponent();
            retrieve.GetListsComboStocks("usp_GetProductList", comboBoxSelectProduct, "ProductName", "ID");          
            foreach (DataGridViewColumn c in dataGridViewProduct.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 15.5F, GraphicsUnit.Pixel);
            }
            tableLayoutPanel1.Enabled = false;
            makeMneusmall();
            if(Retrievel.User_Type_Id==3)
            {
                panel1.Visible = false;
                dataGridViewProduct.Visible = false;
                labelMonth.Visible = false;
                labelScale.Visible = false;
                labelxaxis.Visible = false;
                labelYaxis.Visible = false;
                labelSelectDate.Visible = false;
                labelSelectProduct.Visible = false;
                dateTimePickerStock.Visible = false;
                comboBoxSelectProduct.Visible = false;
                buttonMonthlyReport.Visible = false;
            }
           
        }

        void makeMneusmall()
        {
            bunifuGradientPannelSidebar.Visible = false;
            bunifuGradientPannelSidebar.Width = 0;
            panelMenu.Width = 1;
            panelRightSlider.Width = panelLeftMiddleMain.Width - panelMenu.Width;
            bunifuTransitionAnimationSideBack.Show(bunifuGradientPannelSidebar);
        }
        void GetGridRows()
        {
            

            DataTable dt = new DataTable();
            dt = retrieve.GetStocksGraph(ProductId, dateTimePickerStock.Value);
           
            profitAmount = retrieve.GetProductProfit(ProductId, dateTimePickerStock.Value);

            chartStocksBarChart.Series.Clear();
            chartArea.Series.Clear();




            chartStocksBarChart.Series.Add("Stocks");
            chartArea.Series.Add("Stocks");


            chartArea.Series["Stocks"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chartStocksBarChart.Series["Stocks"].Points.AddXY(dt.Rows[i][1].ToString(), dt.Rows[i][0]);
                chartArea.Series["Stocks"].Points.AddXY(dt.Rows[i][1].ToString(), dt.Rows[i][0]);



                chartStocksBarChart.Series["Stocks"].Points[i].IsValueShownAsLabel = true;
                chartArea.Series["Stocks"].Points[i].IsValueShownAsLabel = true;


            }


            chartStocksBarChart.ChartAreas[0].AxisX.Interval = 1;
            chartArea.ChartAreas[0].AxisX.Interval = 1;
            chartArea.ChartAreas[0].BorderWidth = 10;
            
            //chartArea.BorderlineWidth = 10;



            chartStocksBarChart.Series[0].IsVisibleInLegend = false;
            chartArea.Series[0].IsVisibleInLegend = false;

            // GridView
            retrieve.ShowStockbyId(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks, ProductId, ReworkedStock, RejectedStock, OnHoldStock, PriceofStock);

            foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
            {
                minStocks = Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value);
                availableStock = Convert.ToDecimal(rows.Cells["AvailableStocks"].Value);
                if (Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value) < Convert.ToDecimal(rows.Cells["AvailableStocks"].Value))
                {
                    rows.Cells["AvailableStocks"].Style.BackColor = Color.LightGreen;
                    rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                }
                else
                {
                    rows.Cells["AvailableStocks"].Style.BackColor = Color.IndianRed;
                    rows.Cells["AvailableStocks"].Style.ForeColor = Color.Black;
                }
                labelAvaiableStockPrice.Text = "Available Stocks Price= Rs " + (Math.Round(Convert.ToDecimal(rows.Cells["PriceofStock"].Value))).ToString();
            }
          //  pictureBoxAvailableStock.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBalance_Paint);
          //  pictureBoxSalesProfit.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxProfit_Paint);
        
        }

        private void stocks_Load(object sender, EventArgs e)
        {


            retrieve.GetListsComboStocks("usp_GetProductList", comboBoxSelectProduct, "ProductName", "ID");
            comboBoxSelectProduct.SelectedIndex = 0;
            labelMonthValue.Text = dateTimePickerStock.Text;
        }

        private void buttonAddToStocks_Click(object sender, EventArgs e)
        {
            StockIn stkin = new StockIn();
            MainClass.ShowWindow(stkin, this, MDI.ActiveForm);
        }

        private void buttonStocksOut_Click(object sender, EventArgs e)
        {
            StockOut StkOut = new StockOut();
            MainClass.ShowWindow(StkOut, this, MDI.ActiveForm);
        }

        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectProduct.SelectedIndex > -1)
            {
                if (comboBoxSelectProduct.SelectedValue is int)
                {                   
                    VisualizeCharts();
                }
            }
        }


        void VisualizeCharts()
        {
            if (comboBoxSelectProduct.SelectedIndex > -1)
            {
                if (comboBoxSelectProduct.SelectedValue is int)
                {
                    ProductId = Convert.ToInt32(comboBoxSelectProduct.SelectedValue);
                    //DataTable dtId = retrieve.GetId("usp_GetProductID", comboBoxSelectProduct.Text);

                    //ProductId =Convert.ToInt32( dtId.Rows[0][0]);

                    DataTable dtStockIn = new DataTable();
                    dtStockIn = retrieve.GetStocksGraph(ProductId, dateTimePickerStock.Value);

                    DataTable dtStockOut = new DataTable();
                    dtStockOut = retrieve.GetStocksOutGraph(ProductId, dateTimePickerStock.Value);

                    DataTable dtAvailableStock = new DataTable();
                    dtAvailableStock = retrieve.GetAvailableStocksGraph(ProductId, dateTimePickerStock.Value);

                    chartStocksBarChart.Series.Clear();
                    chartArea.Series.Clear();

                    profitAmount = retrieve.GetProductProfit(ProductId, dateTimePickerStock.Value);


                    //chartStocksBarChart.Series.Add("Available Stocks");
                    //chartArea.Series.Add("Stocks In");
                    //chartArea.Series.Add("Stocks Out");


                    //chartArea.Series["Stocks In"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    //chartArea.Series["Stocks In"].Color = Color.Green;
                    //chartArea.Series["Stocks Out"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    //chartArea.Series["Stocks Out"].Color = Color.Red;

                    //for (int i = 0; i < dtStockIn.Rows.Count; i++)
                    //{

                    //    chartArea.Series["Stocks In"].Points.AddXY(dtStockIn.Rows[i][1].ToString(), dtStockIn.Rows[i][0]);                     
                    //    chartArea.Series["Stocks In"].Points[i].IsValueShownAsLabel = true;

                    //}

                    //for (int i = 0; i < dtStockOut.Rows.Count; i++)
                    //{

                    //    chartArea.Series["Stocks Out"].Points.AddXY(dtStockOut.Rows[i][1].ToString(), dtStockOut.Rows[i][0]);
                    //    chartArea.Series["Stocks Out"].Points[i].IsValueShownAsLabel = true;

                    //}

                    //for (int i = 0; i < dtAvailableStock.Rows.Count; i++)
                    //{
                    //    chartStocksBarChart.Series["Available Stocks"].Points.AddXY(dtAvailableStock.Rows[i][1].ToString(), dtAvailableStock.Rows[i][0]);
                    //    chartStocksBarChart.Series["Available Stocks"].Points[i].IsValueShownAsLabel = true;                     
                    //}


                    //chartStocksBarChart.ChartAreas[0].AxisX.Interval = 1;

                    //chartArea.ChartAreas[0].AxisX.Interval = 1;

                    //chartArea.ChartAreas[0].BorderWidth = 10;

                    //chartStocksBarChart.Series[0].IsVisibleInLegend = true;
                    //chartArea.Series[0].IsVisibleInLegend = true ;

                    //chartArea.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
                    //chartStocksBarChart.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;

                    chartArea.Series.Add("Available Stocks");
                    chartStocksBarChart.Series.Add("Stocks In");
                    chartStocksBarChart.Series.Add("Stocks Out");


                    chartArea.Series["Available Stocks"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    //chartArea.Series["Available Stocks"].MarkerSize = 20;
                    chartArea.Series["Available Stocks"].BorderWidth = 2;
                  //  chartArea.Series["Available Stocks"].Color = Color.Blue;

                    chartStocksBarChart.Series["Stocks In"].Color = Color.Red;
                    // chartArea.Series["Stocks Out"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chartStocksBarChart.Series["Stocks Out"].Color = Color.Green;

                    for (int i = 0; i < dtStockIn.Rows.Count; i++)
                    {

                        chartStocksBarChart.Series["Stocks In"].Points.AddXY(dtStockIn.Rows[i][1].ToString(), dtStockIn.Rows[i][0]);
                      //  chartStocksBarChart.Series["Stocks In"].Points[i].IsValueShownAsLabel = true;

                    }

                    for (int i = 0; i < dtStockOut.Rows.Count; i++)
                    {

                        chartStocksBarChart.Series["Stocks Out"].Points.AddXY(dtStockOut.Rows[i][1].ToString(), dtStockOut.Rows[i][0]);
                     //   chartStocksBarChart.Series["Stocks Out"].Points[i].IsValueShownAsLabel = true;

                    }

                    for (int i = 0; i < dtAvailableStock.Rows.Count; i++)
                    {
                        chartArea.Series["Available Stocks"].Points.AddXY(dtAvailableStock.Rows[i][1].ToString(), dtAvailableStock.Rows[i][0]);
                     //   chartArea.Series["Available Stocks"].Points[i].IsValueShownAsLabel = true;
                    }


                    chartStocksBarChart.ChartAreas[0].AxisX.Interval = 1;
                     

                    chartArea.ChartAreas[0].AxisX.Interval = 1;

                    chartArea.ChartAreas[0].BorderWidth = 10;

                    chartStocksBarChart.Series[0].IsVisibleInLegend = true;
                    chartArea.Series[0].IsVisibleInLegend = true;
                    

                    chartArea.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
                    chartStocksBarChart.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;



                    // GridView
                    retrieve.ShowStockbyId(dataGridViewProduct, ProductIdGv, ProductNameGv, ProductCodeGv, ProductUnitGv, ProductMinValGv, AvailableStocks, ProductId, ReworkedStock, RejectedStock, OnHoldStock, PriceofStock);

                    foreach (DataGridViewRow rows in dataGridViewProduct.Rows)
                    {

                        minStocks = Convert.ToDecimal(rows.Cells["ProductMinValGv"].Value);
                        availableStock = Convert.ToDecimal(rows.Cells["AvailableStocks"].Value);
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
                        labelAvaiableStockPrice.Text = "Available Stocks Price= Rs " + (Math.Round(Convert.ToDecimal(rows.Cells["PriceofStock"].Value))).ToString();
                    }
                    // pictureBoxAvailableStock.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBalance_Paint);
                    GetAvailableStockPercentage();
                    if (retrieve.IsSellerProduct(ProductId) && Retrievel.User_Type_Id==1)
                    {
                        GetSalesProfit();
                    }
                    else if (pictureBoxSalesProfit.Visible)
                    {
                        pictureBoxSalesProfit.Visible = false;
                        labelSalesProfitAmount.Visible = false;
                        labelSalesProfit.Visible = false;
                    }
                    // pictureBoxSalesProfit.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxProfit_Paint);
                }
            }
        }

        private void GetSalesProfit()
        {

            pictureBoxSalesProfit.Visible = true;
            labelSalesProfitAmount.Visible = true;
            labelSalesProfit.Visible = true;

            string text = string.Empty;
            if (profitAmount == 0)
            {
                text = "Rs 0";
            }
            else
            {


                decimal round = Math.Round(profitAmount);
                text = "Rs" + round.ToString() ;


            }
            labelSalesProfitAmount.Text = text;

        }

        private void GetAvailableStockPercentage()
        {
            decimal Percentage;
             string text = string.Empty;
         
             if (availableStock == 0 && minStocks == 0)
             {
                 text = "0%";
             }
             else
             {

                 Percentage = (availableStock / minStocks) * 100;
                 decimal round = Math.Round(Percentage);
                 text =   round.ToString() + " %";


             }

             labelAvailStockPerc.Text = text;
        }

        private void pictureBoxProfit_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            
            string text = string.Empty;
            if (profitAmount == 0 )
            {
                text = string.Empty;
            }
            else
            {

                
                decimal round = Math.Round(profitAmount);
                text = "      Rs " + round.ToString() + "\r\n Profit";


            }

            if (string.IsNullOrEmpty(text))
            {
                text = string.Empty;
            }


            Font fontStyle = new Font("Arial", 12, FontStyle.Bold);

            SizeF textSize = e.Graphics.MeasureString(text, fontStyle);
            PointF locationToDraw = new PointF();
            locationToDraw.X = (pictureBoxAvailableStock.Width / 2) - (textSize.Width / 2);
            locationToDraw.Y = (pictureBoxAvailableStock.Height / 2) - (textSize.Height / 2);

            e.Graphics.DrawString(text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, locationToDraw);
        }
        private void pictureBoxBalance_Paint(object sender, PaintEventArgs e)
        {
            // userdata_list = JsonConvert.DeserializeObject<List<UserData>>(result);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;


            // decimal minValue=Convert.ToDecimal( dataGridViewProduct.SelectedRows[0].Cells["ProductMinValGv"].Value);
            // decimal AvailableValue = Convert.ToDecimal(dataGridViewProduct.SelectedRows[0].Cells["AvailableStocks"].Value);
            decimal Percentage;
            string text = string.Empty;
            if (availableStock == 0 && minStocks == 0)
            {
                text = string.Empty;
            }
            else
            {

                Percentage = (availableStock / minStocks) * 100;
                decimal round = Math.Round(Percentage);
                text = "           " + round.ToString() + " %\r\n Available Stock % ";


            }

            if (string.IsNullOrEmpty(text))
            {
                text = string.Empty;
            }


            Font fontStyle = new Font("Arial", 12, FontStyle.Bold);

            SizeF textSize = e.Graphics.MeasureString(text, fontStyle);
            PointF locationToDraw = new PointF();
            locationToDraw.X = (pictureBoxAvailableStock.Width / 2) - (textSize.Width / 2);
            locationToDraw.Y = (pictureBoxAvailableStock.Height / 2) - (textSize.Height / 2);

            e.Graphics.DrawString(text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, locationToDraw);
        }
        private void buttonPOCreation_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            MainClass.ShowWindow(PO, this, MDI.ActiveForm);
        }

        private void ImportFileData(DataTable dt)
        {
            try
            {             
                Updation update = new Updation();
            
                foreach (DataRow row in dt.Rows)            
                {                
                    DataTable dtProductId = retrieve.GetId("usp_GetProductID", row[0].ToString());                
                    //stocks in                
                    update.UpdateIncreaseAvailableStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[2]),Convert.ToDateTime(row[1]));                
                    //stocks out                
                    update.UpdateDecreaseAvailableStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[3]), Convert.ToDateTime(row[1]));                
                    //stock onhold
                    update.UpdateIncreaseInOnHoldStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[4]), Convert.ToDateTime(row[1]));
                    //resolve onhold
                    update.UpdateResolveInOnHoldStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[5]), Convert.ToDateTime(row[1]));
                    //stock rejected
                    update.UpdateIncreaseRejectedStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[6]), Convert.ToDateTime(row[1]));
                    //resolve rejected
                    update.UpdateIResolveRejectedStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[7]), Convert.ToDateTime(row[1]));
                    //stock reworked
                    update.UpdateIncreaseInReworkedStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[8]), Convert.ToDateTime(row[1]));
                    //resolve reworked
                    update.UpdateResolveInReworkedStocks(Convert.ToInt32(dtProductId.Rows[0][0].ToString()), Convert.ToDecimal(row[9]), Convert.ToDateTime(row[1]));
            
                }
                 
                MainClass.ShowMessage("Stocks Updated Successfully. ", "Success", "Success");
                
            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");
            }
        }

        private void buttonPORECEV_Click(object sender, EventArgs e)
        {
            POReceiving por = new POReceiving();
            MainClass.ShowWindow(por, this, MDI.ActiveForm);
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            MainClass.ShowWindow(sale, this, MDI.ActiveForm);
        }

        private void dateTimePickerPO_ValueChanged(object sender, EventArgs e)
        {
            labelMonthValue.Text = dateTimePickerStock.Text;
            VisualizeCharts();
            
        }

        private void buttonMonthlyReport_Click(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DataSet ds = new DataSet();
            
            if (comboBoxSelectProduct.SelectedIndex > -1)
            {
                if (comboBoxSelectProduct.SelectedValue is int)
                {
                    ds = retrieve.GetOverAllReportDetails(dateTimePickerStock.Value.Month, ProductId);
                    labelReportisGenerating.Visible = true;
                    StocksReport.ExportDataSetToExcelOverAllReport(ds, Path, comboBoxSelectProduct.Text);
                    labelReportisGenerating.Visible = false;
                    MainClass.ShowMessage("Report Generated Sucessfully", "Success", "Success");
                }
            }
            else
            {
                MainClass.ShowMessage("Please Select a Product First.", "Error", "Error");
            }
            
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxPath.Text = FileDialog.FileName;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string pathCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBoxPath.Text + "; Extended Properties=\"Excel 8.0;HDR=Yes\";";
            OleDbConnection conn = new OleDbConnection(pathCon);
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EntrySheet$]", conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ImportFileData(dt);
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
