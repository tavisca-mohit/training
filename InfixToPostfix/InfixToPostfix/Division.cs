using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   static class Division
    {
        internal static double DivideTwoNumbers(double firstnumber,double secondnumber)
        {
            if (Input.DivisionValidate(secondnumber))
            {
                double result = firstnumber / secondnumber;
                return result;
            }
            else
            {
                Console.WriteLine("Result is Undefined");
                Environment.Exit(0);
                return 0;
            }
        }
    }
}
