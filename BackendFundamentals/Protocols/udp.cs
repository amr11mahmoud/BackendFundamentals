using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace BackendFundamentals.Protocols
{
    public class Udp : IUdp, IDisposable
    {
        private const int listenPort = 5500;
        byte[] buffer = new byte[1024];

        public void CreateUdpServer()
        {
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);

            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting for broadcast ...........");
                    byte[] bytes = listener.Receive(ref groupEP);

                    Console.WriteLine($"Received broadcast from {groupEP} :");
                    Console.WriteLine($" {Encoding.ASCII.GetString(bytes, 0, bytes.Length)}");

                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                listener.Close();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnConnect()
        {
            throw new NotImplementedException();
        }

        public void OnDisconnect()
        {
            throw new NotImplementedException();
        }

        public void OnReceive(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void OnSend(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void Send()
        {
            Console.WriteLine("hello");
        }
    }
}
