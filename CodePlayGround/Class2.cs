using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround
{
    class Class2
    {
    }
    public class Solution
    {
        //this doesnt wooorrrkkkkk
        //why? im not sure
        public bool IsPalindrome(int x)
        {
            {
                if (x == 0)
                    return true;

                List<int> digits = new List<int>();

                for (; x != 0; x /= 10)
                    digits.Add(x % 10);

                int[] array = digits.ToArray();
                int[] original = digits.ToArray();
                System.Array.Reverse(original);

                int finalScore1 = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    finalScore1 += array[i] * Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
                }

                int finalScore2 = 0;
                for (int i = 0; i < original.Length; i++)
                {
                    finalScore2 += original[i] * Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
                }

                if (finalScore1 == finalScore2)
                {
                    return true;
                }
                else return false;

            }


        }
    }


    //this does work but is slowowowowow
    public class Solution9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            else
            {
                int revnum = 0;
                while (x > revnum)
                {
                    revnum = (revnum * 10) + (x % 10);
                    x = x / 10;
                }

                return (x == revnum || x == revnum / 10);

            }

        }
    }



    public class Solution234
    {
        public int MissingNumber(int[] nums)
        {
            //missing num = n
            int n = nums.Length - 1;

            int total = (n + 1) * (n + 2) / 2;
            for (int i = 0; i < n; i++)
            
                total -= nums[i];

                return total;
            
        }
    }

    public class Solution98765
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
                return "";
            string res = strs[0];
            int i = res.Length;
            foreach (string word in strs)
            {
                int j = 0;
                foreach (char c in word)
                {
                    if (j >= i || res[j] != c)
                        break;
                    j += 1;
                }
                i = Math.Min(i, j);
            }
            return res.Substring(0, i);
        }
    }

}

