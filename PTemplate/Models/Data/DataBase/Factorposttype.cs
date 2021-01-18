using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Factorposttype
    {
        public Factorposttype()
        {
            Factorposts = new HashSet<Factorpost>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Factorpost> Factorposts { get; set; }
    }
}
