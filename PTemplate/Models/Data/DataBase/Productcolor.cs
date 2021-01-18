using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productcolor
    {
        public Productcolor()
        {
            Factorsubs = new HashSet<Factorsub>();
        }

        public long? Id { get; set; }
        public byte? Idcolor { get; set; }
        public long? Idproduct { get; set; }
        public int? Count { get; set; }

        public virtual Color1 IdcolorNavigation { get; set; }
        public virtual Product IdproductNavigation { get; set; }
        public virtual ICollection<Factorsub> Factorsubs { get; set; }
    }
}
