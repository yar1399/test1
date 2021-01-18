using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Usermedia
    {
        public long Id { get; set; }
        public long? Idnetwork { get; set; }
        public byte? Idusermediatype { get; set; }
        public bool? Isactive { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public DateTime? Datecreate { get; set; }
        public bool? Mojaze { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
    }
}
