using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Factorsub
    {
        public Guid Id { get; set; }
        public long? Idproduct { get; set; }
        public Guid? Idfactor { get; set; }
        public long? Idproductcolor { get; set; }
        public long Count { get; set; }
        public decimal? Money { get; set; }
        public decimal? Offpercent { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Factor1 IdfactorNavigation { get; set; }
        public virtual Product IdproductNavigation { get; set; }
        public virtual Productcolor IdproductcolorNavigation { get; set; }
    }
}
