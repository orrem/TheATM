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
            else if (action == "bo") //TODO 
            {

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

        private void SetInSaldo() //After you choose an account
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
    }
}



//        public void InitContactForm(string action, int id = 0)
//        {
//            this.action = action;
//            this.id = id;

//            if (action == "add")
//            {
//                SetAddMode();
//            }
//            else if (action == "update")
//            {
//                if (id != 0)
//                    SetUpdateMode();
//                else
//                {
//                    SetLockedMode();
//                   // LabelError.Text = "No valid ID was given.";
//                }
//            }
//        }

//        private void SetLockedMode(bool setLock = false)
//        {
//            foreach (var control in this.Controls)
//                if (control is TextBox)
//                    ((TextBox)control).Enabled = setLock;
//                else if (control is Button)
//                    ((Button)control).Enabled = setLock;

//        }

//        protected void ButtonClicked(object sender, EventArgs e)
//        {
//            if (Page.IsValid)
//            {
//                if (this.action == "login")
//                {
//                    AddContact();
//                }
//                else if (this.action == "update")
//                {
//                    if (TextBoxFirstname.Text == "" && TextBoxLastname.Text == "" && TextBoxSSN.Text == "")
//                        GetContact();
//                    else
//                        UpdateContact();
//                }
//            }
//            else
//            {
//                if (this.action == "update")
//                    GetContact();
//            }
//        }

//        private void GetContact()
//        {
//            SqlConnection myConnection = new SqlConnection();
//            myConnection.ConnectionString = sqlConnectionString;
//            SqlDataReader myReader = null;

//            try
//            {
//                myConnection.Open();
//                SqlCommand myCommand = new SqlCommand();
//                myCommand.Connection = myConnection;
//                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
//                myCommand.CommandText = "sp_GetContact";

//                myCommand.Parameters.Add("@ContactID", System.Data.SqlDbType.Int);
//                myCommand.Parameters["@ContactID"].Value = id;

//                myReader = myCommand.ExecuteReader();
//                myReader.Read();
//                if (!myReader.HasRows)
//                {
//                    SetLockedMode();
//                    LabelError.Text = $"No contact with ID {id} could be found.";
//                }
//                else if (myReader["CID"] != null)
//                {
//                    SetLockedMode(true);
//                    TextBoxFirstname.Text = myReader["FirstName"].ToString();
//                    TextBoxLastname.Text = myReader["LastName"].ToString();
//                    TextBoxSSN.Text = myReader["SSN"].ToString();
//                    LabelIDValue.Text = myReader["CID"].ToString();
//                    Session["CID"] = myReader["CID"];
//                }
//            }
//            catch (Exception ex)
//            {
//                LabelError.Text = ex.Message;
//            }
//            finally
//            {
//                if (myReader != null) myReader.Close();
//                if (myConnection != null) myConnection.Close();
//            }
//        }

//        private void UpdateContact()
//        {
//            SqlConnection myConnection = new SqlConnection();
//            myConnection.ConnectionString = sqlConnectionString;

//            try
//            {
//                myConnection.Open();
//                SqlCommand myCommand = new SqlCommand();
//                myCommand.Connection = myConnection;
//                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
//                myCommand.CommandText = "sp_UpdateContact";

//                myCommand.Parameters.AddWithValue("@FirstName", TextBoxFirstname.Text);
//                myCommand.Parameters.AddWithValue("@LastName", TextBoxLastname.Text);
//                myCommand.Parameters.AddWithValue("@SSN", TextBoxSSN.Text);

//                myCommand.Parameters.Add("@ContactID", System.Data.SqlDbType.Int);
//                myCommand.Parameters["@ContactID"].Value = Session["CID"];

//                myCommand.ExecuteNonQuery();
//                if (myCommand.Parameters["@ContactID"].Value != null)
//                {
//                    LabelInfo.Text = $"Contact {TextBoxFirstname.Text}, {TextBoxLastname.Text} updated successfully!";
//                }
//            }
//            catch (Exception ex)
//            {
//                LabelError.Text = ex.Message;
//            }
//            finally
//            {
//                if (myConnection != null) myConnection.Close();
//            }
//        }

//        private void AddContact()
//        {
//            SqlConnection myConnection = new SqlConnection();
//            myConnection.ConnectionString = sqlConnectionString;
//            SqlDataReader myReader = null;

//            try
//            {
//                myConnection.Open();
//                SqlCommand myCommand = new SqlCommand();
//                myCommand.Connection = myConnection;
//                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
//                myCommand.CommandText = "sp_AddContact";

//                myCommand.Parameters.AddWithValue("@FirstName", TextBoxFirstname.Text);
//                myCommand.Parameters.AddWithValue("@LastName", TextBoxLastname.Text);
//                myCommand.Parameters.AddWithValue("@SSN", TextBoxSSN.Text);

//                myCommand.Parameters.Add("@ContactID", System.Data.SqlDbType.Int);
//                myCommand.Parameters["@ContactID"].Direction = System.Data.ParameterDirection.Output;

//                myCommand.ExecuteNonQuery();
//                if (myCommand.Parameters["@ContactID"].Value != null)
//                {
//                    LabelInfo.Text = $"Contact {TextBoxFirstname.Text}, {TextBoxLastname.Text} added successfully!";
//                    TextBoxFirstname.Text = "";
//                    TextBoxLastname.Text = "";
//                    TextBoxSSN.Text = "";
//                }
//            }
//            catch (Exception ex)
//            {
//                LabelError.Text = ex.Message;
//            }
//            finally
//            {
//                if (myReader != null) myReader.Close();
//                if (myConnection != null) myConnection.Close();
//            }
//        }

//        private void SetAddMode()
//        {
//            Button.Text = "Add";
//            LabelTitle.Text = "Add contact";
//            LabelID.Visible = false;
//            LabelIDValue.Visible = false;
//        }

//        private void SetUpdateMode()
//        {
//            SetLockedMode(true);
//            Button.Text = "Update";
//            LabelTitle.Text = "Update contact";
//            LabelID.Visible = true;
//            LabelIDValue.Visible = true;
//            GetContact();
//        }
//    }
//}
