using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TheATM
{
    public class SqlQuery
    {

        #region Class fields
        private static SqlConnection atmConnection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Atm;Integrated Security=SSPI");
        private static SqlCommand atmCommand = new SqlCommand("", atmConnection);
        private static SqlDataReader myReader = null;

        #endregion

        #region Methods

        /// <summary>
        /// Method to check for pin and card number
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="cardNumber"></param>
        /// <param name="PIN"></param>
        /// <returns></returns>
        public static string CheckCardAndPIN(string cardNumber, string PIN)
        {
            try
            {
                atmCommand = new SqlCommand("sp_loginCheck", atmConnection);
                atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmConnection.Open();

                atmCommand.Parameters.Clear();

                atmCommand.Parameters.AddWithValue("@cardNumber", Convert.ToInt32(cardNumber));
                atmCommand.Parameters.AddWithValue("@pin", Convert.ToInt32(PIN));
                atmCommand.Parameters.AddWithValue("@userID", 0).Direction = System.Data.ParameterDirection.Output;
                atmCommand.Parameters.AddWithValue("@message", "");
                //atmCommand.Parameters.AddWithValue("@result", "").Direction = System.Data.ParameterDirection.Output;
                SqlParameter result = new SqlParameter
                {
                    ParameterName = "@result",
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = "",
                    Size = 50
                };
                atmCommand.Parameters.Add(result);

                atmCommand.ExecuteNonQuery();

                if ((string)atmCommand.Parameters["@result"].Value != "Locked")
                {
                    HttpContext.Current.Session["userID"] = atmCommand.Parameters["@userID"].Value;
                }

                //return (string)atmCommand.Parameters["@result"].Value;
                return result.Value as string;
            }
            catch (Exception ex)
            {
                return "Error";
            }
            finally
            {
                atmConnection.Close();
            }
        }

        public static string WithdrawMoney(int amount)
        {
            //string result = "";
            atmCommand.Parameters.Clear();
            try
            {
                atmConnection.Open();
                atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmCommand.CommandText = "sp_withdraw";
                atmCommand.Parameters.AddWithValue("@withdrawal", amount);
                atmCommand.Parameters.AddWithValue("@userID", (int)HttpContext.Current.Session["userID"]);
                //atmCommand.Parameters.AddWithValue("@result", result).Direction = System.Data.ParameterDirection.Output;
                atmCommand.Parameters.AddWithValue("@accountID", 0); //Just a value, will be set and only used in a stored procedure, irrelevant
                atmCommand.Parameters.AddWithValue("@message", ""); //Just a value, will be set and only used in a stored procedure, irrelevant
                atmCommand.Parameters.AddWithValue("@newBalance", 0); //Just a value, will be set and only used in a stored procedure, irrelevant
                atmCommand.Parameters.AddWithValue("@balance", 0); //Just a value, will be set and only used in a stored procedure, irrelevant
                SqlParameter result = new SqlParameter
                {
                    ParameterName = "@result",
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = "",
                    Size = 50
                };
                atmCommand.Parameters.Add(result);

                atmCommand.ExecuteNonQuery();

                //result = (string)atmCommand.Parameters["@result"].Value;

                return result.Value as string;
            }
            catch (Exception ex)
            {

                return "Error";
            }
            finally
            {
                atmConnection.Close();
            }
        }

        public static double AccountBalance()
        {
            try
            {
                atmCommand = new SqlCommand("sp_checkBalance", atmConnection);
                atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmConnection.Open();

                atmCommand.Parameters.Clear();

                atmCommand.Parameters.AddWithValue("@userID", 1);
                atmCommand.Parameters.AddWithValue("@accountID", 0); //Is set in the stored procedure
                atmCommand.Parameters.AddWithValue("@message", "");
                atmCommand.Parameters.AddWithValue("@balance", 0.0000).Direction = System.Data.ParameterDirection.Output;

                SqlParameter result = new SqlParameter
                {
                    ParameterName = "@result",
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = "",
                    Size = 50
                };
                atmCommand.Parameters.Add(result);

                atmCommand.ExecuteNonQuery();

                if ((string)atmCommand.Parameters["@result"].Value == "Success")
                {
                    HttpContext.Current.Session["balance"] = atmCommand.Parameters["@balance"].Value;

                    return (double)atmCommand.Parameters["@balance"].Value;
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

                //return ;
            }
            finally
            {
                atmConnection.Close();
            }
            return (double)atmCommand.Parameters["@balance"].Value;

        }

        public static void TransactionHistory(int numberOfTransactions)
        {

            try
            {
                atmCommand = new SqlCommand("sp_displayTransactions", atmConnection);
                atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmConnection.Open();

                atmCommand.Parameters.Clear();

                atmCommand.Parameters.AddWithValue("@userID", 1);
                atmCommand.Parameters.AddWithValue("@accountID", 0); //Is set in the stored procedure
                atmCommand.Parameters.AddWithValue("@numberOfTransactions", numberOfTransactions);
                atmCommand.Parameters.AddWithValue("@message", ""); // Is set in the stored procedure
                atmCommand.Parameters.AddWithValue("@result", ""); // Is set in the stored procedure

                atmCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(atmCommand);

                da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    // Hur ska vi skriva ut datan. Får ut allt vi ska med senaste ändring först.
                    var check = item.ItemArray;

                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                atmConnection.Close();
            }
        }
        #endregion
    }
}