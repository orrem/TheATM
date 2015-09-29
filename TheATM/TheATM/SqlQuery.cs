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
        private static SqlConnection atmConnection;
        private static SqlCommand atmCommand;
        private static SqlDataReader myReader = null;
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Atm;Integrated Security=SSPI";

        public static object Response { get; private set; }
        #endregion

        #region Methods

        public static void ReadFromSQLDatabase(string inputString)
        {
            atmConnection = new SqlConnection(connectionString);
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
            atmConnection = new SqlConnection(connectionString);

            try
            {
                atmCommand = new SqlCommand(storedProcedure, atmConnection);
                atmConnection.Open();
                atmCommand.CommandText = storedProcedure;
                //atmCommand.CommandType = System.Data.CommandType.StoredProcedure;
                atmCommand.Parameters.Clear();

                atmCommand.Parameters.AddWithValue("@CardNumber", inputString));
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

        #endregion
    }
}