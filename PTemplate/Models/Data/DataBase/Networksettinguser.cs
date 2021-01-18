using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networksettinguser
    {
        public long Id { get; set; }
        public int? Idnetworksettingusertype { get; set; }
        public long? Idnetwork { get; set; }
        public DateTime? Datecreate { get; set; }
        public bool? Isactive { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
        public virtual Networksettingusertype IdnetworksettingusertypeNavigation { get; set; }
    }
}
