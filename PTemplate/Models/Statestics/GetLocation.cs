using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics
{
    public class GetLocation
    {
        public IpInfo get(string ip)
        {
            try
            {
                if (ip == "::1" || ip == "127.0.0.1")
                    return null;
                WebClient web = new WebClient();
                string jason = web.DownloadString("http://ip-api.com/json/" + ip + "?callback");
                IpInfo info = JsonConvert.DeserializeObject<IpInfo>(jason);
                return info;
            }
            catch
            {
                return null;
            }
           
        }
    }
}
