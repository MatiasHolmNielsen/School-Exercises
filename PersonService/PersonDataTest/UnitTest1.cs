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
            "Server=localhost; Integrated Security=true; Database=CompanyX; Encrypt=true; trustServerCertificate=true";

        public TestPersonDataAccess(ITestOutputHelper tOutput)
        {
            _extraOutput = tOutput;
            _personAccess = new PersonDatabaseAccess(_connectionString);
        }

        [Fact]
        public void TestGetPersonAll()
        {
            // Arrange

            // Act
            List<Person> readPersons = _personAccess.GetPersonAll();
            bool personsWereRead = (readPersons.Count > 0);

            // Extra output to console
            _extraOutput.WriteLine("Number of persons: " + readPersons.Count);

            // Assert
            Assert.True(personsWereRead);
        }
    }
}
