using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.DB
{
    public class productautocompletelistmenu
    {
        [System.ComponentModel.DataAnnotations.Key]
        public Int64 idmenu { get; set; }

        public string name { get; set; }

    }
}
