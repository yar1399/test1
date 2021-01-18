using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class NamgetnamelistbycolorandfamilyResult
    {
        [Key]
     public string  name { get; set; }

     public string  meaning { get; set; }
        public string color { get; set; }

    }
}
