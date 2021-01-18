using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class UserSecruity:dbMessage
    {
        [Key]
       public string iduser { get;set; }
       public string token { get; set; }
    }
}
