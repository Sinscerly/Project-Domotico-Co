using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webdashboard
{
    public partial class LogoutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Connection conn = new Connection();
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
            if (Global.client != null)
            {
                conn.Close();
            }
            Response.Redirect("FirstPage.aspx");
        }
    }
}