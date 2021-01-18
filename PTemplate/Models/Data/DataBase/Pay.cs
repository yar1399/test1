using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Pay
    {
        public int Id { get; set; }
        public string Iduser { get; set; }
        public decimal? Price { get; set; }
        public string State { get; set; }
        public DateTime? Datecreate { get; set; }
        public byte? Idbank { get; set; }
        public string Authority { get; set; }
        public bool? Ispayment { get; set; }
        public byte? Idsoftwaremodel { get; set; }
        public long? Idbuytype { get; set; }

        public virtual Banktype IdbankNavigation { get; set; }
        public virtual Softwaremodel IdsoftwaremodelNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
