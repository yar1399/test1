using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Usertellconfirmation
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public string Codeverification { get; set; }
        public string Tell { get; set; }
        public DateTime? Datecreate { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isdelete { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
