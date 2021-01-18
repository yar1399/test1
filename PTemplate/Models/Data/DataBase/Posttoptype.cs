using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Posttoptype
    {
        public Posttoptype()
        {
            Posts = new HashSet<Post>();
            Posttops = new HashSet<Posttop>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Posttop> Posttops { get; set; }
    }
}
