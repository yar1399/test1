using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class City
    {
        public int Id { get; set; }
        public int Idprovince { get; set; }
        public int Idcounty { get; set; }
        public string Name { get; set; }
    }
}
