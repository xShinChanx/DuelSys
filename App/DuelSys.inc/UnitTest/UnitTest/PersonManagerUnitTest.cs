using MyLibrary.Manager;
using MyLibrary.Model;
using UnitTest.MockDal;

namespace UnitTest.UnitTest
{
    public class PersonManagerUnitTest
    {
        PersonManager personManager = new PersonManager(new MockPersonDal());

        [Fact]
        public void TestCheckPlayerUniqueMailShouldSucceed()
        {
            //Arrange
            Player player = new Player();
            player.Email = "adel@gmail.com";

            //Act
            bool actual = personManager.CheckIfPlayerHasUniqueEmail(player);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestCheckPlayerUniqueMailShouldFail()
        {
            //Arrange
            Player player = new Player();
            player.Email = "basheer@gmail.com";

            //Act
            bool actual = personManager.CheckIfPlayerHasUniqueEmail(player);

            //Assert
            Assert.False(actual);
        }

        [Theory]
        [InlineData(2)]
        public void TestCheckGetPlayerIDShouldSucceed(int playerID)
        {
            //Arrange
            Player player = new Player();

            //Act 
            player = personManager.GetPlayer(playerID);
            
            Player expectedPlayer = new Player();
            expectedPlayer.Email = "min@gmail.com";
            expectedPlayer.Id = 2;
            expectedPlayer.Phone = 456456;

            //Assert
            Assert.Equal(expectedPlayer.Email, player.Email);
            Assert.Equal(expectedPlayer.Id, player.Id);
            Assert.Equal(expectedPlayer.Phone, player.Phone);
        }

        [Theory]
        [InlineData(4)]
        public void TestCheckGetPlayerIDShouldFail(int playerID)
        {
            //Arrange
            Player player = new Player();

            //Act 
            player = personManager.GetPlayer(playerID);

            //Assert
            Assert.Null(player);
        }
    }
}