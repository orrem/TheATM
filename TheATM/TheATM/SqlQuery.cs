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
        private static SqlCommand atmCommand;
        private static SqlDataReader myReader = null;
        

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
               
            }
            finally
            {
                if (myReader != null) myReader.Close();
                if (atmConnection != null) atmConnection.Close();
            }
        }

        public static void FromDatabase(string storedProcedure, string inputString)
        {
            try
            {
                atmCommand = new SqlCommand(storedProcedure, atmConnection);
                atmConnection.Open();
                atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmCommand.CommandText = storedProcedure;
              
                atmCommand.Parameters.Clear();


            }
            catch (Exception ex)
            {
               // Response.Write(ex.Message.ToString);
            }
            finally
            {
                atmConnection.Close();
            }
        }

        /// <summary>
        /// Method to check for pin and card number
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="cardNumber"></param>
        /// <param name="PIN"></param>
        /// <returns></returns>
        public static string FromDatabase(string storedProcedure, string cardNumber, string PIN)
        {
            try
            {
                atmCommand = new SqlCommand(storedProcedure, atmConnection);
                atmConnection.Open();
                atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmCommand.CommandText = storedProcedure;

                atmCommand.Parameters.Clear();

                atmCommand.Parameters.AddWithValue("@cardNumber", Convert.ToInt32(cardNumber));
                atmCommand.Parameters.AddWithValue("@pin", Convert.ToInt32(PIN));
                atmCommand.Parameters.AddWithValue("@userID", 0).Direction = System.Data.ParameterDirection.Output; 
                atmCommand.Parameters.AddWithValue("@message", ""); 
                atmCommand.Parameters.AddWithValue("@result", "").Direction = System.Data.ParameterDirection.Output;
                
                atmCommand.ExecuteNonQuery();

                HttpContext.Current.Session["userID"] = atmCommand.Parameters["@userID"].Value; 
                

            }
            catch (Exception ex)
            {

                // Måste göra så att programmet förstår att det inte finns en user med matchande pin och kort
                // därefter skicka tillbaka användaren till login-sidan
            }
            finally
            {
                atmConnection.Close();
            }
            return "";
        }

        #endregion
    }
}