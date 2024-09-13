using NetworkUtility.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        private readonly IDNS dNS;

        public NetworkService(IDNS dNS)
        {
            this.dNS = dNS;
        }


        public string SendPing()
        {

            var dnsSuccess = dNS.SendDNS();

            if(dnsSuccess)
                return "Success : Ping Sent !";
            else
                return "Failed : Ping not Sent !";


        }

        public int PingTime(int a , int b)
        {
            return a + b;
        }

        //Testing Objects

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };


        }

        //Testing DateTime

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        // Testing IEnumerable

        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new List<PingOptions>()
             {
                 new PingOptions()
                 {
                DontFragment = true,
                Ttl = 1
                 },
                 new PingOptions()
                 {
                DontFragment = true,
                Ttl = 1
                 },
                 new PingOptions()
                 {
                DontFragment = true,
                Ttl = 1
                 },
                 new PingOptions()
                 {
                DontFragment = true,
                Ttl = 1
                 }

             };
            return pingOptions;




        }


    }
}
