using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class BotTelegram
    {
        public int Id { get; set; }
        public string Namechanale { get; set; }
        public string Token { get; set; }
        public bool? Isactive { get; set; }
        public bool? Isactivesendauto { get; set; }
        public bool? Isactivediscription { get; set; }
        public bool? Isactivepost { get; set; }
        public bool? Isactiveproduct { get; set; }
        public string Description { get; set; }
    }
}
