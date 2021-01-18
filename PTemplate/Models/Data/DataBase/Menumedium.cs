using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Menumedium
    {
        public Guid Id { get; set; }
        public Guid? Idmenu { get; set; }
        public byte? Idmenumediatype { get; set; }
        public string Path { get; set; }

        public virtual Menu1 IdmenuNavigation { get; set; }
        public virtual Menumediatype IdmenumediatypeNavigation { get; set; }
    }
}
