using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    static class Input
    {
        internal static string[] GetInputFromUser()
        {
            Console.WriteLine("Please enter the words");
            Console.WriteLine("Please note that , is the delimiter");
            string input = Console.ReadLine();
            string[] arrayofwords = input.Split(',');
            return arrayofwords;
        } 
    }
}
