using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster_Challenge
{
    public static class Quiz
    {
        private static readonly List<string> QuestionsAndAnswers = new List<string>
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
            "What does the 'async' keyword indicate in C#?|The method is synchronous|The method is asynchronous|The method is a static method|The method is a constructor|1",
            "What keyword is used to inherit a class in C#?|inherit|extends|inherits|:|3",
            "Which of the following is a reference type in C#?|double|bool|int|string|3",
            "What is the default value of an uninitialized integer variable in C#?|1|-1|0|null|2",
            "Which keyword is used to create an instance of a class in C#?|new|create|instantiate|object|0",
            "Which keyword is used to define a namespace in C#?|namespace|package|module|ns|0"
        };

        public static void StartQuiz()
        {
            int userScore = 0;

            foreach (var qa in QuestionsAndAnswers)
            {
                var parts = qa.Split('|');
                string question = parts[0];
                List<string> answers = new List<string> { parts[1], parts[2], parts[3], parts[4] };
                int correctAnswerIndex = int.Parse(parts[5]);

                Display.DisplayQuestion(question, answers);

                bool validInput = false;
                while (!validInput)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter the number of your answer: ");
                    string userInput = Console.ReadLine();
                    Console.ResetColor();

                    if (int.TryParse(userInput, out int userAnswerIndex) && userAnswerIndex >= 1 && userAnswerIndex <= answers.Count)
                    {
                        validInput = true;
                        if (userAnswerIndex - 1 == correctAnswerIndex)
                        {
                            Display.DisplayCorrectAnswerMessage();
                            userScore++;
                        }
                        else
                        {
                            Display.DisplayIncorrectAnswerMessage(answers[correctAnswerIndex]);
                        }
                    }
                    else
                    {
                        Display.DisplayInvalidInputMessage();
                    }
                }
            }

            Display.DisplayFinalScore(userScore, QuestionsAndAnswers.Count);
        }
    }
}
