using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productmenuinfo
    {
        public Productmenuinfo()
        {
            Productinfos = new HashSet<Productinfo>();
        }

        public long? Id { get; set; }
        public long? Idsubmenu { get; set; }
        public string Title { get; set; }
        public DateTime? Date { get; set; }
        public byte? Number { get; set; }

        public virtual Menu IdsubmenuNavigation { get; set; }
        public virtual ICollection<Productinfo> Productinfos { get; set; }
    }
}
