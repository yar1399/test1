using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Productsubmenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? Idmenu { get; set; }

        public virtual Menu IdmenuNavigation { get; set; }
    }
}
