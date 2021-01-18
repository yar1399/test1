using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Profileuserphone
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public string Phonenumber { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
