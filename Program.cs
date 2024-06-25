using System;
using System.Collections.Generic;

namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display.DisplayWelcomeMessage();
            try
            {
                Quiz.StartQuiz();
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException || ex is FormatException)
            {
                Display.DisplayErrorMessage($"An error occurred: {ex.Message}");
            }
            finally
            {
                Display.DisplayGoodbyeMessage();
            }
        }
    }

  
}
