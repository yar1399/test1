using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productpaytype
    {
        public Productpaytype()
        {
            Factor1s = new HashSet<Factor1>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Createdate { get; set; }

        public virtual ICollection<Factor1> Factor1s { get; set; }
    }
}
