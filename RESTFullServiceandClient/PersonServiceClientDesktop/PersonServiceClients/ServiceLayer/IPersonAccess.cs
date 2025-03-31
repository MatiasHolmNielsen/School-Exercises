
using PersonServiceClients.ModelLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonServiceClient.Servicelayer
{
    public interface IPersonAccess
    {
        Task<List<Person>?> GetPersons(int id = -1);
        Task<int> SavePerson(Person personToSave);
    }
}
