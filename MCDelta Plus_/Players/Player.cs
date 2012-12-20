using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace MCDelta_Plus
{
    class Player
    {
        public string Username { get; set;}
        public string ID { get; set;}
        public string IP { get; set;}
        public bool Op = false;
        public bool Banned = false;       
        
        public Socket socket;
        internal Player(TcpClient tcpclient)
        {
            Server.Log(Username + "Has just Joined The Server");
            socket = tcpclient.Client;
            try
            {
               
            }
            catch { }
        }
    }
}
