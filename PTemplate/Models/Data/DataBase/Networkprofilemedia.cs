using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Networkprofilemedia
    {
        public long Id { get; set; }
        public string Path { get; set; }
        public byte? Idtype { get; set; }
        public string Description { get; set; }
        public long? Idnetwork { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
