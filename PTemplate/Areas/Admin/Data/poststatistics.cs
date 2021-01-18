using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Areas.Admin.Data
{
    public class poststatistics
    {
        public long idpost { get; set; }
        public int countview { get; set; }
        [Key]
        public DateTime dateday { get; set; }

        public poststatistics getpoststatistics()
        {
            countview += 1;
            return this;
        }

    }
}
