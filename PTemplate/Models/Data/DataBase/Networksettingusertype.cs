using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networksettingusertype
    {
        public Networksettingusertype()
        {
            Networksettingusers = new HashSet<Networksettinguser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int? Type { get; set; }
        public bool? Ispreview { get; set; }

        public virtual ICollection<Networksettinguser> Networksettingusers { get; set; }
    }
}
