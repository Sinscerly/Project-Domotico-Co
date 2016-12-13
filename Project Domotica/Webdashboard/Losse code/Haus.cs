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
        public void Check(CheckBox[] x)
        {
            string responseData = string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                Detect_Status("lamp", i.ToString(), out responseData);
                // if lamp on, checkbox == true
                x[i].Checked = responseData.Contains("On");
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
        private void Send_Command(string x)
        {
            byte[] data = Encoding.ASCII.GetBytes(x);
            NetworkStream stream = Global.client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[1024];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
        }
        public void LampWindow_SendCommand(string x, string y, string z)
        {
            Send_Command(x + " " + y + " " + z + "\n");
        }
        public void heater(string x)
        {
            Send_Command("heater " + x + "\n");
        }
    }
}