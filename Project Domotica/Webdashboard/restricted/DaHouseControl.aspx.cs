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
    public partial class DaHouseControl : System.Web.UI.Page
    {
        Connection conn = new Connection();
        Haus home = new Haus();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            bool Connection = false;
            // Controlling if DaHaus is turned on.
            if (Global.client == null)
            {
                conn.Connect();
            }
            // Validation_Succesfull = conn.Validation();
            if (conn.Validation() == true)
            {
                Connection = true;
                conn.Close();
            }
            else
            {
                Response.Redirect("FirstPage.aspx");
            }
            // Getting all the possible information from DaHaus
            if (!IsPostBack && Connection == true)
            {
                Connection_Controll();
            }
        }
        protected void Connection_Controll()
        {
            string responseData = string.Empty;
            CheckBox[] lamp = { cbtn_Lamp1, cbtn_Lamp2, cbtn_Lamp3, cbtn_Lamp4, cbtn_Lamp5 };
            CheckBox[] window = { cbtn_window1, cbtn_window2 };
            home.Check_Lamp(lamp);
            home.Check_Window(window);
            lbl_info.Text = home.heater_Status(Txt_heater.Text);
        }
        #region Aanroep
        
        protected void Connect_Click1(object sender, EventArgs e)
        {
            Connection_Controll();
        }
        protected void Toggle_Lamp(object sender, EventArgs e)
        {
                CheckBox[] Lamps = { cbtn_Lamp1, cbtn_Lamp2, cbtn_Lamp3, cbtn_Lamp4, cbtn_Lamp5 };
                int i = Lamps.ToList().IndexOf((CheckBox)sender);
                home.LampWindow_Command("lamp", i.ToString(), Lamps[i].Checked == true ? "on" : "off");
        }
        protected void Toggle_Window(object sender, EventArgs e)
        {
                CheckBox[] Windows = { cbtn_window1, cbtn_window2 };
                int i = Windows.ToList().IndexOf((CheckBox)sender);
                home.LampWindow_Command("window", i.ToString(), Windows[i].Checked == true ? "close " : "open ");
        }
        protected void Change_Heater(object sender, EventArgs e)
        {
                lbl_info.Text = home.heater(Txt_heater.Text);
        }
        #endregion

       

        protected void BackToApps_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirstPage.aspx");
            
        }
    }
}
