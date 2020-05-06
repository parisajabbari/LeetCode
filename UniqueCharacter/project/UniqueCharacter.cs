using System;
using System.Collections.Generic;

namespace project
{
    public class UniqueCharacter
    {
        public static int FindFirstUniqChar(string s) 
        {           
            Dictionary<char, int> stringDict = new Dictionary<char, int>();
            var index = -1;

            foreach (var ch in s)
            {
                if(!stringDict.ContainsKey(ch))
                {
                    stringDict.Add(ch, 0);
                }
                stringDict[ch]++;
            }

            foreach (var kvp in stringDict)
            {
                if(kvp.Value == 1)
                {                   
                    return index = s.IndexOf(kvp.Key);
                }
            }
            return index;

        }
    }
}
