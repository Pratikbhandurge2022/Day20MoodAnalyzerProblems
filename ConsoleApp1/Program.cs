using System;

namespace MoodAnalyzerProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program!");
            //  Program program = new Program();          
            //  Console.WriteLine(program.AnalyseMood("Happy"));
        }

        public string AnalyseMood(string mood)
        {
            if (mood.Equals("Happy"))
            {
                return mood + " mood";
            }
            else if (mood.Equals("Sad"))
            {
                return mood + " mood";
            }
            else if (mood.Equals("I am in Sad Mood"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}