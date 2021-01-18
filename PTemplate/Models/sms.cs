using Kavenegar.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models
{
    public static class sms
    {
    
        public static bool sendMessage( string mobile, string message)
        {
            decimal mor;
            bool testmobile = decimal.TryParse(mobile.Replace("+", ""), out mor);
            if (mobile.Length == 13 && testmobile)
            {
               
                    var sender = "10001002000222";
                    var receptor = mobile;
                    var template = "emdad";
                    var token = "797872306F7348482F7642707164346A346E5646724F7158324E70754576702B";
                 

                    var api = new Kavenegar.KavenegarApi(token);
                    try
                    {
                        //  var result = api.Send(sender, receptor, message);
                        var result = api.VerifyLookup(receptor, "1111", template);
                        return true;
                    }
                    catch (ApiException ex)
                    {
                    
                    }
                    catch (Kavenegar.Exceptions.HttpException ex)
                    {
                       

                    }
                }
              
                return false;
            }
           

        



    }
}
