using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace mediahub
{
    public class HttpRequest
    {
        public static HttpClient client = new HttpClient();

        public void ClientInit()
        {
            client.BaseAddress = new Uri("https://hub.biosdv.ru/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
