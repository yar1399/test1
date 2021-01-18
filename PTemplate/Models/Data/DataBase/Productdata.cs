using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Productdata
    {
        public long Id { get; set; }
        public long? Idproduct { get; set; }
        public byte? Iddatatype { get; set; }
        public string Pathdata { get; set; }
        public bool? Isactive { get; set; }
        public string Description { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Productdatatype IddatatypeNavigation { get; set; }
        public virtual Product IdproductNavigation { get; set; }
    }
}
