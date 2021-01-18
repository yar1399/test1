using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Color1
    {
        public Color1()
        {
            Productcolors = new HashSet<Productcolor>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Descrition { get; set; }

        public virtual ICollection<Productcolor> Productcolors { get; set; }
    }
}
