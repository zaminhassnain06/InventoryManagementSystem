using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Transactions;

namespace InventoryManagementSystem
{
     public class Insertion
    {
       
        public  void SaveUserDetails(string name, string password,  string contactNumber, string email,int role)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_SaveUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = password;
          //      cmd.Parameters.AddWithValue("@Users_Type_Id", SqlDbType.Int).Value = Users_Type_Id;
                cmd.Parameters.AddWithValue("@ContactNumber", SqlDbType.VarChar).Value = contactNumber;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.AddWithValue("@Role", SqlDbType.VarChar).Value = role;
               
                int row = cmd.ExecuteNonQuery();
            
                if(row>0)
                {
                    MainClass.ShowMessage("Username '" + name + "' added Successfully. " , "Success", "Success");
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
        public void SaveCategoryDetails(string Name, Int16 IsSales)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_InsertCategories", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
                cmd.Parameters.AddWithValue("@IsSales", SqlDbType.TinyInt).Value = IsSales;
                
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Category: '" + Name + "' added Successfully. ", "Success", "Success");
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

        public void SaveProductDetails(string Name, string Code, decimal purchasePrice, string unit,decimal  MinValue,int categoryId,decimal salesPrice,bool showMessgae=false)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_SaveProductDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Name;
                cmd.Parameters.AddWithValue("@Code", SqlDbType.VarChar).Value = Code;
                cmd.Parameters.AddWithValue("@PurchasePrice", SqlDbType.Decimal).Value = purchasePrice;
                cmd.Parameters.AddWithValue("@Unit", SqlDbType.VarChar).Value = unit;              
                cmd.Parameters.AddWithValue("@MinimumValue", SqlDbType.Decimal).Value = MinValue;
                cmd.Parameters.AddWithValue("@CategoryID", SqlDbType.Int).Value = categoryId;
                cmd.Parameters.AddWithValue("@SalesPrice", SqlDbType.Decimal).Value = salesPrice;

                int row = cmd.ExecuteNonQuery();

                if (row > 0 && showMessgae)
                {
                    MainClass.ShowMessage("Product: '" + Name  + "' added Successfully. ", "Success", "Success");
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

        public void SaveSupplierDetails(string SupplierName,string SupplierCode,string SupplierContactNumber, string SupplierEmail, string Address,string SupplierCity,  string Country,string Payment,string DeliveryMethod,string DelLeadTime,decimal Deliveryleadtime)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_SaveSupplierDetails", MainClass.con);
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
                cmd.Parameters.AddWithValue("@DeliveryLeadTime", SqlDbType.VarChar).Value = Deliveryleadtime;



                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Supplier: '" + SupplierName + "' added Successfully. ", "Success", "Success");
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


        public void SaveCustomerDetails(string CustomerName, string CustomerCode, string CustomerContactNumber, string CustomerEmail, string Address, string CustomerCity, string Country, string Payment, string DeliveryMethod, string DelLeadTime, decimal Deliveryleadtime)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand("Usp_SaveCustomerDetails", MainClass.con);
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
                cmd.Parameters.AddWithValue("@DeliveryLeadTime", SqlDbType.VarChar).Value = Deliveryleadtime;



                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Customer: '" + CustomerName + "' added Successfully. ", "Success", "Success");
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


     private int POId=0;
         public int SavePO(int SupplierID, DateTime ExpectedDeliveryDate, decimal POGrossCost,int UserId,string POStatus=null)
        {
            try
            {

                using (TransactionScope tc=new TransactionScope() )
                {
                    MainClass.con.Open();

                    SqlCommand cmd = new SqlCommand("usp_Insert_PO", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", SqlDbType.Int).Value = SupplierID;
                    cmd.Parameters.AddWithValue("@ExpectedDeliveyDate", SqlDbType.Date).Value = ExpectedDeliveryDate;
                    cmd.Parameters.AddWithValue("@POGrossCost", SqlDbType.Decimal).Value = POGrossCost;
                    cmd.Parameters.AddWithValue("@POStatus", SqlDbType.Int).Value = 1;
                    cmd.Parameters.AddWithValue("@UserId", SqlDbType.Int).Value = UserId;

                    int row = cmd.ExecuteNonQuery();
                    SqlCommand cmdPOId = new SqlCommand("Usp_GetLastPOId", MainClass.con);
                    cmdPOId.CommandType = CommandType.StoredProcedure;
                    POId = Convert.ToInt32(cmdPOId.ExecuteScalar());
                    tc.Complete();
                    return POId;
                   

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
            return POId;
        }

         private int SalesId = 0;
         public int SaveSales(int CustomerId, decimal SalesGrossCost, int UserId, string SalesStatus = null)
         {
             try
             {

                 using (TransactionScope tc = new TransactionScope())
                 {
                     MainClass.con.Open();

                     SqlCommand cmd = new SqlCommand("usp_Insert_Sales", MainClass.con);
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@CustomerId", SqlDbType.Int).Value = CustomerId;

                     cmd.Parameters.AddWithValue("@SalesGrossCost", SqlDbType.Decimal).Value = SalesGrossCost;
                     cmd.Parameters.AddWithValue("@SalesStatus", SqlDbType.Int).Value = 1;
                     cmd.Parameters.AddWithValue("@UserId", SqlDbType.Int).Value = UserId;

                     int row = cmd.ExecuteNonQuery();
                     SqlCommand cmdSalesId = new SqlCommand("Usp_GetLastSalesId", MainClass.con);
                     cmdSalesId.CommandType = CommandType.StoredProcedure;
                     SalesId = Convert.ToInt32(cmdSalesId.ExecuteScalar());
                     tc.Complete();
                     return SalesId;


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
             return SalesId;
         }
         int SalesidCount = 0;
         int pidCount=0;
         public int SavePoLine(int PO_Id  ,int prodId, decimal price, decimal quantity, int POLineNumber,string Unit)
         {
             try
             {


                 MainClass.con.Open();

                 SqlCommand cmd = new SqlCommand("Usp_InsertPOLine", MainClass.con);



                 cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@PONumber", SqlDbType.Int).Value =PO_Id;
                     cmd.Parameters.AddWithValue("@ProductId",SqlDbType.Int).Value = prodId;
                     cmd.Parameters.AddWithValue("@LineNumber", SqlDbType.Int).Value =POLineNumber;
                     cmd.Parameters.AddWithValue("@POLineQuantity",SqlDbType.Decimal).Value = quantity;
                     cmd.Parameters.AddWithValue("@POLineTotalCost",SqlDbType.Decimal).Value = price;
                     cmd.Parameters.AddWithValue("@Unit", SqlDbType.VarChar).Value = Unit;
                      pidCount = cmd.ExecuteNonQuery();
                     return pidCount;
             }
             catch (Exception exp)
             {
                 MainClass.ShowMessage(exp.Message, "Error", "Error");

             }
             finally
             {
                 MainClass.con.Close();
             }

             return pidCount;
            
         }


         public int SaveSalesLine(int Sales_Id, int prodId, decimal price, decimal quantity,string Unit, int SalesLineNumber)
         {
             try
             {


                 MainClass.con.Open();

                 SqlCommand cmd = new SqlCommand("Usp_InsertSalesLine", MainClass.con);



                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@SalesNumber", SqlDbType.Int).Value = Sales_Id;
                 cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = prodId;
                 cmd.Parameters.AddWithValue("@LineNumber", SqlDbType.Int).Value = SalesLineNumber;
                 cmd.Parameters.AddWithValue("@SalesLineQuantity", SqlDbType.Decimal).Value = quantity;
                 cmd.Parameters.AddWithValue("@SalesLineTotalCost", SqlDbType.Decimal).Value = price;
                 cmd.Parameters.AddWithValue("@Unit", SqlDbType.VarChar).Value = Unit;

                 SalesidCount = cmd.ExecuteNonQuery();
                 return SalesidCount;
             }
             catch (Exception exp)
             {
                 MainClass.ShowMessage(exp.Message, "Error", "Error");

             }
             finally
             {
                 MainClass.con.Close();
             }

             return SalesidCount;

         }

         int RecvId = 0;
         public int SaveReceiving(int PONumber,  decimal ReceivingGrossCost)
         {
             try
             {

                 using (TransactionScope tc = new TransactionScope())
                 {
                     MainClass.con.Open();

                     SqlCommand cmd = new SqlCommand("usp_Insert_Receiving", MainClass.con);
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@PONumber", SqlDbType.Int).Value = PONumber;
                     cmd.Parameters.AddWithValue("@POGrossCost", SqlDbType.Decimal).Value = ReceivingGrossCost;
                     
                     int row = cmd.ExecuteNonQuery();
                     SqlCommand cmdRecvId = new SqlCommand("Usp_GetLastReceivingId", MainClass.con);
                     cmdRecvId.CommandType = CommandType.StoredProcedure;
                     RecvId = Convert.ToInt32(cmdRecvId.ExecuteScalar());
                     tc.Complete();
                     return RecvId;


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
             return RecvId;
         }

         int RecvIdCount = 0;
         public int SaveReceiveLine(int Rec_Id, int prodId, decimal price, decimal quantity, int POLineNumber)
         {
             try
             {


                 MainClass.con.Open();

                 SqlCommand cmd = new SqlCommand("Usp_InsertReceiveLine", MainClass.con);



                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@ReceiveId", SqlDbType.Int).Value = Rec_Id;
                 cmd.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = prodId;
                 cmd.Parameters.AddWithValue("@LineNumber", SqlDbType.Int).Value = POLineNumber;
                 cmd.Parameters.AddWithValue("@LineQuantity", SqlDbType.Decimal).Value = quantity;
                 cmd.Parameters.AddWithValue("@LineTotalCost", SqlDbType.Decimal).Value = price;

                 RecvIdCount = cmd.ExecuteNonQuery();
                 return RecvIdCount;
             }
             catch (Exception exp)
             {
                 MainClass.ShowMessage(exp.Message, "Error", "Error");

             }
             finally
             {
                 MainClass.con.Close();
             }

             return RecvIdCount;

         }
    }


}
