using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Project
{
    class program
    {
        public static void udp_client()
        {
            Console.Write("UDP Message: ");

            string input = Console.ReadLine();
            string ip_address = "127.0.0.1";
            int ip_port = 5500;

            Console.WriteLine("Sending command: " + input);
            Console.WriteLine("To: " + ip_address + ":" + ip_port.ToString());
            
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ip_address), ip_port);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            
            byte[] input_encoded = new byte[1024];
            input_encoded = Encoding.ASCII.GetBytes(input);
            server.SendTo(input_encoded, input_encoded.Length, SocketFlags.None, ip);
            server.Close();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void Main(string[] args){
            udp_client();
        }
    }
}