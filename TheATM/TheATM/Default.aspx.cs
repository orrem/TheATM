using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TheATM
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string cardNumber = "1"; // input from user
            ATMHandler.CheckCardAndPIN(cardNumber, "1");

            //int a = (int)HttpContext.Current.Session["userID"];
            //{// Logic is going to happen when button login exists
            //    for (int i = 1; i < 4; i++)
            //    {



            //        // måste gå in och fixa så att detta bara sker när man skriver fel kod.
            //        if (a == Convert.ToInt32(cardNumber))
            //        {
            //            string tries = $"{i}";
            //            // Needs error label/message
            //        }
            //    }
            //    string message = "Fourth try, you're locked out";
            //}

        }
    }
}