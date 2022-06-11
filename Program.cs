using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Project
{
    class program
    {
        public static void udp_client(string send_data)
        {
            string input = send_data;
            byte[] input_encoded = new byte[1024];
            
            string ip_address = "127.0.0.1";
            int ip_port = 55398;
            
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ip_address), ip_port);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);

            input_encoded = Encoding.ASCII.GetBytes(input);
            server.SendTo(input_encoded, input_encoded.Length, SocketFlags.None, ip);
            Console.WriteLine("Sending command: " + send_data);
            Console.WriteLine("To: " + ip_address + ":" + ip_port.ToString());

            server.Close();
        }

        static void Main(string[] args){
            udp_client("Hello From Beyond");
        }
    }
}