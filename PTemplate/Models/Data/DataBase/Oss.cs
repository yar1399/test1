using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Oss
    {
        public Oss()
        {
            StUsers = new HashSet<StUser>();
        }

        public int Id { get; set; }
        public string ImageName { get; set; }
        public string Oskey { get; set; }
        public string Osname { get; set; }
        public string OsnameFa { get; set; }
        public string Tag { get; set; }
        public string Color { get; set; }

        public virtual ICollection<StUser> StUsers { get; set; }
    }
}
