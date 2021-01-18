using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Data.DB
{
    public class productStory
    {
        public int totalrows { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public long idproduct { get; set; }
        //public long idpost { get; set; }
        public string title { get; set; }
        public string pathdata { get; set; }
        public decimal price { get; set; }
        public int mojudi { get; set; }
        public string productdescription { get; set; }
    }
}
