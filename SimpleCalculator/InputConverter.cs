using System;
using System.Text;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            return 0;
        }


        public static double GetValidNumber(string prompt)
        {
            bool invalid = true;
            while (invalid)
            {
                Console.Write(prompt);
                String input = Console.ReadLine();
                double inputConverted;
                if (double.TryParse(input, out inputConverted))
                {
                    return inputConverted;
                }
                else
                {
                    Console.WriteLine("That's not a valid number. Please enter another one: ");
                }
            }
            // TODO
            return 0;
        }
    }
}
