using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class productshoppingsubtypeautocompletelist
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int idproductshoppingtype { get; set; }
        public string nameproductshoppingtype { get; set; }
        public string name { get; set; }
        public int idshopingtype { get; set; }
        public string nameshoppingtype { get; set; }


    }
}
