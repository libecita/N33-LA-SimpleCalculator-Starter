﻿using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {  // comment el
            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
                Console.WriteLine("Hi.");
            }

        }
    }
}
