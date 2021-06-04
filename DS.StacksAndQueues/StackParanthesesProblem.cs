﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.StacksAndQueues
{
    class StackParanthesesProblem
    {
        public bool IsValid(string s)
        {
            Stack<char> sign = new Stack<char>();

            foreach (var item in s.ToCharArray())
                if (item == '(')
                    sign.Push(')');
                else if (item == '[')
                    sign.Push(']');
                else if (item == '{')
                    sign.Push('}');
                else if (sign.Count == 0 || sign.Pop() != item)
                    return false;

            return sign.Count == 0;
        }
    }
}
