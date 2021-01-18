using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Product
    {
        public Product()
        {
            Factorsubs = new HashSet<Factorsub>();
            Productcolors = new HashSet<Productcolor>();
            Productdata = new HashSet<Productdatum>();
            Productinfos = new HashSet<Productinfo>();
        }

        public long Id { get; set; }
        public long? Idmenu { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Datecreate { get; set; }
        public bool? Isactive { get; set; }
        public string Description { get; set; }
        public decimal? Moneypost { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public virtual Menu IdmenuNavigation { get; set; }
        public virtual ICollection<Factorsub> Factorsubs { get; set; }
        public virtual ICollection<Productcolor> Productcolors { get; set; }
        public virtual ICollection<Productdatum> Productdata { get; set; }
        public virtual ICollection<Productinfo> Productinfos { get; set; }
    }
}
