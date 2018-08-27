using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCats.Models
{
    class Repository
    {
        public async Task<List<Cat>> GetCats()
        {
            List<Cat> Cats;
            var URLWebAPI = "http>//demos.ticapacitacion.com/cats";
            using (var Client = new HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                Cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cat>>(JSON);
            }
            return Cats;
        }
    }
}
