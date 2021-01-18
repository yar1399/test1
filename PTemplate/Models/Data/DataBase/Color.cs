using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Color
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Weight { get; set; }
        public string Color1 { get; set; }
    }
}
