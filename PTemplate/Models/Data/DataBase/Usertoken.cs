using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Usertoken
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public byte? Idostype { get; set; }
        public Guid? Token { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Ostype IdostypeNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
