using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Networkname1
    {
        public long Id { get; set; }
        public string Iduser { get; set; }
        public string Name { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
