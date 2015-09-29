using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheATM
{
    public class Account
    {
        #region Class fields


        #endregion

        /// <summary>
        /// Method to check the current balance of the user's account. Uses the ID from the session
        /// </summary>
        /// <returns></returns>
        public static double AccountBalance()
        {
            // Behöver kopplas till GUI för user input samt den aktuella sessionen som nu är hårdkodad till 1
            double balance;
            balance = SqlQuery.AccountBalance();
            return balance;
        }

        public static  TransactionHistory()
        {

        }

    }
}