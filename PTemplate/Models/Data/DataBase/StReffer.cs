using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class StReffer
    {
        public StReffer()
        {
            StatesticsDetils = new HashSet<StatesticsDetil>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Address { get; set; }
        public int? No { get; set; }
        public bool? Spider { get; set; }

        public virtual ICollection<StatesticsDetil> StatesticsDetils { get; set; }
    }
}
