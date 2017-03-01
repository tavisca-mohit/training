using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Input
    {
        internal static string GetInputFromUser()
        {
           label: Console.WriteLine("Enter The Numbers to Calculate");
            string inputstring = Console.ReadLine();
            if (ValidateInput(inputstring))
            {
                return inputstring;
            }
            else
                goto label;
        }
        internal static bool DivisionValidate(double number)

        {
            if(number==0)
            {
                return false;
            }
            return true;
        }
        internal static bool ValidateInput(string inputstring)
        {
           for (int i = 0; i < inputstring.Length; i++)
            {
                if (!Isvalid(inputstring[i]))
                {
                    Console.WriteLine("Invalid expression\n");
                    return false;
                }
            }
            if (inputstring.Length == 0)
            {
                Console.WriteLine("Enter expression first\n");
                return false;

            }
            if (IsOperator(inputstring.Last()))
            {
                Console.WriteLine("Invalid expression please enter valid expression\n");
                return false;

            }

            if ((inputstring.First() >= 48 && inputstring.First() <= 57) || inputstring.First() == '-')
            {
                return true;
            }

            for (int i = 0; i < inputstring.Length - 1; i++)
            {
                if (IsOperator(inputstring[i]) && IsOperator(inputstring[i + 1]))
                {
                    Console.WriteLine("Invalid expression please enter valid expression\n");
                    return false;
                }
            }
            return true;
        }
        internal static bool IsOperator(char Operator)
        {
            if (Operator >= 48 && Operator <= 57)
            {
                return false;
            }
            return true;
        }
        internal static bool Isvalid(char Operands)
        {
            if ((Operands >= 48 && Operands <= 57) || Operands == '+' || Operands == '-' || Operands == '/' || Operands == '*' || Operands=='.')
            {
                return true;
            }
            return false;
        }
    }
}
