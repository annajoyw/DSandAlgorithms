using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    //Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    class MoveZerosToEnd
    {
		public void MoveZeroes(int[] nums)
		{
			var n = nums.Length;
			if (n < 2) return;

			for (var i = n - 2; i >= 0; i--)
			{
				if (nums[i] != 0) continue;

				for (var j = i; j < n - 1; j++)
				{
					if (nums[j + 1] == 0) break;

					var tmp = nums[j];
					nums[j] = nums[j + 1];
					nums[j + 1] = tmp;
				}
			}
		}
	}

	class MoveZerosToEnd2
    {
		public static void MoveZeros(int[] nums)
		{
			if (nums == null || nums.Length <= 1)
				return;

			int curr = 0;
			int next = 1;

			while (next <= nums.Length - 1)
			{
				if (nums[curr] == 0)
				{
					if (nums[next] == 0)
					{
						next++;
						continue;
					}
					else
					{
						nums[curr] = nums[next];
						nums[next] = 0;
					}
				}
				curr++;
				next++;
			}
		}
	}
}
