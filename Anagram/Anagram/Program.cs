using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            string[] input;
            do
            {
               input = Input.GetInputFromUser();

                Validation validate = new Validation();

                isValid = validate.ValidateInput(input);
               
            }
            while (isValid == false);


            Anagramseries series = new Anagramseries();
            int result = series.GetMaximumSubset(input);
            Console.WriteLine(result);





        }
    }
}
