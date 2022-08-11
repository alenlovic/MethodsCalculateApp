using System;

namespace ConsoleUI
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetAString("What is your first name: ");

            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");
            Console.WriteLine();

            double resultOfAdd = CalculateData.Add(x, y);
            double resultOfSubtract = CalculateData.Subtract(x, y);
            double resultOfMultiply = CalculateData.Multiply(x, y);
            double resultOfDivine = CalculateData.Divine(x, y);

            UserMessages.PrintResultMessage($"The sum of {x} and {y} is {resultOfAdd}");
            UserMessages.PrintResultMessage($"The subtract of {x} and {y} is {resultOfSubtract}");
            UserMessages.PrintResultMessage($"The multiply of {x} and {y} is {resultOfMultiply}");
            UserMessages.PrintResultMessage($"The divine of {x} and {y} is {resultOfSubtract}");
            Console.WriteLine();

            Console.WriteLine("Thank you for using our app to calculate for you!");

            Console.ReadLine();
        }
        
    }
}
