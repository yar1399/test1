using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Driveravatare
    {
        public Guid Id { get; set; }
        public long? Iduser { get; set; }
        public string Path { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
