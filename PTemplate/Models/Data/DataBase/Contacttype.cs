using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Contacttype
    {
        public Contacttype()
        {
            Contacts = new HashSet<Contact>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
