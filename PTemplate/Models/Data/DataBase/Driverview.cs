using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Driverview
    {
        public Guid Id { get; set; }
        public long? Iduser { get; set; }
        public bool? IsActive { get; set; }
        public long? Idnetwork { get; set; }
    }
}
