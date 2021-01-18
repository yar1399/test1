using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkshopping
    {
        public long Id { get; set; }
        public long? Idnetwork { get; set; }
        public int? Idproductshoppingtype { get; set; }
        public bool? Isactive { get; set; }

        public virtual Network IdnetworkNavigation { get; set; }
        public virtual Productshoppingtype IdproductshoppingtypeNavigation { get; set; }
    }
}
