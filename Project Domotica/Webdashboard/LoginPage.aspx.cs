﻿using System;
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
            
        }

        protected void BTNChangePass_Click(object sender, EventArgs e)
        {

        }

        protected void ContinueButton_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Login);
        }

        protected void ChangePassword1_ChangedPassword(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Login);
        }

        protected void CancelPushButton_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Login);
        }
    }
}