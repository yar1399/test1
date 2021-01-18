using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class UserRoles
    {
        public long Id { get; set; }
        public string Iduser { get; set; }
        public byte? Idroles { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isdelete { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Deletedate { get; set; }

        public virtual Role IdrolesNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
