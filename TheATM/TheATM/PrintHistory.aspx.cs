using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheATM
{
    public partial class PrintHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ATMHandler.TransactionHistory(25);
            ListBoxPrint.Items.Clear();
            List<String> historyList = (List<String>)HttpContext.Current.Session["transactionHistory"];
            foreach (string listPost in historyList)
            {
                ListBoxPrint.Items.Add(listPost);
            }
        }
    }
}