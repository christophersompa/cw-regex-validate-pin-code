using System;
using System.Text.RegularExpressions;


namespace regex_validate_pin_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain 
             * anything by exactly 4 digits or exactly 6 digits, 
             * if the function is passed a valid PIN string return true, else return false.
            */

            Console.WriteLine(ValidatePin("123456"));

            Console.ReadLine();
        }

        public static bool ValidatePin(string pin)
        {
            string fourDigits = @"^\d{4}$";

            string sixDigits = @"^\d{6}$";

            return Regex.IsMatch(pin , fourDigits) || Regex.IsMatch(pin, sixDigits) ? true : false;
        }

    }
}
