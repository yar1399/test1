using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class County
    {
        public int Id { get; set; }
        public int Idprovince { get; set; }
        public string Name { get; set; }
    }
}
