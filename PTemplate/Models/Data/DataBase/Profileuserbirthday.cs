using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Profileuserbirthday
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
