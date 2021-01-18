using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Driver
    {
        public long Id { get; set; }
        public long? Iduser { get; set; }
        public bool? State { get; set; }
        public bool? Isactive { get; set; }
        public byte? Idtype { get; set; }
        public DateTime? Datecrate { get; set; }
        public bool? Cancel { get; set; }
        public string Plack { get; set; }
        public string Namedriver { get; set; }
        public bool? Viewdriver { get; set; }
    }
}
