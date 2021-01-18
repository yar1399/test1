using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkpost
    {
        public long Id { get; set; }
        public byte? Idposttype { get; set; }
        public long? Idnetwork { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
