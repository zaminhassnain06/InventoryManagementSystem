using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace InventoryManagementSystem
{
    class Updation
    {

        public  void  UpdateUserDetails(string name, string password, string contactNumber, string email, int usersId, int role)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_EditUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = password;
             
                cmd.Parameters.AddWithValue("@ContactNumber", SqlDbType.VarChar).Value = contactNumber;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
               
                cmd.Parameters.AddWithValue("@UserId", SqlDbType.Int).Value = usersId;
                cmd.Parameters.AddWithValue("@Role", SqlDbType.Int).Value = role;

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Username '" + name + "' updated Successfully. ", "Success", "Success");
                }

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }

        public void UpdateCategoryDetails(string Name, Int16 IsSales,int id)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_EditCategoryDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
                cmd.Parameters.AddWithValue("@IsSales", SqlDbType.TinyInt).Value = IsSales;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
           

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Category: '" + Name + "' updated Successfully. ", "Success", "Success");
                }

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }
        public void UpdatePOStatus(int PONumber,int POStatus)
        {
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_UpdatePOStatus", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PoNumber", SqlDbType.Int).Value = PONumber;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = POStatus;
            


                int row = cmd.ExecuteNonQuery();

                

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }

        public void UpdateIncreaseAvailableStocks(int ProductId, decimal quantity, DateTime Date)
        {
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_IncreaseStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = Date;



                int row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }

        public void UpdateIncreaseInReworkedStocks(int ProductId, decimal quantity, DateTime date)
        {
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_IncreaseInReworkedStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.Decimal).Value = date;



                int row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }


        public int UpdateResolveInReworkedStocks(int ProductId, decimal quantity, DateTime date)
        {
            int row = 0;
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_ResolveInReworkedStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.Decimal).Value = date;



                 row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

            return row;
        }
        public void UpdateIncreaseInOnHoldStocks(int ProductId, decimal quantity, DateTime date)
        {
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_IncreaseInOnHoldStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = date;



                int row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }

        public int UpdateResolveInOnHoldStocks(int ProductId, decimal quantity, DateTime date)
        {
            int row = 0;
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_ResolveOnHoldStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = date;



                 row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }
            return row;

        }
        public void UpdateIncreaseRejectedStocks(int ProductId, decimal quantity, DateTime date)
        {
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_IncreaseInRejectedStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = date;


                int row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }

        public int UpdateIResolveRejectedStocks(int ProductId, decimal quantity, DateTime date)
        {
            int row = 0;
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_ResolveRejectedStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = date;



                 row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }
            return row;
        }
        public int UpdateDecreaseAvailableStocks(int ProductId, decimal quantity)
        {
            int row = 0;
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_DecreaseStocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;



                 row = cmd.ExecuteNonQuery();
                return row;
              
            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }
            return row;
        }

        public int UpdateDecreaseAvailableStocks(int ProductId, decimal quantity,DateTime Date)
        {
            int row = 0;
            try
            {
                //status=1 for sent //status==2 for received

                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_DecreaseStocksbyDateStockOut", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = Date;



                row = cmd.ExecuteNonQuery();
                return row;

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }
            return row;
        }

        public void UpdateProductDetails(string Name, string Code, decimal purchasePrice, string unit,  decimal MinValue, int categoryId,int productId, decimal salesPrice)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_EditProductDetail", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", SqlDbType.VarChar).Value = Code;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
                cmd.Parameters.AddWithValue("@PurchasePrice", SqlDbType.Decimal).Value = purchasePrice;
                cmd.Parameters.AddWithValue("@Unit", SqlDbType.VarChar).Value = unit;              
                cmd.Parameters.AddWithValue("@MinimumValue", SqlDbType.Decimal).Value = MinValue;
                cmd.Parameters.AddWithValue("@CategoryID", SqlDbType.Int).Value = categoryId;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = productId;
                cmd.Parameters.AddWithValue("@SalesPrice", SqlDbType.Decimal).Value = salesPrice;


               
             
               
                


                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Product: '" + Name + "' updated Successfully. ", "Success", "Success");
                }

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }

        public void UpdateSupplierDetails(string SupplierName,string SupplierCode,string SupplierContactNumber, string SupplierEmail, string Address,string SupplierCity,  string Country,string Payment,string DeliveryMethod,string DelLeadTime,decimal Deliveryleadtime, int SupplierId)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_EditSupplierDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = SupplierName;
                cmd.Parameters.AddWithValue("@Code", SqlDbType.VarChar).Value = SupplierCode;
                cmd.Parameters.AddWithValue("@ContactNumber", SqlDbType.Int).Value = SupplierContactNumber;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = SupplierEmail;
                cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address;
                cmd.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = SupplierCity;
                cmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = Country;
                cmd.Parameters.AddWithValue("@PaymentMethod", SqlDbType.VarChar).Value = Payment;
                cmd.Parameters.AddWithValue("@DeliveryMethod", SqlDbType.VarChar).Value = DeliveryMethod;
                cmd.Parameters.AddWithValue("@DeliveryLeadTime", SqlDbType.Decimal).Value = Deliveryleadtime;
                cmd.Parameters.AddWithValue("@SupplierId", SqlDbType.Int).Value = SupplierId;

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Supplier : '" + SupplierName + "' updated Successfully. ", "Success", "Success");
                }

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }


        public void UpdateCustomerDetails(string CustomerName, string CustomerCode, string CustomerContactNumber, string CustomerEmail, string Address, string CustomerCity, string Country, string Payment, string DeliveryMethod, string DelLeadTime, decimal Deliveryleadtime, int CustomerId)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_EditCustomerDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = CustomerName;
                cmd.Parameters.AddWithValue("@Code", SqlDbType.VarChar).Value = CustomerCode;
                cmd.Parameters.AddWithValue("@ContactNumber", SqlDbType.Int).Value = CustomerContactNumber;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = CustomerEmail;
                cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address;
                cmd.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = CustomerCity;
                cmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = Country;
                cmd.Parameters.AddWithValue("@PaymentMethod", SqlDbType.VarChar).Value = Payment;
                cmd.Parameters.AddWithValue("@DeliveryMethod", SqlDbType.VarChar).Value = DeliveryMethod;
                cmd.Parameters.AddWithValue("@DeliveryLeadTime", SqlDbType.Decimal).Value = Deliveryleadtime;
                cmd.Parameters.AddWithValue("@CustomerId", SqlDbType.Int).Value = CustomerId;

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Customer : '" + CustomerName + "' updated Successfully. ", "Success", "Success");
                }

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }
        public void UpdatePODetails(int PO_Id, int prodId, decimal price, decimal quantity, int POLineNumber)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_UpatePOLinesDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PONumber", SqlDbType.Int).Value = PO_Id;
                cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = prodId;
                cmd.Parameters.AddWithValue("@LineNumber", SqlDbType.Int).Value = POLineNumber;
                cmd.Parameters.AddWithValue("@POLineQuantity", SqlDbType.Decimal).Value = quantity;
                cmd.Parameters.AddWithValue("@POLineTotalCost", SqlDbType.Decimal).Value = price;

              

                int row = cmd.ExecuteNonQuery();

                

            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }

        public void UpdatePOPrice(int PO_Id,  decimal price)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_UpatePOPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PoNumber", SqlDbType.Int).Value = PO_Id;
                cmd.Parameters.AddWithValue("@Price", SqlDbType.Decimal).Value = price;

                // pidCount = cmd.ExecuteNonQuery();
                // return pidCount;

                int row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }

        }


        public void UpdateStockDailyStatus()
        {

            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_UpateAllStocksDayUpdate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                int row = cmd.ExecuteNonQuery();



            }
            catch (Exception exp)
            {
                MainClass.ShowMessage(exp.Message, "Error", "Error");

            }
            finally
            {
                MainClass.con.Close();
            }
        }
    }
}
