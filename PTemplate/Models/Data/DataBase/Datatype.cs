using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Datatype
    {
        public Datatype()
        {
            Postdata = new HashSet<Postdatum>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Postdatum> Postdata { get; set; }
    }
}
