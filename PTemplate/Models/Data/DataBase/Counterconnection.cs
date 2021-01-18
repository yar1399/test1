using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Counterconnection
    {
        public Guid Id { get; set; }
        public string Idsystem { get; set; }
        public byte? Counter { get; set; }
        public string Iduser { get; set; }
        public byte? Idsoftwaremodel { get; set; }
    }
}
