using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Webdashboard
{
    public partial class DashboardMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = string.Empty, USER = string.Empty;
            HttpCookie CookieLogin = Request.Cookies["CookieID"];
            if (CookieLogin != null)
            {
                ID = CookieLogin["UserID"].ToString();
            }
            if (ID != null)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format("SELECT username FROM users WHERE id = {0} ", ID);
                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        USER = string.Format(reader["username"].ToString());
                    }
                }
                catch (Exception exc) { lbl_WelcomeUser.Text = exc.Message; }
                finally { conn.Close(); }

                if (DateTime.Now.Hour < 12)
                {
                    lbl_WelcomeUser.Text = "Goedemorgen " + USER;
                }
                else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                {
                    lbl_WelcomeUser.Text = "Goedemiddag " + USER;
                }
                else if (DateTime.Now.Hour >= 18)
                {
                    lbl_WelcomeUser.Text = "Goedenavond " + USER;
                }
            }
            else
            {
                lbl_WelcomeUser.Text = "U bent nog niet ingelogd.";
            }
        }
        protected void Page_LoadComplete()
        {
            
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["membercookie"] != null)
            {
                HttpCookie myCookie = new HttpCookie("membercookie");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }
            if (Request.Cookies["CookieID"] != null)
            {
                HttpCookie myCookie = new HttpCookie("CookieID");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }

            Response.Redirect(Request.RawUrl);


        }
    }
}