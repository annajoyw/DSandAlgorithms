using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.And.Misc.Questions
{
    class LINQsolutionForMajorElementProblem
    {
        public int MajorityElement(int[] nums)
        {
            if (nums?.Length == 0)
            {
                return 0;
            }
            var maxCount = nums.GroupBy(x => x).Select(x => new { x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).FirstOrDefault();

            return maxCount.Count > nums.Length / 2 ? maxCount.Key : 0;

        }
    }
}
