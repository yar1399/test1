using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class productshoppingtypelist
    {

        [Key]
        public Nullable<long> idnetwork { get; set; }
        public string namenetwork{ get; set; }
        public string imgavatar { get; set; }
        public string imgheader { get; set; }
        public string geo { get; set; }
        public Nullable<double> distance { get; set; }
        public Nullable<decimal> money { get; set; }

                             
        public Nullable<int> idshoppingtype { get; set; }
        public string nameshoppingtype { get; set; }

    }
}
