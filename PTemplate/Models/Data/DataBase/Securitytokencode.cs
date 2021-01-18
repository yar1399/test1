using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Securitytokencode
    {
        public Guid Id { get; set; }
        public string Idsystem { get; set; }
        public string Number { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
