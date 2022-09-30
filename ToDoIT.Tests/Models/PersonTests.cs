using ToDoIt.Data;
using ToDoIt.Models;

namespace ToDoIT.Tests.Models
{
    public class PersonTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]

        public void TestFirstNameNullOrEmpty(string firstName)
        {
            //Arrange
            Person person = new Person("Erik", "Christensson", PersonSequencer.NextPersonId());
            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => person.FirstName = firstName);
            //Assert
            Assert.Contains("First", result.Message);
        }


        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void TestLastNameNullOrEmpty(string lastName)
        {
            //Arrange
            Person person = new Person("Erik", "Christensson", PersonSequencer.NextPersonId());
            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => person.LastName = lastName);
            //Assert
            Assert.Contains("Last", result.Message);
        }


        [Fact]
        public void TestCorrectId()
        {
            int testId = 1234;
            Person testPerson = new Person("Erik", "Christensson", testId);
            Assert.Equal(testId, testPerson.PersonId);
        }


        [Fact]
        public void TestCorrectFirstName()
        {
            string testName = "Erik";
            Person testPerson = new Person(testName, "Christensson", 123);
            Assert.Equal(testName, testPerson.FirstName);
        }

        
        [Fact]
        public void TestCorrectLastName()
        {
            string testName = "Christensson";
            Person testPerson = new Person("Erik", testName, 123);
            Assert.Equal(testName, testPerson.LastName);
        }
    }
}