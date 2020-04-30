using System;
using System.Collections.Generic;

namespace project
{
    public class ValidParentheses
    {
        public static bool Validate(string str)
        {
            var k = new Stack<char>();
            foreach (var c in str)
            {
                if(c == '{') {k.Push('}'); continue;}
                if(c == '[') {k.Push(']'); continue;}
                if(c == '(') {k.Push(')'); continue;}
                if(k.Count == 0 || c!= k.Pop()) return false;
            }
            return k.Count == 0;
        }
    }
}
