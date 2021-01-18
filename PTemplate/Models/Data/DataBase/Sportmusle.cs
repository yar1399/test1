using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Sportmusle
    {
        public int Id { get; set; }
        public int? Idmusle { get; set; }
        public int? Idsport { get; set; }
        public string Image { get; set; }
        public bool? Isactive { get; set; }
    }
}
