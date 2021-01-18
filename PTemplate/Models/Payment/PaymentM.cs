using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models
{
    public class PaymentM
    {
        public PaymentM()
        {
            Description = "خرید از  سامانه YARViewer ";
        }

        public int Amount { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
