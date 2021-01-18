using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Banktype
    {
        public Banktype()
        {
            Bankstates = new HashSet<Bankstate>();
            Pays = new HashSet<Pay>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Bankstate> Bankstates { get; set; }
        public virtual ICollection<Pay> Pays { get; set; }
    }
}
