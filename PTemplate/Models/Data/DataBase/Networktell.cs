using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networktell
    {
        public long Id { get; set; }
        public long? Idnetwork { get; set; }
        public string Tell { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
    }
}
