using System;

namespace MoodAnalyzerProblems
{
    public class Program
    {
        public string message;
        public Program() : this("I am in Happy Mood")
        {

        }
        public Program(string message)
        {
            this.message = message;
        }
        static void Main(string[] args)
        {

        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else if (this.message.Contains("Happy"))
                {
                    return "HAPPY";
                }
                else if (this.message.Contains("Any"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }
        }
    }
}