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
        static string link = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie obj2cookie = Request.Cookies["membercookie"];
            if (obj2cookie != null)
            {
                LoginButton.Visible = false;
            }
            else
            {
                LoginButton.Visible = true;
            }
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
                LinksButton.Visible = false;
                

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
                LinksButton.Visible = false;

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
                LinksButton.Visible = true;



            }
            else
            {
                CalcButton.Visible = false;
                InhollandButton.Visible = false;
                LinksButton.Visible = false;


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
            
        }

        protected void SubmitMYB_Click(object sender, EventArgs e)
        {
            
            if (ListBox.SelectedIndex == 0)
            {
                link = txtLinkAdres.Text;

                HttpCookie CookieLogin = Request.Cookies["CookieID"];
               

                if (CookieLogin != null)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";
                    

                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = conn;
                    string ID = CookieLogin["UserID"].ToString();
                    cmd2.CommandText = string.Format("update Buttons  SET Button1 = '{0}'  where buttons.id = {1}", txtButtonnaam.Text, ID);
                    
                    try
                    {
                        conn.Open();

                        OleDbDataReader reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomButton1.Text = string.Format(reader["Button1"].ToString());
                           
                        }

                    }
                    catch (Exception exc)
                    {
                        lblError.Text = exc.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }

                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = conn;
                    cmd3.CommandText = string.Format("update Buttons  SET link1 = '{0}'  where buttons.id = {1}", txtLinkAdres.Text, ID);

                    try
                    {
                        conn.Open();

                        OleDbDataReader reader = cmd3.ExecuteReader();
                        while (reader.Read())
                        {
                            link = string.Format(reader["link1"].ToString());

                        }

                    }
                    catch (Exception exc)
                    {
                        lblError.Text = exc.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }


                }
                else
                {
                    lblError.Text = "You need to relog in";
                }

            }
            else if (ListBox.SelectedIndex == 1)
            {
                CustomButton2.Text = txtButtonnaam.Text;
                link = txtLinkAdres.Text;
                HttpCookie CookieLogin = Request.Cookies["CookieID"];


                if (CookieLogin != null)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";


                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = conn;
                    string ID = CookieLogin["UserID"].ToString();
                    cmd2.CommandText = string.Format("update Buttons  SET Button2 = '{0}'  where buttons.id = {1}", txtButtonnaam.Text, ID);

                    try
                    {
                        conn.Open();

                        OleDbDataReader reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomButton2.Text = string.Format(reader["Button2"].ToString());
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

                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = conn;
                    cmd3.CommandText = string.Format("update Buttons  SET link2 = '{0}'  where buttons.id = {1}", txtLinkAdres.Text, ID);

                    try
                    {
                        conn.Open();

                        OleDbDataReader reader = cmd3.ExecuteReader();
                        while (reader.Read())
                        {
                            link = string.Format(reader["link2"].ToString());

                        }

                    }
                    catch (Exception exc)
                    {
                        lblError.Text = exc.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    lblError.Text = "You need to relog in";
                }

            }
            else if (ListBox.SelectedIndex == 2)
            {
                link = txtLinkAdres.Text;

                HttpCookie CookieLogin = Request.Cookies["CookieID"];


                if (CookieLogin != null)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";


                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = conn;
                    string ID = CookieLogin["UserID"].ToString();
                    cmd2.CommandText = string.Format("update Buttons  SET Button3 = '{0}'  where buttons.id = {1}", txtButtonnaam.Text, ID);

                    try
                    {
                        conn.Open();

                        OleDbDataReader reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomButton3.Text = string.Format(reader["Button3"].ToString());
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

                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = conn;
                    cmd3.CommandText = string.Format("update Buttons  SET link3 = '{0}'  where buttons.id = {1}", txtLinkAdres.Text, ID);

                    try
                    {
                        conn.Open();

                        OleDbDataReader reader = cmd3.ExecuteReader();
                        while (reader.Read())
                        {
                            link = string.Format(reader["link3"].ToString());

                        }

                    }
                    catch (Exception exc)
                    {
                        lblError.Text = exc.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    lblError.Text = "You need to relog in";
                }
            }
           

        }
        

        protected void UselessButton_Click(object sender, EventArgs e)
        {
            if (lblUseless.Visible == false)
            { lblUseless.Visible = true;
                lblUselessTeller.Visible = true; }


            HttpCookie CookieLogin = Request.Cookies["CookieID"];
            if (CookieLogin != null)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string ID =  CookieLogin["UserID"].ToString();

                cmd.CommandText = string.Format("UPDATE scores  SET scores.useless = scores.useless + 1   WHERE scores.id = {0} ", ID);

                lblUselessTeller.Text = "";


                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblUselessTeller.Text = string.Format(reader["Useless"].ToString());
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
                
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = string.Format("SELECT scores.Useless FROM Scores WHERE scores.id = {0} ", ID);

                lblUselessTeller.Text = "";
                
                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        lblUselessTeller.Text = string.Format(reader["Useless"].ToString());
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
            else
            { lblUselessTeller.Text = "Can not show the count, please login first"; }

        }

        protected void LinksButton_Click(object sender, EventArgs e)
        {
            if (CustomButton1.Visible == false)
            { CustomButton1.Visible = true;
                CustomButton2.Visible = true;
                CustomButton3.Visible = true;

                Customize.Visible = true;
               
            }
            else
            {
                CustomButton1.Visible = false;
                CustomButton2.Visible = false;
                CustomButton3.Visible = false;

                Customize.Visible = false;
                txtButtonnaam.Visible = false;
                txtLinkAdres.Visible = false;
                lblButtonNaam.Visible = false;
                LblLinkAdres.Visible = false;
                ListBox.Visible = false;
                SubmitMYB.Visible = false;
                
            }
            HttpCookie CookieLogin = Request.Cookies["CookieID"];
            if (CookieLogin != null)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";

                string ID = CookieLogin["UserID"].ToString();

                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = string.Format("SELECT button1 FROM buttons WHERE id = {0} ", ID);

                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        CustomButton1.Text = string.Format(reader["button1"].ToString());
                    }

                }
                catch (Exception exc)
                {
                    lblError.Text = exc.Message;
                }
                finally
                {
                    conn.Close();
                }

                OleDbCommand cmd4 = new OleDbCommand();
                cmd4.Connection = conn;
                cmd4.CommandText = string.Format("SELECT button2 FROM buttons WHERE id = {0} ", ID);

                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd4.ExecuteReader();
                    while (reader.Read())
                    {
                        CustomButton2.Text = string.Format(reader["button2"].ToString());
                    }

                }
                catch (Exception exc)
                {
                    lblError.Text = exc.Message;
                }
                finally
                {
                    conn.Close();
                }

                OleDbCommand cmd5 = new OleDbCommand();
                cmd5.Connection = conn;
                cmd5.CommandText = string.Format("SELECT button3 FROM buttons WHERE id = {0} ", ID);

                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd5.ExecuteReader();
                    while (reader.Read())
                    {
                        CustomButton3.Text = string.Format(reader["button3"].ToString());
                    }

                }
                catch (Exception exc)
                {
                    lblError.Text = exc.Message;
                }
                finally
                {
                    conn.Close();
                }
            }


        }

        protected void Customize_Click(object sender, EventArgs e)
        {
            if (lblButtonNaam.Visible == false)

            {
                lblButtonNaam.Visible = true;
                LblLinkAdres.Visible = true;
                txtButtonnaam.Visible = true;
                txtLinkAdres.Visible = true;
                SubmitMYB.Visible = true;
                ListBox.Visible = true;

            }
            else
            {
                lblButtonNaam.Visible = false;
                LblLinkAdres.Visible = false;
                txtButtonnaam.Visible = false;
                txtLinkAdres.Visible = false;
                SubmitMYB.Visible = false;
                ListBox.Visible = false;
            }
        }

        protected void CustomButton1_Click(object sender, EventArgs e)
        {

            HttpCookie CookieLogin = Request.Cookies["CookieID"];
            if (CookieLogin != null)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string ID = CookieLogin["UserID"].ToString();

                cmd.CommandText = string.Format("select link1 from buttons WHERE id = {0} ", ID);
                
                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        link = string.Format(reader["link1"].ToString());
                    }

                }
                catch (Exception exc)
                {
                    lblError.Text = exc.Message;
                }
                finally
                {
                    conn.Close();
                }
                    Response.Redirect(link);
            }
                
            else
            lblError.Text = "You need to login first";
        }

        protected void CustomButton2_Click(object sender, EventArgs e)
        {
            HttpCookie CookieLogin = Request.Cookies["CookieID"];
            if (CookieLogin != null)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string ID = CookieLogin["UserID"].ToString();

                cmd.CommandText = string.Format("select link2 from buttons WHERE id = {0} ", ID);

                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        link = string.Format(reader["link2"].ToString());
                    }

                }
                catch (Exception exc)
                {
                    lblError.Text = exc.Message;
                }
                finally
                {
                    conn.Close();
                }
                Response.Redirect(link);
            }

            else
                lblError.Text = "You need to login first";
        }

        protected void CustomButton3_Click(object sender, EventArgs e)
        {
            HttpCookie CookieLogin = Request.Cookies["CookieID"];
            if (CookieLogin != null)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +
                    Server.MapPath(@"\App_data") + @"\DashboardDatabase.accdb";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string ID = CookieLogin["UserID"].ToString();

                cmd.CommandText = string.Format("select link3 from buttons WHERE id = {0} ", ID);

                try
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        link = string.Format(reader["link3"].ToString());
                    }

                }
                catch (Exception exc)
                {
                    lblError.Text = exc.Message;
                }
                finally
                {
                    conn.Close();
                }
                Response.Redirect(link);
            }

            else
                lblError.Text = "You need to login first";
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            
        }
        protected void PersonalButton_Click(object sender, EventArgs e)
        {
            HttpCookie obj2cookie = Request.Cookies["membercookie"];
            if (obj2cookie == null)
            {
                lblError.Text = "You need to login first";
            }
            else
            {
                Response.Redirect("Settings.aspx")
            }
        }
    }
}
