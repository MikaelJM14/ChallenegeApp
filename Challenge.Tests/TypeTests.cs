using ChallenegeApp;

namespace Challenge.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            //arrange
            string number1 = "Adam";
            string number2 = "Adam";

            //act


            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            //arrange
//            var user1 = GetUser("Adam");
//            var user2 = GetUser("Adam");

            //act
            

            //assert
//            Assert.AreNotEqual(user1, user2);
        }

//        private User GetUser(string name)
//        {
//            return new User(name);
//        }
    }
}
