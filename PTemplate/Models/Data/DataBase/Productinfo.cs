using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productinfo
    {
        public long Id { get; set; }
        public long? Idproductmenuinfo { get; set; }
        public long? Idproduct { get; set; }
        public string Description { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Product IdproductNavigation { get; set; }
        public virtual Productmenuinfo IdproductmenuinfoNavigation { get; set; }
    }
}
