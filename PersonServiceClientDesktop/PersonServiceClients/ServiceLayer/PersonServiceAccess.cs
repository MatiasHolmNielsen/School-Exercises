using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PersonServiceClients.ModelLayer;
using PersonServiceClient.Servicelayer;

namespace PersonServiceClientDesktop.Servicelayer
{
    public class PersonServiceAccess : ServiceConnection, IPersonAccess
    {
        public PersonServiceAccess()
            : base("https://localhost:7230/api/persons/") // Replace PORT with actual port from your running Web API
        {
        }

        public async Task<List<Person>?> GetPersons(int id = -1)
        {
            List<Person>? personsFromService = null;
            if (id > 0)
                UseUrl = BaseUrl + id;

            HttpResponseMessage? response = await CallServiceGet();
            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                personsFromService = JsonConvert.DeserializeObject<List<Person>>(jsonContent);
            }

            UseUrl = BaseUrl; // Reset
            return personsFromService;
        }

        public async Task<int> SavePerson(Person personToSave)
        {
            int insertedId = -1;
            string json = JsonConvert.SerializeObject(personToSave);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage? response = await CallServicePost(content);
            if (response != null && response.IsSuccessStatusCode)
            {
                string body = await response.Content.ReadAsStringAsync();
                insertedId = int.Parse(body);
            }

            return insertedId;
        }
    }
}
