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
            Server.Transfer("Default.aspx");
        }

        protected void Accept_Click(object sender, EventArgs e)
        {

        }

        protected void withdrawl_200_TextChanged(object sender, EventArgs e)
        {

        }
    }
}