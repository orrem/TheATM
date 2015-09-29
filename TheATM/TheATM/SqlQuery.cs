using System;
using System.Collections.Generic;
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
        //<---- atmCommand.Connection = atmConnection; should go here!
        
        private static SqlDataReader myReader = null;
        
        public static object Response { get; private set; }
        #endregion

        #region Methods

        public static void ReadFromSQLDatabase(string inputString)
        {
            try
            {
                atmConnection.Open();

                atmCommand = new SqlCommand(inputString, atmConnection);
                atmCommand.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                // Code goes here
            }
            finally
            {
                if (myReader != null) myReader.Close();
                if (atmConnection != null) atmConnection.Close();
            }
        }

        public static void FromDatabase(string storedProcedure, string inputString)
        {
            int temp;

            try
            {
                atmCommand = new SqlCommand(storedProcedure, atmConnection);
                atmConnection.Open();
                atmCommand.CommandText = storedProcedure;
                //atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmCommand.Parameters.Clear();

                atmCommand.Parameters.AddWithValue("@CardNumber", inputString);
                temp = Convert.ToInt32(atmCommand.ExecuteScalar().ToString());


            }
            catch (Exception ex)
            {
                //Response.Write(ex.Message.ToString);
            }
            finally
            {
                if (atmConnection != null) atmConnection.Close();
            }
            // return temp;
        }
        
        public static string WithdrawMoney(int amount)
        {
            string result = "";
            try {
                atmConnection.Open();
                atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmCommand.CommandText = "sp_withdraw";
                atmCommand.Parameters.AddWithValue("@withdrawal", amount);
                atmCommand.Parameters.AddWithValue("@userID", (int)HttpContext.Current.Session["userID"] );
                atmCommand.Parameters.AddWithValue("@result", result).Direction = System.Data.ParameterDirection.Output;
                atmCommand.Parameters.AddWithValue("@accountID", 0); //Just a value, will be set and only used in a stored procedure, irrelevant
                atmCommand.Parameters.AddWithValue("@message", ""); //Just a value, will be set and only used in a stored procedure, irrelevant
                atmCommand.Parameters.AddWithValue("@newBalance", 0); //Just a value, will be set and only used in a stored procedure, irrelevant
                atmCommand.Parameters.AddWithValue("@balance", 0); //Just a value, will be set and only used in a stored procedure, irrelevant
                atmCommand.ExecuteNonQuery();

                result = (string)atmCommand.Parameters["@result"].Value;

                return result;
            }catch(Exception ex)
            {

                return "Error";
            }
            finally
            {
                atmConnection.Close();
            }
        }
        #endregion
    }
}