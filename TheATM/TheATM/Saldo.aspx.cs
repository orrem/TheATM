using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheATM
{
	public partial class Saldo : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if(ATMHandler.AccountBalance() == "Success")
            {
                
                valueSaldoLabel.Text = ((double)HttpContext.Current.Session["balance"]).ToString();
            }
            ListBoxHistory.Items.Clear();
            ATMHandler.TransactionHistory(5);
            List<String> historyList = (List<String>)HttpContext.Current.Session["transactionHistory"];
                foreach (string listPost in historyList)
            {
                ListBoxHistory.Items.Add(listPost);
            }

        }

        protected void Button1_Click(object sender, EventArgs e) //TODO
        {
            Server.Transfer("MainATM.aspx?action=test");
        }

        protected void OKJa_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenWindow", "window.open('PrintHistory.aspx', '_newtab');", true);

            
        }

        protected void ButtonSaldoToUttag_Click(object sender, EventArgs e)
        {
            Server.Transfer("Withdrawl.aspx");
        }
    }
}