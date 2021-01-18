using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkdescription
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long? Idnetwork { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
    }
}
