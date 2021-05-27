using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    //how to mathematically reverse a number 
    //https://medium.com/@ManBearPigCode/how-to-reverse-a-number-mathematically-97c556626ec6
    class ReverseAnInt
    {
        public static int Solution(int x)
        {
            long reversedInt = 0;
            bool negative = x < 0;
            if (negative)
                x *= -1;
            while (x > 0)
            {
                reversedInt = reversedInt * 10 + x % 10;
                x /= 10;
            }
            if (negative)
                reversedInt *= -1;
            if (reversedInt >= int.MaxValue)
                return 0;
            int intValue = (int)reversedInt;
            if (negative && intValue > 0)
                return 0;
            return (int)reversedInt;
        }
    }
}
