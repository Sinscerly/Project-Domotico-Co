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
        Connection conn = new Connection();
        public void Check_Lamp(CheckBox[] x)
        {
            string responseData = string.Empty, y = string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                y = "Lamp " + i.ToString() + "\n";
                Send_Command(y, out responseData);
                // if lamp on, checkbox == true
                x[i].Checked = responseData.Contains("On");
            }
        }
        public void Check_Window(CheckBox[] x)
        {
            string responseData = string.Empty, y = string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                y = "Window " + i.ToString() + "\n";
                Send_Command(y , out responseData);
                // if lamp on, checkbox == true
                x[i].Checked = responseData.Contains("Close");
            }
        }
        private void Send_Command(string x, out string ResponseData)
        {

            ResponseData = string.Empty;
            //conn.Connect();
            if (conn.Validation() == true)
            {
                byte[] data = Encoding.ASCII.GetBytes(x);
                NetworkStream stream = Global.client.GetStream();
                stream.Write(data, 0, data.Length);

                data = new byte[1024];
                ResponseData = string.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                ResponseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

            }
            //conn.Close();
        }
        public void LampWindow_Command(string x, string y, string z)
        {
            string ResponseData = string.Empty;
            Send_Command(x + " " + y + " " + z + "\n", out ResponseData);
        }
        public string heater(string x)
        {
            string ResponseData = string.Empty;
            Send_Command("heater " + x + "\n", out ResponseData);
            return ResponseData;
        }
        public string heater_Status(string x)
        {
            string ResponseData = string.Empty;
            Send_Command("heater \n", out ResponseData);
            return ResponseData;
        }
    }
}