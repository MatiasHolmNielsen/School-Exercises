namespace PersonServiceClients.ModelLayer
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, string mobilePhone)
        {
            FirstName = firstName;
            LastName = lastName;
            MobilePhone = mobilePhone;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobilePhone { get; set; }

        public string? FullName => $"{FirstName} {LastName}";

        public override string? ToString()
        {
            return MobilePhone != null
                ? $"{FullName}  - mobil no: {MobilePhone}"
                : FullName;
        }
    }
}
