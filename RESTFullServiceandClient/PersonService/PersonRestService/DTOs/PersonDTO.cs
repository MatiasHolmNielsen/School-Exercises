namespace PersonRestService.DTOs
{
    public class PersonDTO
    {
        public PersonDTO() { }

        public PersonDTO(string? firstName, string? lastName, string? mobilePhone)
        {
            FirstName = firstName;
            LastName = lastName;
            MobilePhone = mobilePhone;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobilePhone { get; set; }

        public string? FullName => $"{FirstName} {LastName}";
    }
}
