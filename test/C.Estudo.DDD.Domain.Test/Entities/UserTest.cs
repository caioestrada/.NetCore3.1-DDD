using C.Estudo.DDD.Domain.Entities;
using Xunit;

namespace C.Estudo.DDD.Domain.Test.Entities
{
    public class UserTest
    {
        [Fact]
        public void Create_Valid_User()
        {
            // Arrange
            User user;

            // Act
            user = new User("name", "lastName", "email@email.com");

            // Assert
            Assert.True(user.Valid);
            Assert.False(user.Invalid);
            Assert.Empty(user.Notifications);
        }

        [Fact]
        public void Create_User_With_Email_Invalid()
        {
            // Arrange
            User user;

            // Act
            user = new User("name", "lastName", "test.com");

            // Assert
            Assert.False(user.Valid);
            Assert.True(user.Invalid);
            Assert.NotEmpty(user.Notifications);
        }

        [Fact]
        public void Create_User_With_FirstName_Invalid()
        {
            // Arrange
            User user;

            // Act
            user = new User("", "lastName", "email@email.com");

            // Assert
            Assert.False(user.Valid);
            Assert.True(user.Invalid);
            Assert.NotEmpty(user.Notifications);
        }

        [Fact]
        public void Create_User_With_LastName_Invalid()
        {
            // Arrange
            User user;

            // Act
            user = new User("name", "", "email@email.com");

            // Assert
            Assert.False(user.Valid);
            Assert.True(user.Invalid);
            Assert.NotEmpty(user.Notifications);
        }
    }
}
