using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Yarpartnerporsant
    {
        public Yarpartnerporsant()
        {
            Yarpartnerusers = new HashSet<Yarpartneruser>();
        }

        public long Id { get; set; }
        public decimal? Percent { get; set; }
        public long? Idyarpartner { get; set; }
        public byte? Idsoftwaremodel { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Softwaremodel IdsoftwaremodelNavigation { get; set; }
        public virtual Yarpartner IdyarpartnerNavigation { get; set; }
        public virtual ICollection<Yarpartneruser> Yarpartnerusers { get; set; }
    }
}
