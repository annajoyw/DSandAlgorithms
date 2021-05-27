using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.StacksAndQueues
{
    //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    class CheckValidation
    {
        public bool IsValid(string s)
        {
            if (s == null || s == string.Empty)
                return true;

            Dictionary<char, char> dict = new Dictionary<char, char>();
            Stack<char> stack = new Stack<char>();

            dict.Add(')', '(');
            dict.Add('}', '{');
            dict.Add(']', '[');

            foreach (var c in s)
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count > 0 && stack.Peek() == dict[c])
                        stack.Pop();
                    else
                        return false;
                }
                else
                    stack.Push(c);

            return stack.Count == 0;
        }
    }
}
