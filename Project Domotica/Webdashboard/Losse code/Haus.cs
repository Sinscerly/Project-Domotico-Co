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
    public class Haus
    {
        public void Check(ref CheckBox[] lamp, ref CheckBox[] window)
        {
            string responseData = string.Empty;
            for (int i = 0; i < lamp.Length; i++)
            {
                Detect_Status("lamp", i.ToString(), out responseData);
                if (responseData.Contains("Off")) { lamp[i].Checked = false; }
                else if (responseData.Contains("On")) { lamp[i].Checked = true; }
            }
            for (int i = 0; i < window.Length; i++)
            {
                Detect_Status("window", i.ToString(), out responseData);
                if (responseData.Contains("Open")) { window[i].Checked = false; }
                else if (responseData.Contains("Closed")) { window[i].Checked = true; }
            }
        }
        private void Detect_Status(string x, string y, out string responseData)
        {
            String sendString = x + " " + y + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
        }
        public void LampWindow_SendCommand(string x, string y, string z)
        {
            String sendString = x + " " + y + " " + z + "\n";
            byte[] data = Encoding.ASCII.GetBytes(sendString);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
        }
    }
}