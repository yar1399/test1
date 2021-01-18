using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkuser
    {
        public string Iduser { get; set; }
        public byte? Idstate { get; set; }
        public long? IdnetworkBase { get; set; }
        public byte? Idtype { get; set; }
        public string Nicname2 { get; set; }
        public DateTime? Datecrate { get; set; }
    }
}
