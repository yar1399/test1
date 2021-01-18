using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Menu
    {
        public Menu()
        {
            Posts = new HashSet<Post>();
            Productmenuinfos = new HashSet<Productmenuinfo>();
            Products = new HashSet<Product>();
            Productsubmenus = new HashSet<Productsubmenu>();
        }

        public long Id { get; set; }
        public byte? Idmenugroup { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Isactive { get; set; }

        public virtual Menugroup IdmenugroupNavigation { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Productmenuinfo> Productmenuinfos { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Productsubmenu> Productsubmenus { get; set; }
    }
}
