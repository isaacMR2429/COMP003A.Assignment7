namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int> { 85, 90, 78, 92, 88 };

            bool working = true;
            while (working)
            {
                Console.WriteLine("Welcome to the Student Score Analyzer");
                Console.WriteLine("1. Display The Scores");
                Console.WriteLine("2. Show their Total");
                Console.WriteLine("3. Show their Average");
                Console.WriteLine("4. Exit Program");
                string input = Console.ReadLine();
            }
        }
    }
}
