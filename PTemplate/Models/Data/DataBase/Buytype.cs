using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Buytype
    {
        public Buytype()
        {
            Buyusertimes = new HashSet<Buyusertime>();
        }

        public long Id { get; set; }
        public int? Idbuysoftwaremodel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Daycounts { get; set; }
        public DateTime? Datestart { get; set; }
        public DateTime? Dateend { get; set; }
        public decimal? Money { get; set; }
        public string Pathcover { get; set; }
        public string Pathlogo { get; set; }
        public bool? Isactive { get; set; }

        public virtual Buysoftwaremodel IdbuysoftwaremodelNavigation { get; set; }
        public virtual ICollection<Buyusertime> Buyusertimes { get; set; }
    }
}
