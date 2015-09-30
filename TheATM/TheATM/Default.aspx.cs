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
            string cardNumber = DropDownList1.SelectedValue.ToString();
            string pin = TextBoxPIN.Text;

            string result = ATMHandler.CheckCardAndPIN(cardNumber, pin);

            if (result == "Success")
            {
                Server.Transfer("MainATM.aspx?action=test");
            }
            else
            {
                TextBoxPIN.Text = "";
                LabelError.Text = result;
            }

        }
    }
}