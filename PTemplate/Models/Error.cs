using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models
{
    public class Error
    {
        public Error()
        {
            codeError = 0;
            message = "استثنائی بوجود امده است.";
        }

       public int codeError { get; set; }
       public string message { get; set; }

        public void setError(int codeError)
        {
            switch(codeError)
            {
                case 1:
                    this.codeError = codeError;
                    this.message = "شناسه معتبری یافت نشد.";
                    break;
                case 2:
                    this.codeError = codeError;
                    this.message = "استثناء به وجود امده است.";
                    break;
                case 3:
                    this.codeError = codeError;
                    this.message = "شناسه از درگاه یافت نشد.";
                    break;
                case 4:
                    this.codeError = codeError;
                    this.message = "درخواست مورد نظر شما یافت نشد.";
                    break;
            }
        }
    }
}
