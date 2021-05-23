using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        /// <summary>
        /// a = array
        /// x = what we are searching
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int binarySearch(int[] a, int x)
        {
            //step 1, initializing variables
            int p = 0; //beginning of range
            int r = a.Length - 1; //end of the range aka last slot

            //step 2, search for value
            while(p <= r) //while this is true, we are still in the range
            {
                int q = (p + r) / 2;
                if (x < a[q])
                {
                    r = q - 1; //set r to mid point, we narrowed to the first 
                               //half of the array in the case x is less than the data in slot q
                }
                else if (x > a[q])
                {
                    p = q + 1; //here, we bring p to the right of the array
                }
                else return q; //if we made it here, We found our value!!!!
            }


            //step 3, value we were looking for was not found
            return -1;
        }
    }
    class BinarySearchExample
    {
    }
}
