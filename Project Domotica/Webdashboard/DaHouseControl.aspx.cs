﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Connect_Click1(object sender, EventArgs e)
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

        protected void lamp_on(string x)
        {
            String sendString = "lamp " + x + " on" + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            // if (responseData == "")
            Connect_info.Text = responseData;

        }
        protected void lamp_off(string x)
        {
            String sendString = "lamp " + x + " off" + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Connect_info.Text = responseData;

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
        protected void cbtn_Lamp1_CheckedChanged(object sender, EventArgs e)
        {
            Connect_info.Text = "command sent";
            if (cbtn_Lamp1.Checked == true)
            {
                lamp_on("0");
            }
            else if (cbtn_Lamp1.Checked == false)
            {
                lamp_off("0");
            }

        }

        protected void cbtn_Lamp2_CheckedChanged(object sender, EventArgs e)
        {
            Connect_info.Text = "command sent";
            if (cbtn_Lamp2.Checked == true)
            {
                lamp_on("1");
            }
            else if (cbtn_Lamp2.Checked == false)
            {
                lamp_off("1");
            }

        }

        protected void cbtn_Lamp3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_Lamp3.Checked == true)
            {
                lamp_on("2");
            }
            else if (cbtn_Lamp3.Checked == false)
            {
                lamp_off("2");
            }
        }

        protected void cbtn_Lamp4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_Lamp4.Checked == true)
            {
                lamp_on("3");
            }
            else if (cbtn_Lamp3.Checked == false)
            {
                lamp_off("3");
            }
        }

        protected void cbtn_Lamp5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtn_Lamp5.Checked == true)
            {
                lamp_on("4");
            }
            else if (cbtn_Lamp3.Checked == false)
            {
                lamp_off("4");
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
    }
}
}