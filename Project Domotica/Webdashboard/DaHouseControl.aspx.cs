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
            if (conn.Validation() == false)
            {
                conn.Connect();
            }
            if (conn.Validation() == true && !Page.IsPostBack)
            {
                Connection_Controll();
            }
            conn.Close();
        }
        protected void Connect_2_DaHouse()
        {
            if (Global.client != null)
            {
                Connect_info.Text = "Connection already open";
            }
            else
            {
                try
                {
                    Global.client = new TcpClient();
                    Global.client.Connect("127.0.0.1", 11000);
                    Connect_info.Text = "Connection succesfull";
                }
                catch (Exception ex)
                {
                    Global.client = null;
                    Connect_info.Text = "Connection Failed";
                }
            }
        }
        protected void Connection_Controll()
        {
            string responseData = string.Empty;
            CheckBox[] lamp = { cbtn_Lamp1, cbtn_Lamp2, cbtn_Lamp3, cbtn_Lamp4, cbtn_Lamp5 };
            CheckBox[] window = { cbtn_window1, cbtn_window2 };
            home.Check(ref lamp, ref window);
        }

        protected void heater(string x)
        {
            String sendString = "heater " + x + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Connect_info.Text = responseData;
        }
        protected void window_open(string x)
        {
            String sendString = "Window " + x + " open" + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Connect_info.Text = responseData;
        }
        protected void window_close(string x)
        {
            String sendString = "Window " + x + " close" + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Connect_info.Text = responseData;
        }

        #region Aanroep
        protected void Connect_Click1(object sender, EventArgs e)
        {
            if (conn.Validation() == false)
            Connect_2_DaHouse();
            else { Connect_info.Text = "You're already connected to DaHaus"; }
            if (conn.Validation() == true)
            {
                Connection_Controll();
            }
        }
        protected void cbtn_Lamp1_CheckedChanged(object sender, EventArgs e)
        {
            if (conn.Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp1.Checked == true)
                {
                    
                    home.LampWindow_SendCommand("lamp", "0", "on");
                }
                else if (cbtn_Lamp1.Checked == false)
                {
                    home.LampWindow_SendCommand("lamp", "0", "off");
                }
            }
        }
        protected void cbtn_Lamp2_CheckedChanged(object sender, EventArgs e)
        {
            if (conn.Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp2.Checked == true)
                {
                    home.LampWindow_SendCommand("lamp", "1", "on");
                }
                else if (cbtn_Lamp2.Checked == false)
                {
                    home.LampWindow_SendCommand("lamp", "1", "off");
                }
            }
        }
        protected void cbtn_Lamp3_CheckedChanged(object sender, EventArgs e)
        {
            if (conn.Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp3.Checked == true)
                {
                    home.LampWindow_SendCommand("lamp", "2", "on");
                }
                else if (cbtn_Lamp3.Checked == false)
                {
                    home.LampWindow_SendCommand("lamp", "2", "off");
                }
            }
        }
        protected void cbtn_Lamp4_CheckedChanged(object sender, EventArgs e)
        {
            if (conn.Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp4.Checked == true)
                {
                    home.LampWindow_SendCommand("lamp", "3", "on");
                }
                else if (cbtn_Lamp4.Checked == false)
                {
                    home.LampWindow_SendCommand("lamp", "3", "off");
                }
            }
        }
        protected void cbtn_Lamp5_CheckedChanged(object sender, EventArgs e)
        {
            if (conn.Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp5.Checked == true)
                {
                    home.LampWindow_SendCommand("lamp", "4", "on");
                }
                else if (cbtn_Lamp5.Checked == false)
                {
                    home.LampWindow_SendCommand("lamp", "4", "off");
                }
            }
        }
        protected void cbtn_window1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_window1.Checked == false)
            {
                window_open("0");
            }
            else if (cbtn_window1.Checked == true)
            {
                window_close("0");
            }
        }

        protected void cbtn_window2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_window2.Checked == false)
            {
                window_open("1");
            }
            else if (cbtn_window2.Checked == true)
            {
                window_close("1");
            }
        }

        protected void btn_heater_Click(object sender, EventArgs e)
        {
            string S_heater = Txt_heater.Text;
            heater(S_heater);
        }

        #endregion
    }
}
