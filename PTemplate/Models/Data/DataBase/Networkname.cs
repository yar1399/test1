using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkname
    {
        public Guid Id { get; set; }
        public long? Idnetwork { get; set; }
        public string Name { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
