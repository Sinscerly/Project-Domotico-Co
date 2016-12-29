using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Webdashboard
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        } 

        protected void ButtonGames_Click(object sender, EventArgs e)
        {
            if (Hit_The_Dot.Visible == false)
            {
                Hit_The_Dot.Visible = true;
                Country_Guessing.Visible = true;
                G2048.Visible = true;
                
            }
            else
            {
                Hit_The_Dot.Visible = false;
                Country_Guessing.Visible = false;
                G2048.Visible = false;
            }

            if (Hit_The_Dot.Visible == true)
            {
                YoutubeButton.Visible = false;
                NetflixButton.Visible = false;
                CalcButton.Visible = false;
                InhollandButton.Visible = false;
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
            if (YoutubeButton.Visible == true)
            {
                Hit_The_Dot.Visible = false;
                Country_Guessing.Visible = false;
                G2048.Visible = false;
                CalcButton.Visible = false;
                InhollandButton.Visible = false;
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

        protected void Domotica_OnClick(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            bool Connection_Succesfull = false;
            if (Global.client == null)
            {
                conn.Connect();
            }
            if (Connection_Succesfull = conn.Validation() == true)
            {
                conn.Close();
            }
            if (Connection_Succesfull == true)
            {
                Response.Redirect("DaHouseControl.aspx");
            }
            else
            {
                lblError.Text = "You need to open DaHaus first!";
            }
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            if (CalcButton.Visible == false)
            {
                CalcButton.Visible = true;
                InhollandButton.Visible = true;


            }
            else
            {
                CalcButton.Visible = false;
                InhollandButton.Visible = false;

            }

            if (CalcButton.Visible == true)

            {
                Hit_The_Dot.Visible = false;
                Country_Guessing.Visible = false;
                G2048.Visible = false;
                YoutubeButton.Visible = false;
                NetflixButton.Visible = false;
            }
        }

        protected void CalcButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tools/calc.aspx");
            
        }

        protected void InhollandButton_Click(object sender, EventArgs e)
        {

            
         try
         {
             System.Diagnostics.Process.Start("https://webmail.inholland.nl");
         }
         catch (Exception exc) { lblError.Text = exc.Message; }


        }
    }
}