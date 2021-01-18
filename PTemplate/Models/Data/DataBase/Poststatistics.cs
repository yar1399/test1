using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Poststatistics
    {
        public long Id { get; set; }
        public long? Idpost { get; set; }
        public int? Countview { get; set; }
        public DateTime? Dateday { get; set; }
    }
}
