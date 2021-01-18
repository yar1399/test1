using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkprofilemediatype
    {
        public Networkprofilemediatype()
        {
            Networkprofilemedia = new HashSet<Networkprofilemedium>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Networkprofilemedium> Networkprofilemedia { get; set; }
    }
}
