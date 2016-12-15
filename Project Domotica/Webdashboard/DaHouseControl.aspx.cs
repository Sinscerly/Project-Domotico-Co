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
            if (!IsPostBack)
            {
                if (conn.Validation() == false)
                {
                    conn.Connect();
                }
                if (conn.Validation() == true)
                {
                    //Connection_Controll();
                    conn.Close();
                }
            }
            else
            { 
             
                // checkbox clicked 
            }
        }
        protected void Connection_Controll()
        {
            string responseData = string.Empty;
            CheckBox[] lamp = { cbtn_Lamp1, cbtn_Lamp2, cbtn_Lamp3, cbtn_Lamp4, cbtn_Lamp5 };
            CheckBox[] window = { cbtn_window1, cbtn_window2 };
            home.Check(lamp);
            home.Check(window);
        }
        #region Aanroep
        protected void Connect_Click1(object sender, EventArgs e)
        {
            conn.Connect();
            Connection_Controll();
            conn.Close();
        }
        protected void Toggle_Lamp(object sender, EventArgs e)
        {
            conn.Connect();
            if (conn.Validation() == true)
            {
                CheckBox[] Lamps = { cbtn_Lamp1, cbtn_Lamp2, cbtn_Lamp3, cbtn_Lamp4, cbtn_Lamp5 };
                int i = Lamps.ToList().IndexOf((CheckBox)sender);
                home.LampWindow_Command("lamp", i.ToString(), Lamps[i].Checked == true ? "on" : "off");
                conn.Close();
            }
            
        }
        protected void Toggle_Window(object sender, EventArgs e)
        {
            conn.Connect();
            if (conn.Validation() == true)
            {
                CheckBox[] Windows = { cbtn_window1, cbtn_window2 };
                int i = Windows.ToList().IndexOf((CheckBox)sender);
                home.LampWindow_Command("window", i.ToString(), Windows[i].Checked == true ? "close" : "open");
            }
            conn.Close();
        }
        protected void Change_Heater(object sender, EventArgs e)
        {
            conn.Connect();
            if (conn.Validation() == true)
            {
                Txt_heater.Text = home.heater(Txt_heater.Text);
            }
            conn.Close();
        }
        #endregion
    }
}
