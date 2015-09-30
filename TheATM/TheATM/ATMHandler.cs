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

        public static string WithdrawMoney(string amount)
        {
            return SqlQuery.WithdrawMoney(amount);
            
        }
        public static string AccountBalance()
        {

            return SqlQuery.AccountBalance();
        }

        public static void TransactionHistory(int numberOfTransactions)
        {

            SqlQuery.TransactionHistory(numberOfTransactions);
        }
        public static void ExitATM()
        {
            ATMFunction.ExitATM();
        }
        #endregion

    }
}