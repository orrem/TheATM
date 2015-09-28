using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheATM
{
    public static class ATMController
    {
        #region Class Fields
        #endregion

        #region Methods
        public static string InitATM(string inputString)
        {
            // Nu är inputString = 2

            SqlQuery.FromDatabase($"select count(*) from [User] where CardNumber = @CardNumber", inputString);
            // string checkCardNumber = $"select count(*) from [User] where CardNumber = @CardNumber";

            return inputString;
            //if (temp == 1)
            //{
            //    connection.Open();
            //    string checkPin = $"select PIN from [User] where CardNumber = @CardNumber";
            //    var PassCommand = new SqlCommand(checkPin, connection);
            //    PassCommand.Parameters.Add(new SqlParameter("@CardNumber", TextBoxCardNumber.Text));
            //    string pin = PassCommand.ExecuteScalar().ToString().Trim();

            //    if (pin == TextBoxPIN.Text)
            //    {
            //        Session["Logged"] = TextBoxCardNumber.Text; //Holds the CardNumber(PK)
            //        Response.Write("Logging in ..."); //Log in Passed
            //        //Response.Redirect("MainPage.aspx");
            //        //Server.Transfer("MainPage.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("Wrong PIN code"); //Log in Faild, wrong PIN
            //    }
            //}
            //else
            //{
            //    Response.Write("CardNumber could Not be found"); //Wrong CardNumber, not in db(not supported?)
            //}
        }

        //private int PINCheck(int pin)
        //{


        //}
        #endregion
    }
}