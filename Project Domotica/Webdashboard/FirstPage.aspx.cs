using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webdashboard
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGames_Click(object sender, EventArgs e)
        {
            if (Button1.Visible = true)
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                
            }
            else
            {
                Button1.Visible = true;
                Button2.Visible = true;
                Button3.Visible = true;
            }
        }
    }
}