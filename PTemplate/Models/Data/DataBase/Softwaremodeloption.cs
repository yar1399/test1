using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Softwaremodeloption
    {
        public Guid Id { get; set; }
        public int? Idoptions { get; set; }
        public string Iduser { get; set; }

        public virtual Option IdoptionsNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
