using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Musle
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public bool? Isbase { get; set; }
        public bool? Ismove { get; set; }
        public bool? Isactive { get; set; }
    }
}
