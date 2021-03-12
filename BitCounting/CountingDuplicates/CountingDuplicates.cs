using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingDuplicates
{
    class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            var strArray = (str.ToLower()).GroupBy(a => a);
            int count = 0;
            foreach (var item in strArray)
            {
                if (item.Count() > 1)
                    count++;
            }
            return count;
        }
    }
}
