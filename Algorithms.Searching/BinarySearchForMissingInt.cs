using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    class BinarySearchForMissingInt
    {
        public int MissingNumber(int[] nums)
        {
            int sum = 0;
            int n = nums.Length;
            int total = n * (n + 1) / 2;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            return total - sum;
        }
    }
}
