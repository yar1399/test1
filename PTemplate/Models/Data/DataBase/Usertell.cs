﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Usertell
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public string Tell { get; set; }
        public DateTime? Datecreate { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
