using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Logger
{
    internal class SocketLogger : ILogger
    {
        private readonly ClientSocket ClientSocket;

        public SocketLogger(string host, int port)
        {
            ClientSocket = new ClientSocket(host, port);
        }
        public void Log(params string[] messages)
        {
            foreach (var m in messages)
            {
                using (ClientSocket)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(m);
                    ClientSocket.Send(bytes);
                }
            }
        }
        public void Dispose()
        {
            ClientSocket.Close();
            GC.SuppressFinalize(this);
        }

    }
}
