﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround
{

    public class Solution //annas code that doesnt work lol
    {
        public int LengthOfLastWord(string s)
        {
            string lastWord = s.Split(' ').Last();
            char[] charArr = lastWord.ToCharArray();
            int count = charArr.Count();

            if (s == " " || s == null)
            {
                return 0;
            }
            else if(count == 1)
            {
                return 1;
            }
          
            return count;
        }
    }

    public class Solution2 
    {
        public int LengthOfLastWord(string s)
        {
            return s.Trim().Split().LastOrDefault().Length;
        }
    }
}