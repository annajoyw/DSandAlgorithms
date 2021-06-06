using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];//this array holds the sub problem
            dp[0] = 1; //this line states the number of ways to climb 0 steps is 1
            dp[1] = 1;
            for(int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2]; 
                //visualise. let's say n=4
               // either boy can climb 1 step or 2 step means we can break 4 into 2 parts     4 - 2 = 2 && 4 - 1 = 3.
               // Now again do same thing for 2 and 3 and so on.Calculate each path and sum them up you will get your answer
            }
            return dp[n];
        }
       
    }
}
