using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendFundamentals.Protocols
{
    public interface IUdp
    {
        public void CreateUdpServer();
        public void OnConnect();
        public void OnDisconnect();
        public void OnReceive(byte[] data);
        public void OnSend(byte[] data);

    }
}
