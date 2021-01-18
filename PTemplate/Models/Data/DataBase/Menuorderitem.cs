using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Menuorderitem
    {
        public Guid Id { get; set; }
        public Guid? Idmenuorder { get; set; }
        public string Productbarcode { get; set; }
        public string Name { get; set; }
        public decimal? Money { get; set; }
        public decimal? Moneyuser { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? Datecreate { get; set; }
        public int? Counter { get; set; }

        public virtual Menuorder IdmenuorderNavigation { get; set; }
    }
}
