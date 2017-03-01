using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Anagramseries
    {
        internal int GetMaximumSubset(string[] S)
        {
            for (int index = 0; index < S.Length; index++)
            {
                S[index] = Sortelement(S[index]);

            }
            IEnumerable<string> query = from s in S.Distinct() select s;
            return query.Count();
            //string[] final = S.Distinct().ToArray();
            //return final.Length;

        }
        private string Sortelement(string element)
        {
            StringBuilder returnValue = new StringBuilder();
            char[] temporaryCharArray = element.ToArray();
            Array.Sort(temporaryCharArray);
            foreach (char character in temporaryCharArray)
            {
                returnValue.Append(character);
            }
            return returnValue.ToString();
        }
        

    }
}
