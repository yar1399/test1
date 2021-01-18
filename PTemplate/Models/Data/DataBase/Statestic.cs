using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Statestic
    {
        public Statestic()
        {
            StUsers = new HashSet<StUser>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? Day { get; set; }
        public int? Counter { get; set; }

        public virtual ICollection<StUser> StUsers { get; set; }
    }
}
