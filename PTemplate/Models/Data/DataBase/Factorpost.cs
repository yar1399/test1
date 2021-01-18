using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Factorpost
    {
        public long Id { get; set; }
        public string Codefollowup { get; set; }
        public decimal? Money { get; set; }
        public string IduserCreator { get; set; }
        public string Iduserpost { get; set; }
        public DateTime? Datecreate { get; set; }
        public DateTime? Datepost { get; set; }
        public Guid? Idfactor { get; set; }
        public byte? Idfactorposttype { get; set; }
        public bool? Isbus { get; set; }
        public bool? Isfinesh { get; set; }

        public virtual Factor1 IdfactorNavigation { get; set; }
        public virtual Factorposttype IdfactorposttypeNavigation { get; set; }
    }
}
