using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;


namespace Webdashboard
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        
        }

        protected void btnRegistreren_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source=|DataDirectory|LoginData.accdb";

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO GebruikersTabel (GebruikersNaam,Wachtwoord,Voornaam,Achternaam,Geboortedatum,Email)";

            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception exc) { lblConnectionFeedback.Text = exc.Message; }
            finally { conn.Close(); }

        }
    }
}