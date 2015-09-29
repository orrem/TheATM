using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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