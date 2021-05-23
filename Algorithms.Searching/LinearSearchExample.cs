using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    //NOTE: linear search can be innefficient sometimes because it checks every index for the value needed

    //might be used in a situation where data cannot be sorted
    
    class LinearSearchExample
    {
        static int linearSearch(int[] a, int x)
        {
            //step 1
            for (int i = 0; i < a.Length; i++) //we will iterate through this as long as 'i' is less than the length of the array
            {
                if (a[i] == x) //then we check to see if the array index at 'i' is == our value
                {
                    return i; //return value if found 
                }
            }

            //step 2
            return -1; //return if value is not found
        }
    }
}
