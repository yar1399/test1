using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Postdata
    {
        public long Id { get; set; }
        public long? Idpost { get; set; }
        public byte? Iddatatype { get; set; }
        public string Pathdata { get; set; }
        public bool? Isactive { get; set; }
        public string Description { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Datatype IddatatypeNavigation { get; set; }
        public virtual Post IdpostNavigation { get; set; }
    }
}
