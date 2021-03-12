using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VowelCount
{
    class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            //char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            //return str
            //  .ToCharArray()
            //  .Where(c => vowels.Contains(c))
            //  .Count();

            int vowelCount = 0;
            vowelCount = str.Count(x => "aeiou".Contains(x));

            return vowelCount;
        }
    }
}
