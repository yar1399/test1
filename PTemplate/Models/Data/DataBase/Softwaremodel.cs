using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Softwaremodel
    {
        public Softwaremodel()
        {
            Buysoftwaremodels = new HashSet<Buysoftwaremodel>();
            Comments = new HashSet<Comment>();
            Contacts = new HashSet<Contact>();
            Options = new HashSet<Option>();
            Pays = new HashSet<Pay>();
            Yarpartnerporsants = new HashSet<Yarpartnerporsant>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Buysoftwaremodel> Buysoftwaremodels { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<Pay> Pays { get; set; }
        public virtual ICollection<Yarpartnerporsant> Yarpartnerporsants { get; set; }
    }
}
