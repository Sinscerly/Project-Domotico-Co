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
            if (Connection_Validation() == false)
            {
                Connect_2_DaHouse();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "You're connected to your house" + "');", true);
            }
            if(Connection_Validation() == true)
            {
                string responseData = string.Empty;
                int x = 0;
                //for (int i = 0; i < Page.Controls.Count; i++)
                //{
                //    Detect_Status_Lamp(x.ToString(), out responseData);
                //    lbl_info.Text = lbl_info.Text + responseData + " \n";
                //    if (responseData.Contains("On"))
                //    {
                //
                //    }
                //    else if (responseData.Contains("Off"))
                //    {
                //
                //    }
                //    x++;
                //}
                CheckBox[] current = { cbtn_Lamp1, cbtn_Lamp2, cbtn_Lamp3 };
                for (int i = 0; i < current.Length; i++) {
                    current[i].Checked = true;
                }
               //Detect_Status_Lamp(x.ToString(), out responseData);
               //if (responseData.Contains("On"))
               //{
               //
               //}
            }
        }

        protected void Detect_Status_Lamp(string x, out string responseData)
        {
            String sendString = "lamp " + x + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            if (responseData != "") { Connect_info.Text = responseData; }
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
        protected bool Connection_Validation()
        {
            if(Global.client != null) { bool connectionvalidator = true;  return connectionvalidator; }
            else { bool connectionvalidator = false;
                Connect_info.Text = "You're not connected to you're house";
                return connectionvalidator;
            }
        }

        protected void LampWindow_SendCommand(string x, string y, string z)
        {
            String sendString = x + " " + y + " " + z + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            if (responseData != "") { Connect_info.Text = responseData; }
            
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
            Connect_2_DaHouse();
        }
        protected void cbtn_Lamp1_CheckedChanged(object sender, EventArgs e)
        {
            if (Connection_Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp1.Checked == true)
                {
                    LampWindow_SendCommand("lamp", "0", "on");
                }
                else if (cbtn_Lamp1.Checked == false)
                {
                    LampWindow_SendCommand("lamp", "0", "off");
                }
            }
        }
        protected void cbtn_Lamp2_CheckedChanged(object sender, EventArgs e)
        {
            if (Connection_Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp2.Checked == true)
                {
                    LampWindow_SendCommand("lamp", "1", "on");
                }
                else if (cbtn_Lamp2.Checked == false)
                {
                    LampWindow_SendCommand("lamp", "1", "off");
                }
            }
        }
        protected void cbtn_Lamp3_CheckedChanged(object sender, EventArgs e)
        {
            if (Connection_Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp3.Checked == true)
                {
                    LampWindow_SendCommand("lamp", "2", "on");
                }
                else if (cbtn_Lamp3.Checked == false)
                {
                    LampWindow_SendCommand("lamp", "2", "off");
                }
            }
        }
        protected void cbtn_Lamp4_CheckedChanged(object sender, EventArgs e)
        {
            if (Connection_Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp4.Checked == true)
                {
                    LampWindow_SendCommand("lamp", "3", "on");
                }
                else if (cbtn_Lamp4.Checked == false)
                {
                    LampWindow_SendCommand("lamp", "3", "off");
                }
            }
        }
        protected void cbtn_Lamp5_CheckedChanged(object sender, EventArgs e)
        {
            if (Connection_Validation() == true)
            {
                Connect_info.Text = "command sent";
                if (cbtn_Lamp5.Checked == true)
                {
                    LampWindow_SendCommand("lamp", "4", "on");
                }
                else if (cbtn_Lamp5.Checked == false)
                {
                    LampWindow_SendCommand("lamp", "4", "off");
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
