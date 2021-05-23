using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    class ArrayContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Hashtable hash = new Hashtable();

            foreach (var item in nums)
                if (hash.Contains(item))
                    return true;
                else
                    hash.Add(item, null);

            return false;
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0,
                index2 = 1;

            while (index2 <= nums.Length - 1)
                if (nums[index1] == nums[index2])
                    index2++;
                else
                    nums[++index1] = nums[index2++];

            return ++index1;
        }

    }
}
