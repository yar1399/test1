using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics.DB
{
    [Table("StatesticsDetils")]
    public class tbl_StatesticsDetils
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Ip { get; set; }
        public DateTime Date { get; set; }
        public String Reffer { get; set; }
        public String Url { get; set; }
        public String City { get; set; }
        public String Country { get; set; }

        [ForeignKey("UserID")]
        public virtual tbl_StUsers tbl_StUsers { set; get; }
    }
}
