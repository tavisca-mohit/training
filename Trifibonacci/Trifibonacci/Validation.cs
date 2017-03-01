using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifibonacci
{
    class Validation
    {
        internal bool ValidateArray(int[] A)
        {
           
            bool check1 = LengthCheck(A);
            if (!check1)
            {
                return false;
            }
           
            bool check3 = ElementRange(A);
            if (!check3)
            {
                return false;
            }

            bool check2 = MinusOneCheck(A);
            if (!check2)
            {
                return false;
            }

            return true;

        }

       
        private bool LengthCheck(int[] A)
        {
            if (A.Length < 4)
            {
                Console.WriteLine("min limit is 4 please try again");
                return false;
            }
            else if(A.Length>20)
            {
                Console.WriteLine("More than 20 elements detected");
                return false;
            }
            else
                return true;
        }
        private bool MinusOneCheck(int []A)
        {
            int countOfMinusone=0;
            for(int index=0;index<A.Length;index++)
            {
                if(A[index]==-1)
                {
                    countOfMinusone++;
                }
            }
            if (countOfMinusone > 1)
            {
                Console.WriteLine("you are allowed to enter -1 only once");
                return false;
            }
            else if (countOfMinusone == 0)
            {
                Console.WriteLine("please enter -1 where you want to determine the element");
                return false;
            }
            else
                return true;
        }

        private bool ElementRange(int[]A)
        {
           foreach(int element in A)
            {
                if ((element < 1 || element > 1000000) && element != -1)
                {
                    Console.WriteLine("The elements are not in specified range");
                    Console.WriteLine("The specified range is 1 to 100000");
                    return false;
                }
            }
            return true;

        }





    }
}
