using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Factorauthority
    {
        public long Id { get; set; }
        public string Authority { get; set; }
        public string Iduser { get; set; }
        public Guid? Idfactor { get; set; }
        public string Refid { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Factor1 IdfactorNavigation { get; set; }
    }
}
