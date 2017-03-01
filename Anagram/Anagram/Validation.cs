using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Validation
    {
        internal bool ValidateInput(string[] input)
        {
            bool check1 = CheckSize(input);
            if (!check1)
            {
                return false;
            }
            bool check2 = CheckElementSize(input);
            if (!check2)
            {
                return false;
            }
            bool check3 = CheckLowerAndDigit(input);
            if (!check3)
            {
                return false;
            }
            bool check4 = CheckDistinct(input);
            if (!check4)
            {
                return false;
            }
            return true;

        }
        private bool CheckSize(string[] input)
        {
            if (input.Length > 50)
            {
                Console.WriteLine("you are allowed to enter 50 elements only");
                return false;
            }
            else if(input.Length==1 && input.Contains(""))
            {
                Console.WriteLine("Empty data");
                return false;
            }

            return true;
        }
        private bool CheckElementSize(string[] input)
        {
            foreach (string element in input)
            {
                if (element.Length > 50)
                {
                    Console.WriteLine("you cant have elements greater than 50 characters");
                    return false;
                }
            }
            return true;
        }
        private bool CheckLowerAndDigit(string[] input)
        {
            foreach (string element in input)
            {
                foreach (char character in element)
                {
                    if (Char.IsLower(character))
                    {

                    }
                    else
                    {
                        Console.WriteLine("You cannot enter uppercase characters or a digit or a special character");
                        return false;
                    }
                }
            }
            return true;

        }
        private bool CheckDistinct(string[] input)
        {


            string[] distinctstring = input.Distinct().ToArray<string>();
            if (input.Length != distinctstring.Length)
            {
                Console.WriteLine("duplicate elements are not allowed");
                return false;
            }
            return true;
        }

    }
}
