using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWebServices
{
    internal class ServiceAPI
    {
        private static readonly String baseUrl = "http://localhost:8181/api/";
        public static async Task<string> Create(Rendezvous rv)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    Console.WriteLine("-----------------Objet:::::: " +
                        "struc " + rv.Structure.idStructure + " user" + rv.Utilisateur.id + rv.DateRv);
                    using (HttpResponseMessage res = await client.PostAsync(baseUrl + "/addRv", rv.AsJson()))
                    {
                        using (HttpContent content = res.Content)
                        {
                            String jsonString = await content.ReadAsStringAsync();
                            Console.WriteLine("------------------json::::::" + jsonString);
                            if (jsonString != null)
                            {
                                if ((int)res.StatusCode >= 200 && (int)res.StatusCode < 300)
                                {
                                    Console.WriteLine("Service::::::" + jsonString);
                                    return jsonString;

                                }
                                return null;
                            }
                            return null;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur", ex.Message);
                return null;
            }

        }
    }
}
