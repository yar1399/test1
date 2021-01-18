using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkuserupdate
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public DateTime? Datecreate { get; set; }
        public byte? Idstate { get; set; }
    }
}
