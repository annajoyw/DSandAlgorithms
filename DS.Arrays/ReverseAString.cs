using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    class ReverseAString
    {
        static void Main()
        {
            string str = "this string will be backwards";
            reverseString(str);
        }

        static void reverseString(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            Console.WriteLine(result);
        }
    }
}
