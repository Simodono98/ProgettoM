using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ProgettoM
{
    public partial class Menu : Form
    {
        TcpClient tcpclnt = new TcpClient();
        Byte[] buffer = new Byte[256];
        ASCIIEncoding asen = new ASCIIEncoding(); 
        
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/talignania/Desktop/ProgettoM/Server/bin/Debug/Server.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {                
                textBoxDebug.Text += "Connecting.....\r\n";
                tcpclnt.Connect(textBoxIP.Text, 8001);

                NetworkStream reader = tcpclnt.GetStream();
                Int32 bytes = reader.Read(buffer, 0, buffer.Length);
                String responseData = System.Text.Encoding.ASCII.GetString(buffer, 0, bytes);

                //reader.Read(buffer, 0, buffer.Length);

                if (responseData == "1")
                {
                    Memory m = new Memory(true, tcpclnt);
                    textBoxDebug.Text += "Connected as player 1\r\n";
                    m.Show();                    
                }
                else
                {
                    Memory m = new Memory(false, tcpclnt);
                    textBoxDebug.Text += "Connected as player 2\r\n";
                    m.Show();
                }

            }

            catch (Exception E)
            {
                Console.WriteLine("Error..... " + E.StackTrace);
            }
        }
    }
}
