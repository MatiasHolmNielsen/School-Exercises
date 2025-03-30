using PersonData.ModelLayer;
using PersonRestService.DTOs;

namespace PersonRestService.ModelConversion
{
    public class PersonDTOConvert
    {
        public static List<PersonDTO?>? FromPersonCollection(List<Person> inPersons)
        {
            if (inPersons == null) return null;

            List<PersonDTO?> list = new();
            foreach (var person in inPersons)
            {
                if (person != null)
                    list.Add(FromPerson(person));
            }

            return list;
        }

        public static PersonDTO? FromPerson(Person person)
        {
            return person != null
                ? new PersonDTO(person.FirstName, person.LastName, person.MobilePhone)
                : null;
        }

        public static Person? ToPerson(PersonDTO dto)
        {
            return dto != null
                ? new Person(dto.FirstName, dto.LastName, dto.MobilePhone)
                : null;
        }
    }
}
