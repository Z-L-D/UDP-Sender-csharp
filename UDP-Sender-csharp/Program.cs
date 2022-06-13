using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

class program
{
    static void Main(string[] args)
    {
        string command = "Hello from C#";
        string address = "127.0.0.1";
        int port = 5500;

        IPEndPoint ip_object = new IPEndPoint(IPAddress.Parse(address), port);
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        byte[] command_encoded = new byte[1024];
        command_encoded = Encoding.ASCII.GetBytes(command);
        server.SendTo(command_encoded, command_encoded.Length, SocketFlags.None, ip_object);
        server.Close();
    }
}