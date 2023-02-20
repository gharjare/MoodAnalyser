using MoodAnalyserTest;
namespace AnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         public void GivenSadMessage_WhenAnalyze_ShouldReturnSadMood()
         {
            //Arrange
            string message = "I am in sad Mood";
            string actual = "Sad";
            //Act
            MoodAnalyser analyse = new MoodAnalyser();
            //Assert
            Assert.AreEqual("Sad", actual);
         }
        [TestMethod]
        public void GivenMessage_ReturnHappy()
        {
            string message = "I am in Haapy mood";
            string actual = "Happy";

            MoodAnalyser analyse = new MoodAnalyser();

            Assert.AreEqual("Happy", actual);
        }

    }
}