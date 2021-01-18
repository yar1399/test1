using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productshoppingtype
    {
        public Productshoppingtype()
        {
            Networkshoppings = new HashSet<Networkshopping>();
            Productshoppingsubtypes = new HashSet<Productshoppingsubtype>();
        }

        public int Id { get; set; }
        public int? Idshopingtype { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public bool? Isactive { get; set; }

        public virtual Shoppingtype IdshopingtypeNavigation { get; set; }
        public virtual ICollection<Networkshopping> Networkshoppings { get; set; }
        public virtual ICollection<Productshoppingsubtype> Productshoppingsubtypes { get; set; }
    }
}
