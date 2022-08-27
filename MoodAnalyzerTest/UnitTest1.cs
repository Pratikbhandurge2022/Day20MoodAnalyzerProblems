using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblems;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void givenMood_WhenHappy_ShouldReturnHappyMood()
        {
            var result = program.AnalyseMood("Happy");
            Assert.AreEqual("Happy mood", result);
        }
        [TestMethod]
        public void givenMood_WhenSad_ShouldReturnSadMood()
        {
            var result = program.AnalyseMood("Sad");
            Assert.AreEqual("Sad mood", result);
        }
        [TestMethod]
        public void givenSadMessage_WhenSad_ShouldReturnSAD()
        {
            var result = program.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void givenAnyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            var result = program.AnalyseMood("I am in Any Mood");
            Assert.AreEqual("HAPPY", result);
        }
    }
}