using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Bankuser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Namebank { get; set; }
        public string Codemeli { get; set; }
        public string Idhasab { get; set; }
        public string Imagemeli { get; set; }
        public string Imagehasab { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isactivehasab { get; set; }
    }
}
