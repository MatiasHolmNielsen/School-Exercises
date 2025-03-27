using PersonData.ModelLayer;
using System.Collections.Generic;

namespace PersonData.DatabaseLayer
{
    public interface IPersonAccess
    {
        Person GetPersonById(int id);
        List<Person> GetPersonAll();
        int CreatePerson(Person personToAdd);
        bool UpdatePerson(Person personToUpdate);
        bool DeletePersonById(int id);
    }
}
