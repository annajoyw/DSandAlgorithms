using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.And.Misc.Questions
{
    class PalindromeInt
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
    
}
