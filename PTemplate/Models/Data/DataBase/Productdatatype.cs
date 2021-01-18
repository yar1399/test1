using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productdatatype
    {
        public Productdatatype()
        {
            Productdata = new HashSet<Productdatum>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Productdatum> Productdata { get; set; }
    }
}
