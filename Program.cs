namespace MoodAnalyserTest
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to moodanalyser test");
            
        }
        public class MoodAnalyser
        {
            public string AnalyzeMood(string message)
            {
                if (message.ToLower().Contains("Sad"))
                    return "Sad";
                return "Happy";
            }


        }
    }
}