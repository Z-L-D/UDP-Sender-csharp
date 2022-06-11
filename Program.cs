using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Project
{
    class program
    {
        public static void udp_client(string var_a)
        {
            byte[] input_enc = new byte[1024];

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 55398);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);

            string input = var_a;

            input_enc = Encoding.ASCII.GetBytes(input);
            server.SendTo(input_enc, input_enc.Length, SocketFlags.None, ip);
            Console.WriteLine("Sending command: " + var_a);

            server.Close();
        }

        static void Main(string[] args){
            udp_client("Hello From Beyond");
        }
    }
}