using System;
using System.Collections.Generic;

namespace PTemplate.Data.DataBase
{
    public partial class Menutype
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
    }
}
