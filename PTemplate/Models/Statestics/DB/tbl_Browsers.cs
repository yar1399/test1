using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics.DB
{
    [Table("tbl_Browsers")]
    public class tbl_Browsers
    {
        public tbl_Browsers()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شماره")]
        public int ID { get; set; }


        [Display(Name = "نام عکس")]
        public string ImageName { get; set; }
        [Display(Name = "کلید مرورگر")]
        public string BrowsersKey { get; set; }


        [Display(Name = "نام مرور گر")]
        public string BrowsersName { get; set; }


        public ICollection<tbl_StUsers> tbl_StUsers { set; get; }
       
    }
}
