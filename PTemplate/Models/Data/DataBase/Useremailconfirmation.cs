using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Useremailconfirmation
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public string Codeverification { get; set; }
        public string Email { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
