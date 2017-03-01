using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifibonacci
{
    class Fibonacci
    {
        internal int Complete(int[] A)
        {
            int indexOfMinusone = Array.IndexOf(A, -1);
            if((indexOfMinusone >= 2))
            {
                if(indexOfMinusone <= A.Length-2)
                {
                    A[indexOfMinusone] =A[indexOfMinusone + 1]-(A[indexOfMinusone - 1]+A[indexOfMinusone - 2]);
                }
            }
            if (indexOfMinusone == 0)
            {
                A[indexOfMinusone] = A[indexOfMinusone + 3] - (A[indexOfMinusone + 2] + A[indexOfMinusone + 1]);
               
            }
            if(indexOfMinusone == 1)
            {
                A[indexOfMinusone] = A[indexOfMinusone + 2] - A[indexOfMinusone + 1] - A[indexOfMinusone - 1];
            }

            if (indexOfMinusone == A.Length - 1)
            {
                A[indexOfMinusone] = A[indexOfMinusone - 1] + A[indexOfMinusone - 2] + A[indexOfMinusone - 3];
                
            }

            return A[indexOfMinusone];

        }
        public bool Checkseries(int[] A)
        {
           for(int index=3; index < A.Length; index++)
            {
                if(A[index] !=A[index - 1]+A[index - 2]+A[index - 3])
                {
                    return false;
                }               
            }
            return true;
          
        }
    }
}
