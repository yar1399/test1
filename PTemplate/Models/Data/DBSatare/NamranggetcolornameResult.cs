using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class NamranggetcolornameResult
    {
        [Key]
        public int number { get; set; }
        public string colorname { get; set; }
        public string description { get; set; }

        public string color { get; set; }
    }
}
