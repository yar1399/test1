using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Menumediatype
    {
        public Menumediatype()
        {
            Menumedia = new HashSet<Menumedium>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Menumedium> Menumedia { get; set; }
    }
}
