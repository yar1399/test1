using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Yarpartneruser
    {
        public Guid Id { get; set; }
        public long? Iduser { get; set; }
        public long? Idyarpartner { get; set; }
        public long? Idyarpartnerporsant { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual Yarpartner IdyarpartnerNavigation { get; set; }
        public virtual Yarpartnerporsant IdyarpartnerporsantNavigation { get; set; }
    }
}
