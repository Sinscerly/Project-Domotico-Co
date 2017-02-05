using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Webdashboard.restricted
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(OverView);
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(ChangePassView);
        }

        protected void btnChangeEmail_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(ChangeEmailView);
        }

        protected void btnChangeEmail2_Click(object sender, EventArgs e)
        {
            HttpCookie CookieLogin = Request.Cookies["CookieID"];

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
            Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";


            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            string ID = CookieLogin["UserID"].ToString();
            cmd.CommandText = string.Format("update users  SET emailaddress = '{0}'  WHERE users.id = {1}", txtChangeEmail.Text, ID);

            try
            {
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception exc)
            {
                lblError.Text = exc.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}