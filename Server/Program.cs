using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace TCP_AC
{
    public class serv
    {
        public static void Main()
        {
            LocalIPv4 GetIP = new LocalIPv4();
            ASCIIEncoding asen = new ASCIIEncoding();
            try
            {
                while (true)
                {
                    /* Get Local IPv4 Address */
                    IPAddress ipAd = IPAddress.Parse(GetIP.GetLocalIPv4(NetworkInterfaceType.Ethernet));

                    /* Initializes the Listener */
                    TcpListener myList = new TcpListener(ipAd, 8001);

                    /* Start Listeneting at the specified port */
                    myList.Start();
                    Console.WriteLine("The server is running at port 8001...");
                    Console.WriteLine("The local End point is :" +myList.LocalEndpoint);
                    Console.WriteLine("Waiting for first connection.....");

                    /* First Connection */
                    Socket P1 = myList.AcceptSocket();
                    Console.WriteLine("Connection accepted from " + P1.RemoteEndPoint);
                                                    

                    
                    Console.WriteLine("Waiting for second connection.....");
                    P1.Send(asen.GetBytes("1"));
                    /* Second Connection */
                    Socket P2 = myList.AcceptSocket();
                    Console.WriteLine("Connection accepted from " + P2.RemoteEndPoint);
                    Console.WriteLine();
                    P2.Send(asen.GetBytes("2"));


                    Console.WriteLine();
                    Console.WriteLine();
                    /* clean up */
                    //P1.Close();
                    //P2.Close();
                    //myList.Stop();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }

    }
}