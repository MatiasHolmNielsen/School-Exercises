using PersonData.DatabaseLayer;
using PersonData.ModelLayer;
using PersonRestService.DTOs;
using PersonRestService.ModelConversion;
using System;
using System.Collections.Generic;

namespace PersonRestService.BusinesslogicLayer
{
    public class PersonDataLogic : IPersonData
    {
        private readonly IPersonAccess _personAccess;

        public PersonDataLogic(IPersonAccess personAccess)
        {
            _personAccess = personAccess;
        }

        public int Add(PersonDTO personToAdd)
        {
            try
            {
                var person = PersonDTOConvert.ToPerson(personToAdd);
                return person != null ? _personAccess.CreatePerson(person) : 0;
            }
            catch
            {
                return -1;
            }
        }

        public bool Delete(int id) => throw new NotImplementedException();

        public PersonDTO? Get(int id)
        {
            try
            {
                var person = _personAccess.GetPersonById(id);
                return PersonDTOConvert.FromPerson(person);
            }
            catch
            {
                return null;
            }
        }

        public List<PersonDTO?>? Get()
        {
            try
            {
                var persons = _personAccess.GetPersonAll();
                return PersonDTOConvert.FromPersonCollection(persons);
            }
            catch
            {
                return null;
            }
        }

        public bool Put(PersonDTO personToUpdate) => throw new NotImplementedException();
    }
}
