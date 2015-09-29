using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TheATM
{
    public partial class ATM : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Logic is going to happen when button login exists
            for (int i = 1; i < 4; i++)
            {
                string cardNumber = "1"; // input from user
                ATMHandler.CheckCardAndPIN(cardNumber, "2111");

                int a = (int)HttpContext.Current.Session["userID"];

                if (a == Convert.ToInt32(cardNumber))
                {
                    string tries = $"{i}";
                    // Needs error label/message
                }
            }
            string message = "Fourth try, you're locked out";
        }
    }
}