using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networktype
    {
        public Networktype()
        {
            Networks = new HashSet<Network>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Network> Networks { get; set; }
    }
}
