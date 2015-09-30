using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheATM
{
    public static class ATMHandler
    {
        #region Class Fields

        // Number of 100 SEK bills left in the ATM
        private static int bill100;

        // Number of 500 SEK bills left in the ATM
        private static int bill500;

        // Double to check whether there is enough paper to print a reciept left in the ATM
        private static double receiptLength;

        // The connection to the "bank"
       // private SqlConnection atmConnection;

        // A bool to indicate if the ATM is in working order or not
        private static bool inWorkingOrder;
        #endregion

        #region Methods
        public static string CheckCardAndPIN(string cardNumber, string PIN)
        {
           string result = SqlQuery.CheckCardAndPIN(cardNumber, PIN);

            switch (result)
            {
                case "Locked":
                    return "Ditt kort är spärrat. Kontakta din bank.";

                case "Fail nr 1":
                    return "FEL PIN, två försök kvar";

                case "Fail nr 2":
                    return "FEL PIN!!!! Sista försöket innan ditt kort spärras";

                case "Success":
                    return "Success";

                default:
                    return "oops";
            }

        }
        
        public static void BillsInMachine()
        {

        }

        private static void BillCheck()
        {

        }

        public static void ReceiptPaperCheck()
        {

        }

        public static void ConnectionCheck()
        {

        }

        public static void InWorkingOrderCheck()
        {

        }

        public static void ExitATM()
        {

        }
        #endregion

    }
}