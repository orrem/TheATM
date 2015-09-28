using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TheATM
{
    public class ATMHandler
    {
        #region Class Fields

        // Number of 100 SEK bills left in the ATM
        private int bill100;

        // Number of 500 SEK bills left in the ATM
        private int bill500;

        // Double to check whether there is enough paper to print a reciept left in the ATM
        private double receiptLength;

        // The connection to the "bank"
        private SqlConnection atmConnection;

        // A bool to indicate if the ATM is in working order or not
        private bool inWorkingOrder;
        #endregion

    }
}