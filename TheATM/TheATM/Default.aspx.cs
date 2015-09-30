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
           
            
            if (ATMHandler.CheckCardAndPIN(cardNumber, "1") == "Success")
            {
                Server.Transfer("MainATM.aspx?action=test");
            }
            else if (ATMHandler.CheckCardAndPIN(cardNumber, "1")=="Fail nr 1")
            {
                //Clear PIN textbox and update a label with an error message
            }else if (ATMHandler.CheckCardAndPIN(cardNumber, "1")=="Fail nr 2")
            {
                //Clear PIN textbox and update a label with an error message
            }
            else
            {
                //Print locked message
            }
           

        }
    }
}