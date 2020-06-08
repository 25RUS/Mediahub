using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using mediahub.Models.Auth;
using mediahub.Models.Auth.RX;
using Newtonsoft.Json;

namespace mediahub.HttpRq.POST
{
    public class Auth : HttpRequest  
    {
        public async Task<User> RegNewAcc(Reg reg)
        {
            User user = new User();
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                "auth/reg", reg);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                //return response.Headers.Location;
                user = await response.Content.ReadAsAsync<User>();   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return user;
        }

        public async void AuthToken(GetToken getToken)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                "/auth/api_token", getToken);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                //return response.Headers.Location;
                Token token = await response.Content.ReadAsAsync<Token>();
                Console.WriteLine(token.api_token);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
