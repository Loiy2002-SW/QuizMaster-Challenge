

namespace QuizMaster_Challenge
{

    public static class Display
    {
        public static void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(" Welcome to the Quiz Console App! ");
            Console.WriteLine(" Test your .NET & C# knowledge with 15 questions.");
            Console.WriteLine(" Let's begin!");
            Console.WriteLine(new string('=', 50));
            Console.ResetColor();
        }

        public static void DisplayErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(message);
            Console.WriteLine(new string('-', 50));
            Console.ResetColor();
        }

        public static void DisplayGoodbyeMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(" Quiz ended, thank you for your time :) ");
            Console.WriteLine(new string('=', 50));
            Console.ResetColor();
        }

        public static void DisplayQuestion(string question, List<string> answers)
        {
            Console.WriteLine(new string('-', 50));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question);
            Console.WriteLine();
            Console.ResetColor();

            for (int i = 0; i < answers.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i + 1}. {answers[i]}");
                Console.ResetColor();
            }
            Console.WriteLine(new string('-', 50));
        }

        public static void DisplayCorrectAnswerMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!\n");
            Console.ResetColor();
        }

        public static void DisplayIncorrectAnswerMessage(string correctAnswer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Incorrect!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" The correct answer is: {correctAnswer}\n");
            Console.ResetColor();
        }

        public static void DisplayInvalidInputMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input! Please enter a number between 1 and 4.\n");
            Console.ResetColor();
        }

        public static void DisplayFinalScore(int userScore, int totalQuestions)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Your final score is: {userScore}/{totalQuestions}");
            Console.WriteLine(new string('=', 50));
            Console.ResetColor();
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }

}
