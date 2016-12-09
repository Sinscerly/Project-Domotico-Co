using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webdashboard
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            lblGNaam.Visible = false;
            txtGNaam.Visible = false;
            lblWachtwoord.Visible = false;
            TxtWachtwoord.Visible = false;
            BtnLogin.Visible = false;


        }
    }
}