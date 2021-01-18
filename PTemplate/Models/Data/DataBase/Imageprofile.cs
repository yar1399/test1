using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Imageprofile
    {
        public int Id { get; set; }
        public string Iduser { get; set; }
        public string Path { get; set; }
        public bool? Isactive { get; set; }
    }
}
