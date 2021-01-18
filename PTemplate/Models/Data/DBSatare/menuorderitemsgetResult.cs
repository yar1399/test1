using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class menuorderitemsgetResult
    {
        [Key]
        public Guid id { get; set; }
        public string productbarcode { get; set; }
        public string name{ get; set; }
        public System.Nullable<decimal> money{ get; set; }
        public System.Nullable<decimal> moneyuser{ get; set; }
        public System.Nullable<decimal> discount { get; set; }
        public System.Nullable<int> counter { get; set; }
        public DateTime datecreate { get; set; }
    }
}
