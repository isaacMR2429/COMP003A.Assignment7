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
                Console.WriteLine("\nWelcome to the Student Score Analyzer");
                Console.WriteLine("1. Display The Scores");
                Console.WriteLine("2. Show their Total");
                Console.WriteLine("3. Show their Average");
                Console.WriteLine("4. Exit Program");
                Console.Write("Please Enter your choice: ");
                string input = Console.ReadLine();

                bool validationNumber = int.TryParse(input, out int choice);
                if (validationNumber && choice >= 1 && choice <= 4)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("\nThe Scores:");
                        for (int i = 0; i < scores.Count; i++)
                        {
                            Console.WriteLine(scores[i]);
                        }
                    }
                    else if (choice == 2)
                    {
                        int total = 0;
                        for (int i = 0; i < scores.Count; i++)
                        {
                            total += scores[i];
                        }
                        Console.WriteLine("\nThe Total Score is: " + total);
                    }
                    else if (choice == 3)
                    {
                        int total = 0;
                        for (int i = 0; i < scores.Count; i++)
                        {
                            total += scores[i];
                        }
                        double average = (double)total / scores.Count;
                        Console.WriteLine("\nThe Average Score: " + average);
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("\nThe Program has Ended.");
                        working = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid choice, Please try again and pick a number between 1 and 4.");
                }

                Console.Write("\nEnter any number to continue: ");
                string input2 = Console.ReadLine();
                try
                {
                    int number = int.Parse(input2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
        // Debugging Evidence
        // 1. The error I encountered was when the average was rounding down because
        // both values were int.
        // 2. The brief explanation on how I fixed it was changing total to a double before dividing.
        // Which allowed the correct decimal value to be displayed.

    }
}
