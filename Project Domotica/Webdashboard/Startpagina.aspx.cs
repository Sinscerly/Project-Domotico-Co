using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webdashboard
{
    public partial class Startpagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.youtube.com");
            }
            catch
            (Exception exc)
            { lblError.Text = exc.Message; }
        
    }

        protected void NetflixButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.netflix.com/nl/");
            }
            catch
            (Exception exc)
            { lblError.Text = exc.Message; }
        }

        protected void ButtonGames_Click(object sender, EventArgs e)
        {
            if (Button1.Visible == false)
            {
                Button1.Visible = true;
                Button2.Visible = true;
                Button3.Visible = true;
            }

            else
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
            }

        }

        protected void ButtonEntertainment_Click(object sender, EventArgs e)
        {
            if (YoutubeButton.Visible == false)
            {
                YoutubeButton.Visible = true;
                NetflixButton.Visible = true;

            }

            else
            {
                YoutubeButton.Visible = false;
                NetflixButton.Visible = false;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.PostBackUrl = "HitTheDot.aspx";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button2.PostBackUrl = "CountryGuessing.aspx";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}