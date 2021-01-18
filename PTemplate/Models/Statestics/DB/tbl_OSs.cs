using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics.DB
{

    [Table("OSs")]
    public class tbl_OSs
    {
        public tbl_OSs()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "شماره")]
        public int ID { get; set; }
        [Display(Name = "نام عکس")]
        public string ImageName { get; set; }
        [Display(Name = "کلید سیستم عامل")]
        public string OSKey { get; set; }
        [Display(Name = "نام سیستم عامل")]
        public string OSName { get; set; }



        public ICollection<tbl_StUsers> tbl_StUsers { set; get; }
      //  public tbl_Browsers tbl_Browsers { set; get; }


    }
}
