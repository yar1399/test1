using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Shoppingunit
    {
        public Shoppingunit()
        {
            Menu1s = new HashSet<Menu1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Menu1> Menu1s { get; set; }
    }
}
