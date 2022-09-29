using ToDoIt.Models;

namespace ToDoIT.Tests.Models
{
    public class PersonTests
    {
        [Fact]
        public void TestFirstNameNullOrEmpty()
        {
            //Arrange
            Person person = new Person(1, "", "Christensson");
            //Act
            Exception result = Assert.Throws<Exception>(() => person.FirstName);
            //Assert
            Assert.NotNull(result);
        }
    }
}