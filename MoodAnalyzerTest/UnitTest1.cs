using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblems;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMessage_WhenSad_ShouldReturnSAD()
        {
            //Arrange
            string Expected = "SAD";
            MoodAnalyser MoodAnalysers = new MoodAnalyser("I am in Sad Mood");
            //Act
            string result = MoodAnalysers.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        public void GivenHappyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            MoodAnalyser MoodAnalysers = new MoodAnalyser("I am in Happy Mood");
            //Act
            string result = MoodAnalysers.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        public void GivenAnyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            MoodAnalyser MoodAnalysers = new MoodAnalyser("I am in Any Mood");
            //Act
            string result = MoodAnalysers.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        [DataRow("null")]
        public void GivenNULLMessage_WhenANULL_ShouldReturnHAPPY(string message)
        {
            //Arrange
            string Expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }
        [TestMethod]
        [DataRow("")]
        public void GivenEmptyMessage_WhenEmpty_ShouldThrowException(string message)
        {
            try
            {
                //Arrange
                MoodAnalyser MoodAnalysers = new MoodAnalyser(message);
                //Act
                string result = MoodAnalysers.AnalyseMood();
                //Assert
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalysers", "MoodAnalysers");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject_UsingParameterizdConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyser.MoodAnalysers", "MoodAnalysers", "HAPPY");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GiveHappyMoodShouldReturnHappy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void Given_HAPPYMessag_WithReflector_should_ReturnHAPPY()
        {
            string result = MoodAnalyserFactory.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }
    }
}