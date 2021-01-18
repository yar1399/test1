using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics.DB
{
    [Table("StReffer")]
    public class tbl_StReffer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شماره")]
        public int ID { get; set; }
        public string Address { get; set; }
        public int No { get; set; }
        public Boolean Spider { get; set; }
    }
}
