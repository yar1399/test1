using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics.DB
{
    [Table("Statestics")]
    public class tbl_Statestics
    {
        public tbl_Statestics()
        {
            tbl_StUsers = new HashSet<tbl_StUsers>();
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شماره")]
        public int ID { get; set; }

        [Display(Name ="روز")]
        [Required]
        [DisplayFormat(DataFormatString ="yyyy-mm-dd 00:00:00")]
        public DateTime Day { get; set; }



        [Display(Name = "تعداد")]
        [Required]
        [DisplayFormat(DataFormatString = "d3")]
        public int Counter { get; set; }


        public virtual ICollection<tbl_StUsers> tbl_StUsers { set; get; }


    }
}
