using System;
using System.Text;
using CalculatorEngine;
 
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                Class1 calculatorEngine = new Class1();

                Console.Write("This is a lab 02 sample output from Elise, Lizbeth and Bianca \n");

                double firstNb = InputConverter.GetValidNumber("Please enter the first number: ");
                double secondNb = InputConverter.GetValidNumber("Please enter the second number: ");

                // Prompt the user for the operation
                string operation = InputConverter.GetvalidOperation("Enter an operation (+, -, *, /) : " );
                
                double result = calculatorEngine.Calculate(operation, firstNb, secondNb);

              
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(" {0:F2} "+ operation + " {1:F2} is equal to {2:F2}.",
                                firstNb, secondNb, result);

                    Console.WriteLine(sb.ToString());
                
                Console.WriteLine(result);
                Console.ReadLine();

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);            
            }

        }
    }
}
         
             

               
   


