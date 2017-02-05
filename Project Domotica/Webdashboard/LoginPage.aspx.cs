using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.IO;


namespace Webdashboard
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNRegister_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Register);
        }

        protected void BTNChangePass_Click(object sender, EventArgs e)
        {

        }

        protected void ContinueButton_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Login);
        }

       
        protected void CancelPushButton_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Login);
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            int UserID = 0;
            string txtUserName = Login1.UserName;
            cmd.CommandText = string.Format("select id from users where username = '{0}'",  txtUserName);
            
            try
            {
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserID = Convert.ToInt16(reader["id"]);
                }
            }
            finally
            {
                conn.Close();
            }
            
            HttpCookie CookieLogin = new HttpCookie("CookieID");
            DateTime datum = DateTime.Now;

            CookieLogin.Values.Add("UserID", UserID.ToString());

            CookieLogin.Expires = datum.AddMinutes(15);
            Response.Cookies.Add(CookieLogin);

            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = string.Format("update Users  SET LastLogin = '{0}'  where Users.id = {1}", datum, UserID);

            string LastLogin = datum.ToString();

            try
            {
                conn.Open();

                OleDbDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                  LastLogin = string.Format(reader["LastLogin"].ToString());
                }
            }
            finally
            {
                conn.Close();
            }
            
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}