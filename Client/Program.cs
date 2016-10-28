using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;


public class Client
{

    public static void Main()
    {

        try
        {
            TcpClient tcpclnt = new TcpClient();
            Console.WriteLine("Connecting.....");

            tcpclnt.Connect("192.168.1.15", 8001);
            // use the ipaddress as in the server program


            Console.WriteLine("Connected");

            tcpclnt.Close();
        }

        catch (Exception e)
        {
            Console.WriteLine("Error..... " + e.StackTrace);
        }
    }

}