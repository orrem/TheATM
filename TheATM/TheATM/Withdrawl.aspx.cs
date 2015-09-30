using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheATM
{
    public partial class Withdrawl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Exit_Click(object sender, EventArgs e)
        {
            Server.Transfer("MainATM.aspx?action=test");
        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            string result = ATMHandler.WithdrawMoney(textBoxWithdrawal.Text);
            if(result == "Not Divisible by 100")
            {
                textBoxWithdrawal.Text = "Kan bara ta ut jämna hundratal";
            }else if( result == "Not an integer")
            {
                textBoxWithdrawal.Text = "Kan bara ta ut pengar. Inte bokstäver/tecken.";

            }
            else if(result == "Error")
            {
                textBoxWithdrawal.Text = "Error. Kolla ditt saldo/kontakta din bank";
            }
            else
            {
                Server.Transfer("successfulWithdrawal.aspx");
            }
        }

        protected void withdrawal_button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            string result = ATMHandler.WithdrawMoney(button.Text);
            if (result == "Error")
            {
                textBoxWithdrawal.Text = "Error. Kolla ditt saldo/kontakta din bank";
            }
            else if(result == "Tried withdrawing 10k+ in 24h")
            {
                textBoxWithdrawal.Text = "Får inte ta ut 10k eller mer per 24h";
            }
            else if(result == "Tried withdrawing 5k+")
            {
                textBoxWithdrawal.Text = "Får inte ta ut över 5k per uttag";
            }
            else
            {
                Server.Transfer("successfulWithdrawal.aspx");
            }
        }
    }
}