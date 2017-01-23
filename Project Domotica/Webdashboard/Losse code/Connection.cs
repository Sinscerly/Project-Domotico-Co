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
            // Following the try-catch-finally way, but the finally you can find under the Close() methode.
            try
            {
                //Making a new connection with DaHaus
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
                // Closing connection on the program for this thread.
                String sendString = "exit " + "\n";
                byte[] data = Encoding.ASCII.GetBytes(sendString);
                NetworkStream stream = Global.client.GetStream();
                stream.Write(data, 0, data.Length);

                // Setting Global.client to null, so that the systems knows that the connection is closed.
                Global.client = null;
            }
        }
        public bool Validation()
        {
            // If there is a Connection, boolean = True. Else False
            return Global.client != null;
        }
    }
}
