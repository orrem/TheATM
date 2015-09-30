using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TheATM
{
    public partial class ATMController : System.Web.UI.UserControl
    {

        private string action;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void InitAtmForm(string action)
        {
            this.action = action;

            if (action == "test") //TODO
            {
                SetMainMenu();
            }

        }

        private void SetMainMenu()
        {
            KontoKvitto.Visible = false;
            SaldoKonto.Text = "Saldo";
            VisaHistorik.Visible = false;
            PrintKvitto.Visible = false;
            UttagPrintKvitto.Text = "Uttag";
            Uttag.Visible = false;
            AvslutaNej.Text = "Avsluta";
            OKJa.Visible = false;

        }

        private void SetInSaldo() //Not yet in use
        {
            KontoKvitto.Visible = true;
            SaldoKonto.Visible = false;
            VisaHistorik.Text = "View the last 5 transactions";
            PrintKvitto.Text = "print the last 25 transactions";
            UttagPrintKvitto.Text = "Uttag";
            Uttag.Visible = false;
            AvslutaNej.Text = "Avsluta";
            OKJa.Visible = false;

        }

        protected void UttagPrintKvitto_Click(object sender, EventArgs e)
        {
            Server.Transfer("Withdrawl.aspx");
        }

        protected void SaldoKonto_Click(object sender, EventArgs e)
        {
            Server.Transfer("Saldo.aspx");
        }

        protected void AvslutaNej_Click(object sender, EventArgs e)
        {
            ATMHandler.ExitATM();
            Server.Transfer("Default.aspx");
        }
    }
}




