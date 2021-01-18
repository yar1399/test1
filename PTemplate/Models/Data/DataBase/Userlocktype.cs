using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Userlocktype
    {
        public Userlocktype()
        {
            Userlocks = new HashSet<Userlock>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Userlock> Userlocks { get; set; }
    }
}
