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
            if (Session["userID"] != null)
            {
                GotoMainATM(action);
            }
            else
            {
                Server.Transfer("Default.aspx");
            }
        }

        private void GotoMainATM(string action)
        {
            ATMController myControl = (ATMController)LoadControl("~/ATMController.ascx");
            myControl.InitAtmForm(action);
            PanelForm.Controls.Add(myControl);
        }
    }


}

//private string action = "";
//private int id = 0;

//protected void Page_Load(object sender, EventArgs e)
//{
//    if (Request["id"] != null)
//    {
//        Regex myRegEx = new Regex("^[0-9]+$");
//        if (!myRegEx.Match(Request["id"]).Success)
//        {
//            LabelError.Text = "ID value is not valid";
//        }
//        else
//        {
//            try
//            {
//                this.id = Convert.ToInt32(Request["id"]);
//            }
//            catch (Exception ex)
//            {
//                LabelError.Text = ex.Message;
//            }
//        }
//    }

//    if (Request["action"] != null)
//    {
//        this.action = Request["action"].ToString().ToLower();

//        if (this.action == "add")
//        {
//            AddContact(id);
//        }
//        else if (this.action == "find")
//        {

//        }
//        else if (this.action == "delete")
//        {

//        }
//        else if (this.action == "update")
//        {
//            UpdateContact(id);
//        }
//        else
//        {
//            LabelError.Text = "Unknown action.";
//        }
//    }
//}

//private void UpdateContact(int id)
//{
//    ContactControl myControl = (ContactControl)LoadControl("~/Controls/ContactControl.ascx");
//    myControl.InitContactForm(action, id);
//    PanelForm.Controls.Add(myControl);
//}

//private void AddContact(int id)
//{
//    ContactControl myControl = (ContactControl)LoadControl("~/Controls/ContactControl.ascx");
//    myControl.InitContactForm(action);
//    PanelForm.Controls.Add(myControl);
//}