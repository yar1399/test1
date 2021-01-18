using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Social
    {
        public Social()
        {
            Socialwebs = new HashSet<Socialweb>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public string Tag { get; set; }

        public virtual ICollection<Socialweb> Socialwebs { get; set; }
    }
}
