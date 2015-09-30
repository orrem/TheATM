using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheATM
{
    public partial class MainATM : System.Web.UI.Page
    {

        private string action = "";


        protected void Page_Load(object sender, EventArgs e)
        {
                if (Request["action"] != null)
                {
                    this.action = Request["action"].ToString().ToLower();
                    if (this.action == "test")
                    {
                        GotoMainMenu(action);
                    }
                }

            else
            {
                Server.Transfer("Default.aspx");
            }
        }

        private void GotoMainMenu(string action)
        {
            ATMController myControl = (ATMController)LoadControl("~/ATMController.ascx");
            myControl.InitAtmForm(action);
            PanelForm.Controls.Add(myControl);
        }
    }


}
