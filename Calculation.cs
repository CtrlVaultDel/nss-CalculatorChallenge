using System;

namespace CalculatorChallenge
{
    public class Calculation
    {
        public virtual double PromptOne()
        {
            double value = 0.00;
            bool tryConvert = false;

            while (!tryConvert)
            {
                Console.Write("Please enter the first number: ");
                tryConvert = Double.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }
        public virtual double PromptTwo()
        {
            double value = 0.00;
            bool tryConvert = false;

            while (!tryConvert)
            {
                Console.Write("Please enter the second number: ");
                tryConvert = Double.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }
    }
}