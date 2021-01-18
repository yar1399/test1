using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Posttop
    {
        public long Id { get; set; }
        public string Iduser { get; set; }
        public long? Idpost { get; set; }
        public byte? Idtype { get; set; }
        public DateTime? Datecreate { get; set; }
        public DateTime? Datestart { get; set; }
        public DateTime? Dateend { get; set; }
        public bool? Isdatestart { get; set; }
        public bool? Isactive { get; set; }

        public virtual Post IdpostNavigation { get; set; }
        public virtual Posttoptype IdtypeNavigation { get; set; }
    }
}
