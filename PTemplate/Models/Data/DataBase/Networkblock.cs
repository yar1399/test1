using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkblock
    {
        public string Iduser { get; set; }
        public long? Idnetworkblock { get; set; }
        public bool? State { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
