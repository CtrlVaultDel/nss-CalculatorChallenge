using System;

namespace CalculatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            Subtraction subtract = new Subtraction();
            Multiplication multiply = new Multiplication();
            Division divide = new Division();

            int userDecision = 1;
            bool parseAttempt;
            bool done = false;

            while (!done)
            {
                Console.WriteLine(@"
Welcome to Calculatron 3000!
1) Add two numbers
2) Subtract two numbers
3) Multiply two numbers
4) Divide two numbers
0) Exit
            ");
                parseAttempt = Int32.TryParse(Console.ReadLine(), out userDecision);
                double firstValue = 0;
                double secondValue = 0;
                double result = 0;

                if (parseAttempt && userDecision >= 0)
                {
                    switch (userDecision)
                    {
                        // Exit Application
                        case 0:
                            done = true;
                            break;

                        // Addition
                        case 1:
                            firstValue = add.PromptOne();
                            secondValue = add.PromptTwo();
                            result = add.Calculate(firstValue, secondValue);
                            Console.WriteLine($"{firstValue} + {secondValue} = {result}");
                            break;

                        // Subtraction
                        case 2:
                            firstValue = subtract.PromptOne();
                            secondValue = subtract.PromptTwo();
                            result = subtract.Calculate(firstValue, secondValue);
                            Console.WriteLine($"{firstValue} - {secondValue} = {result}");
                            break;

                        // Multiplication
                        case 3:
                            firstValue = multiply.PromptOne();
                            secondValue = multiply.PromptTwo();
                            result = multiply.Calculate(firstValue, secondValue);
                            Console.WriteLine($"{firstValue} * {secondValue} = {result}");
                            break;

                        // Division
                        case 4:
                            firstValue = divide.PromptOne();
                            secondValue = divide.PromptTwo();
                            result = divide.Calculate(firstValue, secondValue);
                            Console.WriteLine($"{firstValue} / {secondValue} = {result}");
                            break;

                        // Catch All
                        default:
                            break;
                    }
                }
            }
        }
    }
}
