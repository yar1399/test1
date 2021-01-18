using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Vip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Days { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool? Isactive { get; set; }
    }
}
