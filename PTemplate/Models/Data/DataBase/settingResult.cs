using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DataBase
{
    [Keyless]
    public class settingResult
    {
       
        public int id
        {
            get; set;
        }

        public String name
        {
            get; set;
        }

        public int isactive
        {
            get; set;
        }
    }
}
