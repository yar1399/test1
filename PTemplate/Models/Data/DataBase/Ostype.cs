using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Ostype
    {
        public Ostype()
        {
            Usertokens = new HashSet<Usertoken>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Usertoken> Usertokens { get; set; }
    }
}
