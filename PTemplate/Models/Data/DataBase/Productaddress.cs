using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productaddress
    {
        public Productaddress()
        {
            Factor1s = new HashSet<Factor1>();
        }

        public long Id { get; set; }
        public string Iduser { get; set; }
        public string Namefamily { get; set; }
        public string Tell { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isactivebase { get; set; }
        public DateTime? Createdate { get; set; }

        public virtual ICollection<Factor1> Factor1s { get; set; }
    }
}
