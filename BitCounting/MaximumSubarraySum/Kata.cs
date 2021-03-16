using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximumSubarraySum
{
    class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            List<int> sumArray = new List<int>();
            sumArray.Add(0);

            for (int i = 0; i < arr.Length; i++)
            {
                int[] tempArray = new int[arr.Length];
                for (int j = i; j < arr.Length; j++)
                {
                    tempArray[j] = arr[j];
                    sumArray.Add(tempArray.Sum());
                }              
            }
            if (sumArray.Max() < 0)
                return 0;
            return sumArray.Max();                
        }
    }
}
