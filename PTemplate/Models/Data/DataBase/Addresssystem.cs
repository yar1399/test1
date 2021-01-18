using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Addresssystem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tell { get; set; }
        public string Fax { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Postalcode { get; set; }
        public string Text { get; set; }
        public string Namemanger { get; set; }
        public string Time { get; set; }
        public Single? Lat { get; set; }
        public Single? Lng { get; set; }
    }
}
