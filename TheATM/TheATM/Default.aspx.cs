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
            var connection = new SqlConnection(@"Data Source = localhost\sqlexpress;Initial Catalog=ATMDatabase;Integrated Security=SSPI");
            connection.Open();
            string checkCardNumber = $"select count(*) from UserTable where UserTable.CardNumber = @CardNumber";
            var command = new SqlCommand(checkCardNumber, connection);
            command.Parameters.Add(new SqlParameter("@CardNumber", TextBoxCardNumber.Text));
            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();


            if (temp == 1)
            {
                connection.Open();
                string checkPin = $"select PIN from UserTable where UserTable.CardNumber = @CardNumber";
                var PassCommand = new SqlCommand(checkPin, connection);
                PassCommand.Parameters.Add(new SqlParameter("@CardNumber", TextBoxCardNumber.Text));
                string pin = PassCommand.ExecuteScalar().ToString().Trim();

                if (pin == TextBoxPIN.Text)
                {
                    Session["Logged"] = TextBoxCardNumber.Text; //Holds the CardNumber(PK)
                    Response.Write("Logging in ..."); //Log in Passed
                    //Response.Redirect("MainPage.aspx");
                    //Server.Transfer("MainPage.aspx");
                }
                else
                {
                    Response.Write("Wrong PIN code"); //Log in Faild, wrong PIN
                }
            }
            else
            {
                Response.Write("CCN could Not be found"); //Wrong CardNumber, not in db(not supported?)
            }
        }
    }
}