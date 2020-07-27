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
    class Deletion
    {
        public  void DeleteDetails(object id, string proc, string param)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);//.Value = id;

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Data deleted Successfully. ", "Success", "Success");
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

        public void Deletewith4Params( string proc, string param1, string param2,string param3 , string param4, object param1Value,object param2Value,object param3Value, object param4Value)
        {
            try
            {


                MainClass.con.Open();

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, param1Value);
                cmd.Parameters.AddWithValue(param2, param2Value);
                cmd.Parameters.AddWithValue(param3, param3Value);
                cmd.Parameters.AddWithValue(param4, param4Value);

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MainClass.ShowMessage("Data deleted Successfully. ", "Success", "Success");
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
    }
}
