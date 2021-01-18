using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class State
    {
        public string Iduser { get; set; }
        public long? Idnetwork { get; set; }
        public byte? Idstatetype { get; set; }
        public DateTime? Datecreate { get; set; }
        public Guid? Idorder { get; set; }

        public virtual Menuorder IdorderNavigation { get; set; }
        public virtual Statetype IdstatetypeNavigation { get; set; }
    }
}
