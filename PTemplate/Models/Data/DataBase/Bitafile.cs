using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Bitafile
    {
        public int Id { get; set; }
        public string Iduser { get; set; }
        public string Name { get; set; }
        public string Namefile { get; set; }
        public DateTime? Datecreate { get; set; }
    }
}
