using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Socialweb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? Idsocial { get; set; }
        public string Link { get; set; }
        public bool? Isactive { get; set; }
        public string Description { get; set; }
        public virtual Social IdsocialNavigation { get; set; }
    }
}
