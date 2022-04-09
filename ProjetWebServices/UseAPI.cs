using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
namespace ProjetWebServices
{
    internal class UseAPI
    {
        private static readonly String baseUrl = "http://localhost:8181/api/";
        public static async Task<Utilisateur> LogU(Utilisateur user)
        {

            Console.WriteLine("LOGIN:::: " + user.login + "\nPWD:::: " + user.pwd);
            using (HttpClient client = new HttpClient())
            {

                var data = new
                {
                    login = user.login.Trim(),
                    pwd = user.pwd.Trim()
                };

                using (HttpResponseMessage res = await client.PostAsync(baseUrl + "users/login", data.AsJson()))
                {
                    using (HttpContent content = res.Content)
                    {
                        String jsonString = await content.ReadAsStringAsync();

                        if (jsonString != null)
                        {
                            if ((int)res.StatusCode >= 200 && (int)res.StatusCode < 300)
                            {
                                Console.WriteLine("Service::::: " + jsonString);
                                Utilisateur userRep = JsonConvert.DeserializeObject<Utilisateur>(jsonString);
                                return userRep;
                            }
                            return null;
                        }
                        return null;
                    }
                }
            }

        }
    }

    public static class Extensions
    {
        public static StringContent AsJson(this object o)
            => new StringContent(JsonConvert.SerializeObject(o), Encoding.UTF8, "application/json");
    }


}
