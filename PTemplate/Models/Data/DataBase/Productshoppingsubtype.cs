using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productshoppingsubtype
    {
        public Guid Id { get; set; }
        public int? Idproductshoppingtype { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Productshoppingtype IdproductshoppingtypeNavigation { get; set; }
    }
}
