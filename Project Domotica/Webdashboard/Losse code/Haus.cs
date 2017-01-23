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
            //Get's the information from all lamps
            string responseData = string.Empty, y = string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                y = "Lamp " + i.ToString() + "\n";
                Send_Command(y, out responseData);
                // if lamp == On => checkbox == true
                x[i].Checked = responseData.Contains("On");
            }
        }
        public void Check_Window(CheckBox[] x)
        {
            //Get's the information from all windows
            string responseData = string.Empty, y = string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                y = "Window " + i.ToString() + "\n";
                Send_Command(y , out responseData);
                // if window == Close => checkbox == true
                x[i].Checked = responseData.Contains("Close");
            }
        }
        public string heater_Status(string x)
        {
            //Get's the information from the heater
            string ResponseData = string.Empty;
            Send_Command("heater \n", out ResponseData);
            return ResponseData;
        }
        private void Send_Command(string x, out string ResponseData)
        {
            ResponseData = string.Empty;
            if (conn.Validation() == true)
            {
                //Send the data to DaHaus
                byte[] data = Encoding.ASCII.GetBytes(x);
                NetworkStream stream = Global.client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new byte[1024];
                ResponseData = string.Empty;
                //Read the data output from DaHaus
                Int32 bytes = stream.Read(data, 0, data.Length);
                ResponseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            }
        }
        public void LampWindow_Command(string X, string Y, string Z)
        {
            //Makes the command used to controll a lamp or window
            string ResponseData = string.Empty;
            //X is for what it is(lamp or window). Y is for the lamp's or window's number. Z is for the commando(On or Off, Close or Open).
            Send_Command(X + " " + Y + " " + Z + "\n", out ResponseData);
        }
        public string heater(string X)
        {
            //Makes the command used to controll the heater
            string ResponseData = string.Empty;
            //X stands for the amount degrees it has to be on(a number between 12, 35).
            Send_Command("heater " + X + "\n", out ResponseData);
            return ResponseData;
        }

    }
}