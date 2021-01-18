using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Profileuserdescription
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public string Discription { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
