using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Shoppingtype
    {
        public Shoppingtype()
        {
            Productshoppingtypes = new HashSet<Productshoppingtype>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }

        public virtual ICollection<Productshoppingtype> Productshoppingtypes { get; set; }
    }
}
