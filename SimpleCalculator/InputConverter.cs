using System;
using System.Text;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double firstNb = GetValidNumber("Enter the first number: ");
            double secondNb = GetValidNumber("Enter the first number: ");

            string GetValidOperator();
            double result = PerformOperation(firstNb, secondNb, operation);

            Console.WriteLine($"Result: {result}");

            static double GetValidNumber(string prompt)
            {
                double number;
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();

                if (double.TryParse(input, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("That's not a valid number. Please enter another one: ");
                }
                }
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("The value {0:F2} plus the value {1:F2} is equal to {2:F2}.",
                    firstNb, secondNb, result);

                Console.WriteLine(sb.ToString());
            }                
        }
        
            //return 0;
    }
}
