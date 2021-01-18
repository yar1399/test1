using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Factor
    {
        public Guid Id { get; set; }
        public long? Iduser { get; set; }
        public Guid? Idfactorrequest { get; set; }
        public long? Idnetwork { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
