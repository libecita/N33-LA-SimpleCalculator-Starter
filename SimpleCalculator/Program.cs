using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {  // comment el
            try
            {
                // Class to convert user input
                // TODO : could be removed if only created to access the now static method ConvertInputToNumeric?
                InputConverter inputConverter = new InputConverter();

                //*
                /*/
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
                //*/

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);            
            }

        }
    }
}
