using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifibonacci
{
    

    class Program
    {
        static void Main(string[] args)
        {
            int[] A;
            bool isValid;
            Fibonacci series = new Fibonacci();

            do
            {

                A = Input.GetInputFromUser();
                Validation validate = new Validation();
                isValid = validate.ValidateArray(A);

            }
            while (isValid == false);

               int indexOfMinusone= Array.IndexOf(A, -1);
                A[indexOfMinusone] =series.Complete(A);
                if(series.Checkseries(A))
                {
                    Console.WriteLine(A[indexOfMinusone]);
                }
                else
                {
                    Console.WriteLine(-1);
                }
                
                
                  
            }
            
        }
    }

