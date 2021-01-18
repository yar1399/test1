using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Menu1
    {
        public Menu1()
        {
            Menumedia = new HashSet<Menumedium>();
        }

        public Guid Id { get; set; }
        public long? Idnetwork { get; set; }
        public int? Idshoppingunit { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Money { get; set; }
        public decimal? Moneyuser { get; set; }
        public DateTime? Datestart { get; set; }
        public DateTime? Dateend { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
        public virtual Shoppingunit IdshoppingunitNavigation { get; set; }
        public virtual ICollection<Menumedium> Menumedia { get; set; }
    }
}
