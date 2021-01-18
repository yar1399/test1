using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class stategetResult
    {
        [Key]
        public System.Nullable< int> idcode { get; set; }
        public string message { get; set; }
        public System.Nullable<int> code { get; set; }
        public System.Nullable<DateTime> datecreate { get; set; }
        public System.Nullable<byte> idstatetype { get; set; }
    }
}
