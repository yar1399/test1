using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Subfactor
    {
        public Guid Id { get; set; }
        public Guid? Idfactor { get; set; }
        public Guid? Idmenu { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
