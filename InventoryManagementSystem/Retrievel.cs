using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace InventoryManagementSystem
{
    class Retrievel
    {
        private  static string usernames=null, passwordsnames=null;
        private ReportDocument rd;
        public void ShowUsers(DataGridView gv, DataGridViewColumn UserIdGv, DataGridViewColumn UseNameGv, DataGridViewColumn UserPasswordGv, DataGridViewColumn UserContactGv, DataGridViewColumn UserEmailGv, DataGridViewColumn Role,DataGridViewColumn RoleId, string Data = null)
        {

            try
            {
                SqlCommand cmd ;//= new SqlCommand();
                if(Data==null)
                {

                     cmd = new SqlCommand("Usp_GetUserDetails", MainClass.con);
                }
                else
                {
                     cmd = new SqlCommand("Usp_SearchUserDetails", MainClass.con);
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@Data", Data);

                }

               
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                UseNameGv.DataPropertyName = dt.Columns["Username"].ToString();
                UserPasswordGv.DataPropertyName = dt.Columns["Password"].ToString();
                UserContactGv.DataPropertyName = dt.Columns["Contact Number"].ToString();
                UserEmailGv.DataPropertyName = dt.Columns["Email Id"].ToString();
                Role.DataPropertyName = dt.Columns["Role"].ToString();
                RoleId.DataPropertyName = dt.Columns["RoleId"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage("Unable to Load users data", "Error", "Error");
            }
        }

        public void ShowonCrystalReport(ReportDocument rdd,CrystalReportViewer crv,string proc,string param1,object val1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                rdd.Load(Application.StartupPath+"\\Reports\\CrystalReportPO.rpt");
                rdd.SetDataSource(dt);
                crv.ReportSource = rdd;
                crv.RefreshReport();
                 
            }
            catch(Exception exp)
            {
                throw exp;
            }

        }

        public void ShowonCrystalReportSalesInvoice(ReportDocument rdd, CrystalReportViewer crv, string proc, string param1, object val1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rdd.Load(Application.StartupPath + "\\Reports\\CrystalReportSale.rpt");
                rdd.SetDataSource(dt);
                crv.ReportSource = rdd;
                crv.RefreshReport();

            }
            catch (Exception exp)
            {
                throw exp;
            }

        }


        public void ShowonCrystalReportPOReceiving(ReportDocument rdd, CrystalReportViewer crv, string proc, string param1, object val1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rdd.Load(Application.StartupPath + "\\Reports\\CrystalReportPOReceiving.rpt");
                rdd.SetDataSource(dt);
                crv.ReportSource = rdd;
                crv.RefreshReport();

            }
            catch (Exception exp)
            {
                throw exp;
            }

        }
        public void ShowCategories(DataGridView gv, DataGridViewColumn CategoryIdGv, DataGridViewColumn CategoryGv, DataGridViewColumn CategoryIsActiveGv,  string Data = null)
        {

            try
            {
                SqlCommand cmd;//= new SqlCommand();
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetCategoryDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchCategoryDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CategoryIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                CategoryGv.DataPropertyName = dt.Columns["Category Name"].ToString();
                CategoryIsActiveGv.DataPropertyName = dt.Columns["Is Active"].ToString();
             

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load categories data", "Error", "Error");
            }
        }

        public void GetLists(string Proc,ComboBox cb,string displayMember,string valueMember,int RequiredId=0)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                
                SqlCommand cmd = new SqlCommand(Proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr,0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
             
            }
            catch
            {

            }

        }

        public void GetListsComboStocks(string Proc, ComboBox cb, string displayMember, string valueMember, int RequiredId = 0)
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(Proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
            
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;

            }
            catch
            {

            }

        }


      
        public void GetListWith2Param(string Proc, ComboBox cb, string displayMember, string valueMember, string param1,string param2,object param1Value ,object param2Value)
        {
            try
            {
               // cb.Items.Clear();
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(Proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, param1Value);
                cmd.Parameters.AddWithValue(param2, param2Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;

            }
            catch(Exception exp)
            {
                throw exp;

            }

        }

        public void ShowProducts(DataGridView gv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn ProductCodeGv, DataGridViewColumn ProductPriceGv, DataGridViewColumn ProductUnitGv, DataGridViewColumn ProductMinValGv, DataGridViewColumn ProductCatNameGv, DataGridViewColumn ProductCatIdGv, DataGridViewColumn SalesPriceIdGv, string Data = null)
        {

            try
            {
                SqlCommand cmd;//= new SqlCommand();
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetProductDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchProductDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["Productname"].ToString();
                ProductCodeGv.DataPropertyName = dt.Columns["Code"].ToString();
                ProductPriceGv.DataPropertyName = dt.Columns["Price"].ToString();
                ProductUnitGv.DataPropertyName = dt.Columns["Unit"].ToString();
                ProductMinValGv.DataPropertyName = dt.Columns["MinValue"].ToString();
                ProductCatNameGv.DataPropertyName = dt.Columns["CatName"].ToString();
                ProductCatIdGv.DataPropertyName = dt.Columns["CatId"].ToString();
                SalesPriceIdGv.DataPropertyName = dt.Columns["SalesCost"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Products data", "Error", "Error");
            }
        }


        public void ShowStock(DataGridView gv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn ProductCodeGv, DataGridViewColumn ProductUnitGv, DataGridViewColumn ProductMinValGv, DataGridViewColumn AvailableStocks,DataGridViewColumn ReworkedStock, DataGridViewColumn RejectedStock, DataGridViewColumn OnHoldStock, string Data = null)
        {

            try
            {
                SqlCommand cmd;//= new SqlCommand();
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetStocksDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchStocksDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["Productname"].ToString();
                ProductCodeGv.DataPropertyName = dt.Columns["Code"].ToString();
              
                ProductUnitGv.DataPropertyName = dt.Columns["Unit"].ToString();
               
                ProductMinValGv.DataPropertyName = dt.Columns["MinValue"].ToString();
                AvailableStocks.DataPropertyName = dt.Columns["AvailableStocks"].ToString();
                ReworkedStock.DataPropertyName= dt.Columns["ReworkedStock"].ToString();
                RejectedStock.DataPropertyName=dt.Columns["RejectedStock"].ToString();
                OnHoldStock.DataPropertyName = dt.Columns["OnHoldStock"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Products data", "Error", "Error");
            }
        }

        public void ShowReworkedStock(DataGridView gv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn ProductCodeGv, DataGridViewColumn ProductUnitGv, DataGridViewColumn ProductMinValGv, DataGridViewColumn AvailableStocks, DataGridViewColumn ReworkedStock, DataGridViewColumn RejectedStock, DataGridViewColumn OnholdStock,string Data = null)
        {

            try
            {
                SqlCommand cmd;//= new SqlCommand();
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetReworkedStocksDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchReworkedStocksDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["Productname"].ToString();
                ProductCodeGv.DataPropertyName = dt.Columns["Code"].ToString();

                ProductUnitGv.DataPropertyName = dt.Columns["Unit"].ToString();

                ProductMinValGv.DataPropertyName = dt.Columns["MinValue"].ToString();
                AvailableStocks.DataPropertyName = dt.Columns["AvailableStocks"].ToString();
                ReworkedStock.DataPropertyName = dt.Columns["ReworkedStock"].ToString();
                RejectedStock.DataPropertyName = dt.Columns["RejectedStock"].ToString();
                OnholdStock.DataPropertyName = dt.Columns["OnHoldStock"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Products data", "Error", "Error");
            }
        }

        public void ShowOnHoldStock(DataGridView gv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn ProductCodeGv, DataGridViewColumn ProductUnitGv, DataGridViewColumn ProductMinValGv, DataGridViewColumn AvailableStocks,DataGridViewColumn ReworkedStock, DataGridViewColumn RejectedStock, DataGridViewColumn OnholdStock, string Data = null)
        {

            try
            {
                SqlCommand cmd;//= new SqlCommand();
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetOnHoldStocksDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchOnHoldStocksDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["Productname"].ToString();
                ProductCodeGv.DataPropertyName = dt.Columns["Code"].ToString();

                ProductUnitGv.DataPropertyName = dt.Columns["Unit"].ToString();

                ProductMinValGv.DataPropertyName = dt.Columns["MinValue"].ToString();
                AvailableStocks.DataPropertyName = dt.Columns["AvailableStocks"].ToString();
                ReworkedStock.DataPropertyName = dt.Columns["ReworkedStock"].ToString();
                RejectedStock.DataPropertyName = dt.Columns["RejectedStock"].ToString();
                OnholdStock.DataPropertyName = dt.Columns["OnHoldStock"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Products data", "Error", "Error");
            }
        }


        public void ShowRejectedStock(DataGridView gv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn ProductCodeGv, DataGridViewColumn ProductUnitGv, DataGridViewColumn ProductMinValGv, DataGridViewColumn AvailableStocks, DataGridViewColumn ReworkedStock, DataGridViewColumn RejectedStock, DataGridViewColumn OnholdStock  , string Data = null)
        {

            try
            {
                SqlCommand cmd;//= new SqlCommand();
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetRejectedStocksDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchRejectedStocksDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["Productname"].ToString();
                ProductCodeGv.DataPropertyName = dt.Columns["Code"].ToString();

                ProductUnitGv.DataPropertyName = dt.Columns["Unit"].ToString();

                ProductMinValGv.DataPropertyName = dt.Columns["MinValue"].ToString();
                AvailableStocks.DataPropertyName = dt.Columns["AvailableStocks"].ToString();
                ReworkedStock.DataPropertyName = dt.Columns["ReworkedStock"].ToString();
                RejectedStock.DataPropertyName = dt.Columns["RejectedStock"].ToString();
                OnholdStock.DataPropertyName = dt.Columns["OnHoldStock"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage("Unable to Load Products data", "Error", "Error");
            }
        }
        public void ShowStockbyId(DataGridView gv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn ProductCodeGv, DataGridViewColumn ProductUnitGv, DataGridViewColumn ProductMinValGv, DataGridViewColumn AvailableStocks, int ProductId, DataGridViewColumn ReworkedStock, DataGridViewColumn RejectedStock, DataGridViewColumn OnHoldStock, DataGridViewColumn availableStockPrice)
        {

            try
            {
                SqlCommand cmd;//= new SqlCommand();

                cmd = new SqlCommand("Usp_GetStocksDetailsbyId", MainClass.con);
                
                
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", ProductId);

                


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["Productname"].ToString();
                ProductCodeGv.DataPropertyName = dt.Columns["Code"].ToString();

                ProductUnitGv.DataPropertyName = dt.Columns["Unit"].ToString();

                ProductMinValGv.DataPropertyName = dt.Columns["MinValue"].ToString();
                AvailableStocks.DataPropertyName = dt.Columns["AvailableStocks"].ToString();
                ReworkedStock.DataPropertyName=dt.Columns["ReworkedStocks"].ToString();
                RejectedStock.DataPropertyName = dt.Columns["StockRejected"].ToString();
                OnHoldStock.DataPropertyName = dt.Columns["StockOnHold"].ToString();
                availableStockPrice.DataPropertyName = dt.Columns["Cost"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Products data", "Error", "Error");
            }
        }

       
        public void ShowPOLines(DataGridView gv, DataGridViewColumn PoLineIdGv,DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn LineNumberGv, DataGridViewColumn ProductPriceGv, DataGridViewColumn QuantityGv, DataGridViewColumn TotalCost, int poNumber,DataGridViewColumn UnitGv)
        {

            try
            {
                SqlCommand cmd;
                
                cmd = new SqlCommand("Usp_GetPOLine", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PONumber", poNumber);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                PoLineIdGv.DataPropertyName = dt.Columns["POLineID"].ToString();
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                LineNumberGv.DataPropertyName = dt.Columns["LineNumber"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["ProductName"].ToString();
                ProductPriceGv.DataPropertyName = dt.Columns["ProductCost"].ToString();
                QuantityGv.DataPropertyName = dt.Columns["Quantity"].ToString();
                TotalCost.DataPropertyName = dt.Columns["TotalCost"].ToString();
                UnitGv.DataPropertyName = dt.Columns["Unit"].ToString();
                gv.AutoGenerateColumns = false;
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load PO data", "Error", "Error");
            }
        }

        public void ShowRecivLines(DataGridView gv, DataGridViewColumn PoLineIdGv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn LineNumberGv, DataGridViewColumn ProductPriceGv, DataGridViewColumn QuantityGv, DataGridViewColumn TotalCost, int poNumber, DataGridViewColumn UnitGv, DataGridViewColumn QuantityReceivedDgv, DataGridViewColumn ReceivedQuantityCostDgv)
        {

            try
            {
                SqlCommand cmd;

                cmd = new SqlCommand("Usp_GetReceivedPOLine", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PONumber", poNumber);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                PoLineIdGv.DataPropertyName = dt.Columns["POLineID"].ToString();
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                LineNumberGv.DataPropertyName = dt.Columns["LineNumber"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["ProductName"].ToString();
                ProductPriceGv.DataPropertyName = dt.Columns["ProductCost"].ToString();
                QuantityGv.DataPropertyName = dt.Columns["Quantity"].ToString();
                TotalCost.DataPropertyName = dt.Columns["TotalCost"].ToString();
                UnitGv.DataPropertyName = dt.Columns["Unit"].ToString();
                QuantityReceivedDgv.DataPropertyName = dt.Columns["QuantityReceived"].ToString();
                ReceivedQuantityCostDgv.DataPropertyName = dt.Columns["ReceivedCost"].ToString();
                gv.AutoGenerateColumns = false;
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load PO data", "Error", "Error");
            }
        }

        public void ShowSalesLines(DataGridView gv, DataGridViewColumn SalesLineIdGv, DataGridViewColumn ProductIdGv, DataGridViewColumn ProductNameGv, DataGridViewColumn LineNumberGv, DataGridViewColumn ProductPriceGv, DataGridViewColumn QuantityGv, DataGridViewColumn TotalCost, DataGridViewColumn Unit,int SalesNumber)
        {

            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("Usp_GetSalesLine", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SalesNumber", SalesNumber);

         



                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SalesLineIdGv.DataPropertyName = dt.Columns["SalesLineID"].ToString();
                ProductIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                LineNumberGv.DataPropertyName = dt.Columns["LineNumber"].ToString();
                ProductNameGv.DataPropertyName = dt.Columns["ProductName"].ToString();
                ProductPriceGv.DataPropertyName = dt.Columns["ProductCost"].ToString();
                QuantityGv.DataPropertyName = dt.Columns["Quantity"].ToString();
                TotalCost.DataPropertyName = dt.Columns["TotalCost"].ToString();
                Unit.DataPropertyName = dt.Columns["Unit"].ToString(); 
                gv.AutoGenerateColumns = false;
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Sales data", "Error", "Error");
            }
        }
        public  static int User_ID
        {
            get;
           private set;
        }
        public static string User_Name
        {
            get;
            private set;
        }

        public static int User_Type_Id
        {
            get;
            private set;
        }


        private static bool checklogin = false;
        public static bool GetUserDetails(string UserName, string Password)
        {
            try
            {
                SqlCommand cmd= new SqlCommand();
                cmd = new SqlCommand("LoginUser", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    checklogin = true;
                    while(dr.Read())
                    {
                        User_ID = Convert.ToInt32(dr[0].ToString());
                        User_Name = dr[1].ToString();
                        usernames = dr[1].ToString();
                        passwordsnames = dr[2].ToString();
                        User_Type_Id = Convert.ToInt32( dr[3]);
                       
                       
                        

                    }
                }
                else
                {
                    checklogin = false;
                    if(usernames!=null & passwordsnames!=null)
                    {
                        if(usernames!=UserName)
                        {
                            MainClass.ShowMessage("Invalid Username.", "Error", "Error");
                        }
                        else if(passwordsnames!=Password)
                        {
                            MainClass.ShowMessage("Invalid Password.", "Error", "Error");
                        }
                        else if (usernames != UserName && passwordsnames != Password)
                        {
                            MainClass.ShowMessage("Invalid Username and Password.", "Error", "Error");

                        }
                    }

                }
                MainClass.con.Close();
            }
                
            catch (Exception exp)
            {
                MainClass.ShowMessage("Unable to Login.", "Error", "Error");
            }
           return checklogin;
            
        }
        public DataTable GetPOLinesforPDFExport(int PONumber)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_CreatePOPDFReport", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PoNumber", PONumber);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
             

                return dt;


            }
            catch (Exception exp)
            {
                throw exp;

            }

            return dt;

        }


        public int StocksStatusNotification()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Usp_StockStatusNotification", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;


                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return Convert.ToInt32 (dt.Rows[0][0]);
            }
            catch(Exception exp)
            {
                throw exp;
            }
            return 0;
        }

        public DataTable StocksStatusNotificationProductNames()
        {
            DataTable dt = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("Usp_ProductsWithMinValuesofStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;


               
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return dt;
        }
        public DataTable GetSalesLinesforPDFExport(int SalesNumber)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_CreatePOSalesPDFReport", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SalesNumber", SalesNumber);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch (Exception exp)
            {
                throw exp;

            }

            return dt;

        }

        public DataTable GetReceivLinesforPDFExport(int ReceivId)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_CreateReceivPDFReport", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RecivId", ReceivId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch (Exception exp)
            {
                throw exp;

            }

            return dt;

        }

        public DataTable GetPOSupplier(int PONumber)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetPOSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PoNumber", PONumber);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                
                return dt;


            }
            catch
            {

            }

            return dt;

        }

        public DataTable GetSalesCustomerId(int SalesId)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetSalesCustomer", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SalesNumber", SalesId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch
            {

            }

            return dt;

        }
        public void ShowSupplier(DataGridView gv, DataGridViewColumn SupplierIdGv, DataGridViewColumn SupplierNameGv, DataGridViewColumn SupplierCodeGv, DataGridViewColumn SupplierContactNumberGv, DataGridViewColumn SupplierEmailGv, DataGridViewColumn SupplierAddresseGv, DataGridViewColumn SupplierCityGv, DataGridViewColumn SupplierCountryGv, DataGridViewColumn SupplierPaymentMethodGv, DataGridViewColumn SupplierDeliveryMethodGv, DataGridViewColumn SupplierDeliveryLeadTimeIdGv, string Data = null)
        {

            try
            {
                SqlCommand cmd;
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetSupplierDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchUSupplierDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                SupplierNameGv.DataPropertyName = dt.Columns["Suppliername"].ToString();
                SupplierCodeGv.DataPropertyName = dt.Columns["SupplierCode"].ToString();
                SupplierContactNumberGv.DataPropertyName = dt.Columns["Contact Number"].ToString();
                SupplierEmailGv.DataPropertyName = dt.Columns["Email Id"].ToString();
                SupplierAddresseGv.DataPropertyName = dt.Columns["Address"].ToString();
                SupplierCityGv.DataPropertyName = dt.Columns["City"].ToString();
                SupplierCountryGv.DataPropertyName = dt.Columns["Country"].ToString();
                SupplierPaymentMethodGv.DataPropertyName = dt.Columns["PaymentMethod"].ToString();
                SupplierDeliveryMethodGv.DataPropertyName = dt.Columns["DeliveryMethod"].ToString();
                SupplierDeliveryLeadTimeIdGv.DataPropertyName = dt.Columns["DeliveryLeadTime"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Supplier data", "Error", "Error");
            }
        }


        public void ShowCustomer(DataGridView gv, DataGridViewColumn CustomerIdGv, DataGridViewColumn CustomerNameGv, DataGridViewColumn CustomerCodeGv, DataGridViewColumn CustomerContactNumberGv, DataGridViewColumn CustomerEmailGv, DataGridViewColumn CustomerAddresseGv, DataGridViewColumn CustomerCityGv, DataGridViewColumn CustomerCountryGv, DataGridViewColumn CustomerPaymentMethodGv, DataGridViewColumn CustomerDeliveryMethodGv, DataGridViewColumn CustomerDeliveryLeadTimeIdGv, string Data = null)
        {

            try
            {
                SqlCommand cmd;
                if (Data == null)
                {

                    cmd = new SqlCommand("Usp_GetCustomerDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("Usp_SearchUCustomerDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Data", Data);

                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CustomerIdGv.DataPropertyName = dt.Columns["ID"].ToString();
                CustomerNameGv.DataPropertyName = dt.Columns["Customername"].ToString();
                CustomerCodeGv.DataPropertyName = dt.Columns["CustomerCode"].ToString();
                CustomerContactNumberGv.DataPropertyName = dt.Columns["Contact Number"].ToString();
                CustomerEmailGv.DataPropertyName = dt.Columns["Email Id"].ToString();
                CustomerAddresseGv.DataPropertyName = dt.Columns["Address"].ToString();
                CustomerCityGv.DataPropertyName = dt.Columns["City"].ToString();
                CustomerCountryGv.DataPropertyName = dt.Columns["Country"].ToString();
                CustomerPaymentMethodGv.DataPropertyName = dt.Columns["PaymentMethod"].ToString();
                CustomerDeliveryMethodGv.DataPropertyName = dt.Columns["DeliveryMethod"].ToString();
                CustomerDeliveryLeadTimeIdGv.DataPropertyName = dt.Columns["DeliveryLeadTime"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMessage("Unable to Load Customer data", "Error", "Error");
            }
        }
        public DataTable GetProductPrice(int RequiredId )
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("usp_GetProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", RequiredId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               
                da.Fill(dt);
                
                
                    return dt;
                

            }
            catch(Exception exp)
            {

                throw exp;
            }
            finally
            {
                
            }

            return dt;

        }

        public DataTable GetProductPriceUnitStock(int RequiredId)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("usp_GetProductPriceUnitStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", RequiredId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch (Exception exp)
            {

                throw exp;
            }
            finally
            {

            }

            return dt;

        }


        public DataTable GetId(string procedure ,string name=null)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (name != null)
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch
            {

            }

            return dt;

        }

        public bool IsSellerProduct(int productId)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("usp_IsSellerProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", productId);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);      
              
            }
            catch
            {

            }


            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable GetStocksGraph(int ProductId, DateTime dateTime)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetProductStockDetailsforGraph", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                
               cmd.Parameters.AddWithValue("@ProductId", ProductId);
               cmd.Parameters.AddWithValue("@Date", dateTime);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch
            {

            }

            return dt;

        }

        public DataTable GetStocksOutGraph(int ProductId, DateTime dateTime)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetProductStockOutDetailsforGraph", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", ProductId);
                cmd.Parameters.AddWithValue("@Date", dateTime);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch
            {

            }

            return dt;

        }

        public DataTable GetAvailableStocksGraph(int ProductId, DateTime dateTime)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetProductAvialableStockDetailsforGraph", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", ProductId);
                cmd.Parameters.AddWithValue("@Date", dateTime);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return dt;


            }
            catch
            {

            }

            return dt;

        }

        public  int  RetrunPoNumber()
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmdPOId = new SqlCommand("Usp_GetLastPOId", MainClass.con);
                cmdPOId.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmdPOId);

                da.Fill(dt);


                if (dt.Rows.Count > 0)
                { return Convert.ToInt32(dt.Rows[0][0]) + 1; }
                else
                    return 1;

                


                


            }
            catch(Exception exp)
            {

            }
            return 1;
           
         
           
        }

        public int RetrunRecivId(int poNumber)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetRecivId", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PONumber", poNumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                if (dt.Rows.Count > 0)
                { return Convert.ToInt32(dt.Rows[0][0]) ; }
                else
                    return 1;







            }
            catch (Exception exp)
            {

            }
            return 1;



        }


        public int RetrunSalesNumber()
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmdPOId = new SqlCommand("Usp_GetLastSalesId", MainClass.con);
                cmdPOId.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmdPOId);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                { return Convert.ToInt32(dt.Rows[0][0]) + 1; }
                else
                    return 1;






            }
            catch (Exception exp)
            {

            }
            return 1;



        }

        public decimal GetPoGrossTotal(int poNumber)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetPOGrossPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PONumber", poNumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return Convert.ToDecimal(dt.Rows[0][0]) ;






            }
            catch (Exception exp)
            {

            }
            return Convert.ToDecimal(dt.Rows[0][0]);



        }


        public decimal GetSalesGrossTotal(int SalesNumber)
        {
            DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("Usp_GetSalesGrossPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SalesNumber", SalesNumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                return Convert.ToDecimal(dt.Rows[0][0]);






            }
            catch (Exception exp)
            {

            }
            return Convert.ToDecimal(dt.Rows[0][0]);



        }

        public DataSet GetOverAllReportDetails(int month, int productId)
        {
            DataSet ds = new DataSet("TimeRanges");
            try
            {

                SqlCommand sqlComm = new SqlCommand("usp_GetOverAllReportsStockInOut", MainClass.con);

                sqlComm.Parameters.AddWithValue("@productId", SqlDbType.Int).Value = productId;
                sqlComm.Parameters.AddWithValue("@month", SqlDbType.VarChar).Value = month;
              
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(ds);
                ds.Tables[0].TableName = "Stocks In";
                ds.Tables[1].TableName = "Stocks Out";
                ds.Tables[2].TableName = "Stocks OnHold";
                ds.Tables[3].TableName = "Stocks Rejected";
                ds.Tables[4].TableName = "Stocks Reworked";
                

                return ds;





            }
            catch (Exception exp)
            {

            }
            return ds;

        }




        public decimal GetProductProfit(int ProductId, DateTime dateTime)
        {
           DataTable dt = new DataTable();
            try
            {


                SqlCommand cmd = new SqlCommand("usp_GetProfitofProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", ProductId);
                cmd.Parameters.AddWithValue("@date", dateTime);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToDecimal(dt.Rows[0][0]);
                }






            }
            catch (Exception exp)
            {

            }
            return 0;
        }
    }

}
