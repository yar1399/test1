using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Payporsant
    {
        public Guid Id { get; set; }
        public long? Idyarpartner { get; set; }
        public DateTime? Datestart { get; set; }
        public DateTime? Dateend { get; set; }
        public decimal? Money { get; set; }
        public string Shenasepardakht { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Yarpartner IdyarpartnerNavigation { get; set; }
    }
}
