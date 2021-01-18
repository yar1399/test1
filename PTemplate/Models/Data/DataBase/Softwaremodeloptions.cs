using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Softwaremodeloptions
    {
        public Guid Id { get; set; }
        public int? Idoptions { get; set; }
        public string Iduser { get; set; }

        public virtual Options IdoptionsNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
