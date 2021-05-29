using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    class RemoveElements
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = -1;
            foreach (int num in nums)
            {
                if (num != val)
                    nums[++i] = num;
            }
            return i + 1;
        }

    }
}
