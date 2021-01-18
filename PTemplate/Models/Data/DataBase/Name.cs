using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Name
    {
        public long Id { get; set; }
        public string Name1 { get; set; }
        public string Pronunciation { get; set; }
        public string Meaning { get; set; }
        public bool? Gender { get; set; }
        public byte? Idletter { get; set; }
        public byte? Idnationality { get; set; }

        public virtual Letter IdletterNavigation { get; set; }
        public virtual Nationality IdnationalityNavigation { get; set; }
    }
}
