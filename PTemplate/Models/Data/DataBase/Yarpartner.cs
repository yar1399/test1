using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Yarpartner
    {
        public Yarpartner()
        {
            Payporsants = new HashSet<Payporsant>();
            Yarpartnerporsants = new HashSet<Yarpartnerporsant>();
            Yarpartnerusers = new HashSet<Yarpartneruser>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Imagelogo { get; set; }
        public string Description { get; set; }
        public DateTime? Datecreate { get; set; }
        public string Wad { get; set; }

        public virtual ICollection<Payporsant> Payporsants { get; set; }
        public virtual ICollection<Yarpartnerporsant> Yarpartnerporsants { get; set; }
        public virtual ICollection<Yarpartneruser> Yarpartnerusers { get; set; }
    }
}
