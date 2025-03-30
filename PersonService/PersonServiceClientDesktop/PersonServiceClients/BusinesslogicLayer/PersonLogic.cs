using PersonServiceClient.Servicelayer;

using PersonServiceClientDesktop.Servicelayer;
using PersonServiceClients.ModelLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonServiceClientDesktop.BusinesslogicLayer
{
    public class PersonLogic
    {
        private readonly IPersonAccess _personAccess;

        public PersonLogic()
        {
            _personAccess = new PersonServiceAccess();
        }

        public async Task<List<Person>?> GetAllPersons()
        {
            return await _personAccess.GetPersons();
        }

        public async Task<int> SavePerson(string fName, string lName, string mPhone)
        {
            Person newPerson = new(fName, lName, mPhone);
            return await _personAccess.SavePerson(newPerson);
        }
    }
}
