using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Data.DB
{
    public class subfactorlist
    {

        [System.ComponentModel.DataAnnotations.Key]
        public Guid idfactor { get; set; }
        public Guid idfactorsub { get; set; }
        public long idproduct { get; set; }

        public string title { get; set; }
        public string posttext { get; set; }
        public string postdescription { get; set; }
        public string pathdata { get; set; }

        public decimal productprice { get; set; }
        //--p.[count] as productcount { get; set; }
        public int productcount { get; set; }
        public long countfactorsub { get; set; }
        public decimal factorsubmoney { get; set; }
        public decimal offpercent { get; set; }
        public DateTime? factorsubdatecreate { get; set; }
        public long idproductcolor { get; set; }
        public Decimal moneypost { get; set; }



    }
}
