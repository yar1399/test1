using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class LockCounter
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public DateTime? Datecreate { get; set; }
        public byte? Idsoftwaremodel { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
