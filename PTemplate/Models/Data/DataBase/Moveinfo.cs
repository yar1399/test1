using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Moveinfo
    {
        public int Id { get; set; }
        public int? Idmove { get; set; }
        public byte? IdmoveType { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isgender { get; set; }

        public virtual Move IdmoveNavigation { get; set; }
        public virtual Moveinfotype IdmoveTypeNavigation { get; set; }
    }
}
