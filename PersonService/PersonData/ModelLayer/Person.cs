using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.ModelLayer
{
    public class Person
    {
        public Person() { }

        public Person(string? firstName, string? lastName, string? mobilePhone)
        {
            FirstName = firstName;
            LastName = lastName;
            MobilePhone = mobilePhone;
        }

        public Person(int id, string? firstName, string? lastName, string? mobilePhone)
            : this(firstName, lastName, mobilePhone)
        {
            Id = id;
        }

        public int Id { get; init; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobilePhone { get; set; }

        public bool IsPersonEmpty =>
            string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName);
    }
}


