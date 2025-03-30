using System.Collections.Generic;
using PersonData.DatabaseLayer;
using PersonData.ModelLayer;
using Xunit;
using Xunit.Abstractions;

namespace PersonDataTest
{
    public class TestPersonDataAccess
    {
        private readonly ITestOutputHelper _extraOutput;
        private readonly IPersonAccess _personAccess;
        private readonly string _connectionString =
        "Server=MATIASHOLM\\SQLEXPRESS02; Database=CompanyX; Integrated Security=true; Encrypt=false; TrustServerCertificate=true";


        public TestPersonDataAccess(ITestOutputHelper output)
        {
            _extraOutput = output;
            _personAccess = new PersonDatabaseAccess(_connectionString);
        }

        [Fact]
        public void TestGetPersonAll()
        {
            // Act
            List<Person> readPersons = _personAccess.GetPersonAll();
            bool personsWereRead = (readPersons.Count > 0);

            _extraOutput.WriteLine("Number of persons found: " + readPersons.Count);

            // Assert
            Assert.True(personsWereRead);
        }
    }
}
