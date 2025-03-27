using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PersonData.ModelLayer;

namespace PersonData.DatabaseLayer
{
    public class PersonDatabaseAccess : IPersonAccess
    {
        private readonly string? _connectionString;

        public PersonDatabaseAccess(IConfiguration inConfig)
        {
            _connectionString = inConfig.GetConnectionString("CompanyConnection");
        }

        // For test project
        public PersonDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }

        public int CreatePerson(Person personToAdd)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersonById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPersonAll()
        {
            List<Person> foundPersons = new();
            string queryString = "SELECT id, firstName, lastName, mobilePhone FROM Person";

            using SqlConnection con = new(_connectionString);
            using SqlCommand cmd = new(queryString, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                foundPersons.Add(GetPersonFromReader(reader));
            }

            return foundPersons;
        }

        public Person GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePerson(Person personToUpdate)
        {
            throw new NotImplementedException();
        }

        private Person GetPersonFromReader(SqlDataReader reader)
        {
            int id = reader.GetInt32(reader.GetOrdinal("id"));
            string firstName = reader.GetString(reader.GetOrdinal("firstName"));
            string lastName = reader.GetString(reader.GetOrdinal("lastName"));

            string? mobilePhone = reader.IsDBNull(reader.GetOrdinal("mobilePhone"))
                ? null
                : reader.GetString(reader.GetOrdinal("mobilePhone"));

            return new Person(id, firstName, lastName, mobilePhone);
        }

    }
}
