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

        public String GetValidOperator(String prompt)
        {
            // TODO
            return "";
        }

        public double GetValidNumber(string prompt)
        {
            bool invalid = true;
            while (invalid)
            {
                Console.Write(prompt);
                String input = Console.Read();
                double inputConverted;
                if (double.TryParse(input, out inputConverted))
                {
                    break;
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
