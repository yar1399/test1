using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkrequestuser
    {
        public Guid Id { get; set; }
        public long? Idtellcontent { get; set; }
        public long? Iduser { get; set; }
        public long? Iduserbase { get; set; }
        public byte? Idstate { get; set; }
        public DateTime? Datecrate { get; set; }
    }
}
