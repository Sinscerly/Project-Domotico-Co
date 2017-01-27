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
using System.Data.OleDb;

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
                UselessButton.Visible = false;
                CalcButton.Visible = false;
                InhollandButton.Visible = false;
                MakeYourButton.Visible = false;

                UselessButton.Visible = false;
                lblUseless.Visible = false;
                lblUselessTeller.Visible = false;
            }
        }

        protected void ButtonEntertainment_Click(object sender, EventArgs e)
        {
            if (YoutubeButton.Visible == false)
            {
                YoutubeButton.Visible = true;
                NetflixButton.Visible = true;
                UselessButton.Visible = true;

            }
            else
            {
                YoutubeButton.Visible = false;
                NetflixButton.Visible = false;

                UselessButton.Visible = false;
                lblUseless.Visible = false;
                lblUselessTeller.Visible = false;

            }
            if (YoutubeButton.Visible == true)
            {
                Hit_The_Dot.Visible = false;
                Country_Guessing.Visible = false;
                G2048.Visible = false;
                CalcButton.Visible = false;
                InhollandButton.Visible = false;
                MakeYourButton.Visible = false;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.youtube.com");
        }

        protected void NetflixButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.netflix.com/nl/");
        }

        protected void Domotica_OnClick(object sender, EventArgs e)
        {
            HttpCookie obj2cookie = Request.Cookies["membercookie"];
            if (obj2cookie != null)
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
                    Response.Redirect("restricted/DaHouseControl.aspx");
                }
                else
                {
                    conn.Close();
                    lblError.Text = "You need to open DaHaus first!";
                }
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }


        protected void Button4_Click1(object sender, EventArgs e)
        {
            if (CalcButton.Visible == false)
            {
                CalcButton.Visible = true;
                InhollandButton.Visible = true;
                MakeYourButton.Visible = true;


            }
            else
            {
                CalcButton.Visible = false;
                InhollandButton.Visible = false;
                MakeYourButton.Visible = false;

            }

            if (CalcButton.Visible == true)

            {
                Hit_The_Dot.Visible = false;
                Country_Guessing.Visible = false;
                G2048.Visible = false;
                YoutubeButton.Visible = false;
                NetflixButton.Visible = false;

                UselessButton.Visible = false;
                lblUseless.Visible = false;
                lblUselessTeller.Visible = false;
            }
        }

        protected void CalcButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tools/calc.aspx");
            
        }

        protected void InhollandButton_Click(object sender, EventArgs e)
        {

            Response.Redirect("https://webmail.inholland.nl");
       
        }

        protected void G2048_Click(object sender, EventArgs e)
        {
            
        }

        protected void Hit_The_Dot_Click(object sender, EventArgs e)
        {

        }

        protected void MakeYourButton_Click(object sender, EventArgs e)
        {
            if (Label1.Visible == false)

            {
                Label1.Visible = true;
                Label2.Visible = true;
                txtButtonnaam.Visible = true;
                txtLinkAdres.Visible = true;
                SubmitMYB.Visible = true;

            }
            else 
            {
                Label1.Visible = false;
                Label2.Visible = false;
                txtButtonnaam.Visible = false;
                txtLinkAdres.Visible = false;
                SubmitMYB.Visible = false;
            }
        }

        protected void SubmitMYB_Click(object sender, EventArgs e)
        {
            Button button2 = new Button();
            button2.Text = txtButtonnaam.Text;
            button2.Click += new EventHandler(button2_Click);
            Panel1.Controls.Add(button2);
            
            
        }
        protected void button2_Click(object sender, EventArgs e)
        {
           string linkadres =  txtLinkAdres.Text;
            Response.Redirect("linkadres");
        }

        protected void UselessButton_Click(object sender, EventArgs e)
        {
            if (lblUseless.Visible == false)
            { lblUseless.Visible = true;
                lblUselessTeller.Visible = true; }
            

            

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";


            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;

            cmd.CommandText = string.Format("SELECT scores.Useless FROM Scores WHERE scores.id = '6' ");

            lblUselessTeller.Text = "";
           

            try
            {
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblUselessTeller.Text += String.Format("{0}",
            reader["Useless"].ToString());

                }


            }
            catch (Exception exc)
            {
                lblUselessTeller.Text = exc.Message;
            }
            finally
            {
                conn.Close();
            }


        }
    }
}