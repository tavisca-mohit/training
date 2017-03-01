using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifibonacci
{
    static class Input
    {
        internal static int[] GetInputFromUser()
        {
         
            int result;
            string[] inputArray;
            Console.WriteLine("Enter the trifibbonacci series  Enter -1 where you want to determine the element");
    tryagain: string input = Console.ReadLine();
            inputArray = input.Split(',');
            int[] A = new int[inputArray.Length];
            //foreach(string s in inputarray)
            //{
            //    Console.WriteLine(s);
            //}
            for(int i=0;i< inputArray.Length;i++)
            {
                if(int.TryParse(inputArray[i],out result))
                {
                    A[i] = result;
                }
                else
                {
                    Console.WriteLine("Invalid input try again");
                    goto tryagain;
                }
            }
            return A;
          

        }
    }
}
