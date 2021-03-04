using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitCounting
{    public class Kata
    {
        public static int CountBits(int n)
        {
            string binary = Convert.ToString(n, 2);
            var binaryArray = binary.ToCharArray();
            return binaryArray.Where(q => q == '1').Count();
        }
    }
}
