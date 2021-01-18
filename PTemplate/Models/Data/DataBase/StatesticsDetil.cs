using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class StatesticsDetil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? Date { get; set; }
        public int? IdstReffer { get; set; }
        public string Url { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual StReffer IdstRefferNavigation { get; set; }
        public virtual StUser User { get; set; }
    }
}
