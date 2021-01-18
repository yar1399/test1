using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    [DataContract]
    public class listcontend
    {
        [DataMember]
        public string mobile { get; set; }

        [DataMember]
        public string name { get; set; }

    }
}
