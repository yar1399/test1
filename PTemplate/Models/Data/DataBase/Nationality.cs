using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Nationality
    {
        public Nationality()
        {
            Names = new HashSet<Name>();
            Nameuserentries = new HashSet<Nameuserentry>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Name> Names { get; set; }
        public virtual ICollection<Nameuserentry> Nameuserentries { get; set; }
    }
}
