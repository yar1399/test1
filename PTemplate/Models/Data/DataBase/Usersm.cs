using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Usersm
    {
        public int Id { get; set; }
        public long? Iduser { get; set; }
        public int? Idusertypesms { get; set; }
        public DateTime? Createdate { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }
        public byte? Idsoftwaremodel { get; set; }
    }
}
