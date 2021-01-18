using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Payment
{
    public class Verify
    {
        public bool isVerify { set; get; }
        public string message { set; get; }
        public long refid { set; get; }
    }
}
