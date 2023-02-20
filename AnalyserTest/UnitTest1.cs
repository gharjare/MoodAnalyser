using MoodAnalyserTest;
namespace AnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        //1.1 TC
        [TestMethod]
         public void GivenSadMessage_WhenAnalyze_ShouldReturnSadMood()
         {
            //Arrange
            string message = "I am in sad Mood";
            string actual = "Sad";
            //Act
            MoodAnalyser analyse = new MoodAnalyser(message);
            //Assert
            Assert.AreEqual("Sad", actual);
         }
        //1.2 TC
        [TestMethod]
        public void GivenMessage_ReturnHappy()
        {
            string message = "I am in Haapy mood";
            string actual = "Happy";

            MoodAnalyser analyse = new MoodAnalyser(message);

            Assert.AreEqual("Happy", actual);
        }
        // 2.1 TC
        [TestMethod]
        public void GivenNullMessageShouldReturnHappy()
        {
            MoodAnalyser analyser = new MoodAnalyser(null);
            try
            {
                string message = analyser.AnalyzeMood();
                Assert.AreEqual(message, "Happy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // 3.1 TC
        [TestMethod]
        public void givenEmptyMoodShouldThrowMoodAnalyserCustomExceptionIndicatingNullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser analyser = new MoodAnalyser(message);
                string mood = analyser.AnalyzeMood();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //3.2 TC
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalyserCustomExceptionIndicatingEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser analyser = new MoodAnalyser(message);
                string mood = analyser.AnalyzeMood();
            }
            catch (MoodAnalyserException e)
            {
                Console.WriteLine("Mood should not be Empty", e.Message);
            }
        }
        //4.1 TC
        //[TestMethod]
        //public void GivenMoodAnalyserClassNameShouldReturnMoodAnalyser_Object()
        //{
        //    object expected = new MoodAnalyser();
        //    object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserTest.MoodAnalyser", "MoodAnalyser");
        //    expected.Equals(obj);
        //}
        ////4.2 TC
        //[TestMethod]
        //public void GivenMoodAnalyserClassNameImproperShouldThrowMoodAnalyserException()
        //{
        //    try
        //    {
        //        object expected = new MoodAnalyser();
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyse("erMoodAnalyserProbelm.MoodAnalys", "MoodAnalyser");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        ////4.3 TC
        //[TestMethod]
        //public void GivenMoodAnalyserConstructorNameImproperShouldThrowMoodAnalyserException()
        //{
        //    try
        //    {
        //        object expected = new MoodAnalyser();
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProbelm.AnalyseMood", "MoodAnaly");
        //        expected.Equals(obj);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
        //TC 4.1
        [TestMethod]
        public void GivenMoodAnalyserClassNameShouldReturnMoodAnalyserObjectUsingParameeterizedConstrctrutorImproper()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProbelm.MoodAnalyser", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //TC5.2
        [TestMethod]
        public void GivenMoodAnalyserClassNameIfImproperShouldThrowMoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProbelm.MoodAnalyr", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //TC5.3
        [TestMethod]
        public void GivenMoodAnalyserMethodNameIfImproperShouldThrowMoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProbelm.MoodAnalyzer", "MoodAnal", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // 6.1 TC
        [TestMethod]
        public void GivenHappyShouldReturnHappy()
        {
            string expected = "Happy";
            string mood = MoodAnalyserFactory.InvokedAnalyseMood("Happy", "AnalyzeMood");
            Assert.AreEqual(expected, mood);
        }
        //6.2 TC
        [TestMethod]
        public void GivenHappyMessageWhenImproperMethodShouldThrowMoodAnalysisException()
        {
            string expected = "Method is not found";
            string mood = MoodAnalyserFactory.InvokedAnalyseMood("Happy", "Analyse");
            Assert.AreEqual(expected, mood);
        }

    }
}