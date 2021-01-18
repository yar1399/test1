using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkprofilemedium
    {
        public long Id { get; set; }
        public string Path { get; set; }
        public byte? Idtype { get; set; }
        public string Description { get; set; }
        public long? Idnetwork { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
        public virtual Networkprofilemediatype IdtypeNavigation { get; set; }
    }
}
