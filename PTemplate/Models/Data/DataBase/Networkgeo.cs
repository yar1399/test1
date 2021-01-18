using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkgeo
    {
        public long? Idnetwork { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
    }
}
