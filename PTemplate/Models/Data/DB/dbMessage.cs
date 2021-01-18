using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Data.DB
{
    [Keyless]
    public class dbMessage
    {
        
        public Int32 idcode { set; get; }
        public string message { set; get; }
        public Int32 code { set; get; }
    }
}
