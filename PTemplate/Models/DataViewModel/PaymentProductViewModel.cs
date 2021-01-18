using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.DataViewModel
{
    public class PaymentProductViewModel:dbMessage
    {
        [Key]
        public decimal money { get; set; }
    }
}
