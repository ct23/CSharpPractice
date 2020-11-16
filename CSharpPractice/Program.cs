using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            DATA TYPES: int, double, char, string, bool
            VARIABLES: datatype variableName = value;
            COMMON ERRORS: wrong type, wrong value, no semicolon
            DATA TYPE CONVERSION: implicit, explicit, methods

            Good luck! */

            /*
             * Now that you know a few things about variables and data types, try writing a program that:
             * Converts a boolean to a string
             * Changes a string to a list of chars
             * Converts a data type we didn’t cover to another data type!
             */

            bool isVerified = true;

            // Convert isVerified from bool to string and print
            string converted = Convert.ToString(isVerified);
            Console.WriteLine(converted);

            // Change string to list of chars
            for (int i = 0; i < converted.Length; i++)
            {
                Console.WriteLine(Convert.ToChar(converted[i]));
            }

        }
    }
}
