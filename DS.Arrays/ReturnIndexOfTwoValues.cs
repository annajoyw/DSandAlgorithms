using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    //given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

   // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    class ReturnIndexOfTwoValues
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var items = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var rest = target - nums[i];
                if (items.ContainsKey(rest))
                {
                    return new int[] { i, items[rest] };
                }
                else
                {
                    items.Add(nums[i], i);
                }
            }

            throw new Exception("You may assume that each input would have exactly one solution");
        }
    }


    //following solution has better big o notation
    class ReturnIndexOfTwoValues2
    {
        public int[] TwoSum(int[] nums, int target)
        {

            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                    return new int[] { i, dic[target - nums[i]] };
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }

            return new int[2];
        }
    }

}
