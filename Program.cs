namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to the Quiz Console App!\r\n\r\nTest your .NET & C# knowledge with 10 questions.\r\n\r\nLet's begin!\r\n\r\n");
            Console.ResetColor();

            try
            {
                StartQuiz();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An argument-related error occurred: {ex.Message}");
                Console.ResetColor();
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An invalid operation error occurred: {ex.Message}");
                Console.ResetColor();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A format-related error occurred: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Quiz ended, Thank you for your time :)");
                Console.ResetColor();
            }

        }

        static void StartQuiz()
        {

            // In this list, each string contains a question, it's answers, and the index of the correct answer.
            List<string> questionsAndAnswers = new List<string>
             {
            "What does .NET stand for?|Network Enabled Technology|New Enhanced Technology|No Extra Time|.NET does not stand for anything specific|3",
            "What is the base class for all classes in C#?|System.Object|System.Base|System.Root|System.Parent|0",
            "Which of the following is not a value type in C#?|int|float|string|bool|2",
            "What keyword is used to define a class in C#?|class|def|new|object|0",
            "Which method must be defined in a C# program that is to be executed?|Main|Start|Init|Begin|0",
            "What is the file extension for a C# source file?|.java|.cs|.cpp|.csharp|1",
            "Which of the following is a correct way to declare a variable in C#?|int x;|x int;|int: x;|declare int x;|0",
            "Which keyword is used to handle exceptions in C#?|catch|error|exception|handle|0",
            "Which of these access modifiers makes a member visible only within its own class?|public|private|protected|internal|1",
            "What does the 'async' keyword indicate in C#?|The method is synchronous|The method is asynchronous|The method is a static method|The method is a constructor|1"
              };


            int userScore = 0;

            // Loop through each question
            foreach (var qa in questionsAndAnswers)
            {
                var parts = qa.Split('|');
                string question = parts[0];
                List<string> answers = new List<string> { parts[1], parts[2], parts[3], parts[4] };
                int correctAnswerIndex = int.Parse(parts[5]);

                // Display the question and answers
                Console.WriteLine(question);
                Console.WriteLine();
                for (int i = 0; i < answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {answers[i]}");
                }

                bool validInput = false;
                while (!validInput)
                {
                    // Accept user input
                    Console.Write("Enter the number of your answer: ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userAnswerIndex) && userAnswerIndex >= 1 && userAnswerIndex <= answers.Count)
                    {
                        validInput = true;
                        if (userAnswerIndex - 1 == correctAnswerIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correct!\n");
                            Console.ResetColor();
                            userScore++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Incorrect!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($" The correct answer is: {answers[correctAnswerIndex]}\n");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input! Please enter a number between 1 and 4.\n");
                        Console.ResetColor();
                    }
                }

            }

            // Display the final score
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Your final score is: {userScore}/{questionsAndAnswers.Count}");
            Console.ResetColor();
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();

        }




    }
}
