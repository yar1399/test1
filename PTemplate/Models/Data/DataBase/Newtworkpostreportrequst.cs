using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Newtworkpostreportrequst
    {
        public Guid Id { get; set; }
        public long? Idpost { get; set; }
        public string Iduser { get; set; }
        public DateTime? Datecreate { get; set; }
        public byte? Idreporttype { get; set; }
        public bool? State { get; set; }
    }
}
