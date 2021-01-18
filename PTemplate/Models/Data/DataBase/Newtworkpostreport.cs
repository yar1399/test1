using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Newtworkpostreport
    {
        public Guid Id { get; set; }
        public long? Idpost { get; set; }
        public byte? Idtypereport { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
