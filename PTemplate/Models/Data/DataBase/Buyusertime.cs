using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Buyusertime
    {
        public Buyusertime()
        {
            InverseIdparentNavigation = new HashSet<Buyusertime>();
        }

        public long Id { get; set; }
        public long? Idparent { get; set; }
        public string Iduser { get; set; }
        public int? Idbuysoftwaremodel { get; set; }
        public long? Idbuytype { get; set; }
        public int? Idpaybank { get; set; }
        public DateTime? Datestart { get; set; }
        public DateTime? Dateend { get; set; }
        public bool? Isactive { get; set; }

        public virtual Buysoftwaremodel IdbuysoftwaremodelNavigation { get; set; }
        public virtual Buytype IdbuytypeNavigation { get; set; }
        public virtual Buyusertime IdparentNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
        public virtual ICollection<Buyusertime> InverseIdparentNavigation { get; set; }
    }
}
