using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Productsub
    {
        public Guid Id { get; set; }
        public byte? Idmenu { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Menugroup IdmenuNavigation { get; set; }
    }
}
