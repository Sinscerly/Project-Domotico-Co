﻿using System;
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
        Connection conn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["membercookie"] != null)
            {
                lbl_LogOut_In.Text = "Log Out";
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
                        lbl_WelcomeUser.Text = "Good morning " + USER;
                    }
                    else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                    {
                        lbl_WelcomeUser.Text = "Good afternoon " + USER;
                    }
                    else if (DateTime.Now.Hour >= 18)
                    {
                        lbl_WelcomeUser.Text = "Good evening " + USER;
                    }
                }
                else
                {
                    lbl_WelcomeUser.Text = "You're not yet logged in.";
                }
            }
            else
            {
                lbl_WelcomeUser.Text = "You're not yet logged in.";
                lbl_LogOut_In.Text = "Log In";
            }
        }
        protected void Page_LoadComplete()
        {

        }
    }
}