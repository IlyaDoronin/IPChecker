using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IpChecker
{
    class Net
    {
        public bool Connect()
        { 
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com");
                return true;
            }
            catch
            { return false; }
        }
    }
}
