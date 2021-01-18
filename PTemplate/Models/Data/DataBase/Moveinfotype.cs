using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Moveinfotype
    {
        public Moveinfotype()
        {
            Moveinfos = new HashSet<Moveinfo>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Moveinfo> Moveinfos { get; set; }
    }
}
