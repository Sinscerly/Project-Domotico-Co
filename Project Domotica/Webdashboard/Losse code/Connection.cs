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
    public class Connection
    {
        public void Connect()
        {
            try
            {
                Global.client = new TcpClient();
                Global.client.Connect("127.0.0.1", 11000);
            }
            catch (Exception ex)
            {
                Global.client = null;
            }
        }
        public void Close()
        {
            if (Global.client != null)
            {
                String sendString = "exit " + "\n";
                byte[] data = Encoding.ASCII.GetBytes(sendString);
                NetworkStream stream = Global.client.GetStream();
                stream.Write(data, 0, data.Length);

                Global.client = null;
            }
        }
        public bool Validation()
        {
            //if (Global.client != null)
            //{
            //    bool connectionvalidator = true;
            //    return connectionvalidator;
            //}
            //else
            //{
            //    bool connectionvalidator = false;
            //    return connectionvalidator;
            //}
            return Global.client != null;
        }
    }
}
