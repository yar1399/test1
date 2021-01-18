using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PTemplate.Models
{
    public class botTellegram
    {
        public botTellegram()
        {

        }

        public static void message_bot(string bot,string token, string channelId)
        {

          
            //var token = "1095327958:AAEt25v1dkOKVzEb4gxysrR3IbE-_37vzYU"; // توکن خود را جایگزین کنید

            //var channelId = "@yartestbase";
            var message = bot;
            var uri = String.Format("https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}", token, channelId, message);
            using (WebClient client = new WebClient())
            {
                dynamic s = client.DownloadString(uri);
          




            }
        }


        public static bool SendFileToChannel_bot(byte[] file, string fileName, string token, string channelId)
        {
            //var token = "1095327958:AAEt25v1dkOKVzEb4gxysrR3IbE-_37vzYU"; // توکن خود را جایگزین کنید
            //var channelId = "@yartestbase";

            using (var client = new HttpClient())
            {
                var uri = String.Format("https://api.telegram.org/bot{0}/sendDocument?chat_id={1}", token, channelId);
                using (var multipartFormDataContent = new MultipartFormDataContent())
                {
                    var streamContent = new StreamContent(new MemoryStream(file));
                    streamContent.Headers.Add("Content-Type", "application/octet-stream");
                    streamContent.Headers.Add("Content-Disposition", "form-data; name=\"document\"; filename=\"" + fileName + "\"");
                    multipartFormDataContent.Add(streamContent, "image", fileName);

                    using (var message = client.PostAsync(uri, multipartFormDataContent))
                    {
                        var contentString = message.Result.Content.ReadAsStringAsync();
                    }
                }
            }

            return true;
        }


    }
}
