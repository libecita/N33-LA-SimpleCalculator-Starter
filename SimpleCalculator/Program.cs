using System;
using System.Text;
using CalculatorEngine;

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

                Class1 calculatorEngine = new Class1();
                
                double firstNb = InputConverter.GetValidNumber("Enter the first number: ");
                double secondNb = InputConverter.GetValidNumber("Enter the second number: ");
                //string operation = ("Enter an operation to do: ");
                string operation = Console.ReadLine();
                double result = calculatorEngine.Calculate(operation, firstNb, secondNb);


                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("The value {0:F2} plus the value {1:F2} is equal to {2:F2}.",
                                firstNb, secondNb, result);

                    Console.WriteLine(sb.ToString());
                /*
                

                Console.WriteLine($"Result: {result}");

               
                //*/

                // Class to perform actual calculations
                

                //double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                //double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
               

                //double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                
                Console.WriteLine(result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);            
            }

        }
    }
}
