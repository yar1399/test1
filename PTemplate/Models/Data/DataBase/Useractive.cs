﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Useractive
    {
        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public DateTime? Datecreate { get; set; }
        public bool? Isactive { get; set; }
        public long? Idoperator { get; set; }

        public virtual User IduserNavigation { get; set; }
    }
}
