using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics.DB
{
    [Table("StUsers")]
    public class tbl_StUsers
    {

        public tbl_StUsers()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int StID { get; set; }
        public string KeyID { get; set; }
        public int BroserID { get; set; }
        public int osID { get; set; }
        public string iduser { get; set; }


        [ForeignKey("BroserID")]
        public tbl_Browsers tbl_Browsers { set; get; }

        [ForeignKey("osID")]
        public tbl_OSs tbl_OSs  { set; get; }

        [ForeignKey("StID")]
        public virtual tbl_Statestics tbl_Statestics { set; get; }


        public virtual ICollection<tbl_StatesticsDetils> tbl_StatesticsDetils { set; get; }
    }
}
