using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Menuorder
    {
        public Menuorder()
        {
            Menuorderitems = new HashSet<Menuorderitem>();
        }

        public Guid Id { get; set; }
        public long? Idnetwork { get; set; }
        public string Iduser { get; set; }
        public DateTime? Datecreate { get; set; }
        public byte? Idordertype { get; set; }
        public decimal? Moneypeyk { get; set; }

        public virtual ICollection<Menuorderitem> Menuorderitems { get; set; }
    }
}
