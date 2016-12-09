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
            if (Button1.Visible == true)
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.PostBackUrl = "Games/HitTheDot.aspx";
                 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button2.PostBackUrl = "Games/CountryGuessing.aspx";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start( "http://gabrielecirulli.github.io/2048/");
            }
            catch (Exception exc) { lblError.Text = exc.Message; }

           
        }

        protected void ButtonEntertainment_Click(object sender, EventArgs e)
        {
            if (YoutubeButton.Visible == true)
            {
                YoutubeButton.Visible = false;
                NetflixButton.Visible = false;
                

            }
            else
            {
                YoutubeButton.Visible = true;
                NetflixButton.Visible = true;
                
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("www.youtube.com");
            }
            catch ( Exception exc) { lblError.Text = exc.Message; } 
        }

        protected void NetflixButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.netflix.com/nl/");
            }
            catch (Exception exc) { lblError.Text = exc.Message; }
            
        }

        protected void ButtonZorg_Click(object sender, EventArgs e)
        {
            DomoticaButton.PostBackUrl = "DaHouseControl.aspx";
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {

        }
    }
}