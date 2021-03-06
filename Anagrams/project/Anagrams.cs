﻿using System;
using System.Collections.Generic;

namespace project
{
    public class Anagrams
    {
        public static IList<IList<string>> FindAnagrams(string[] strings)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            List<string> list = new List<string>();
            //Anagram solution is with sorting the strings
            foreach (var str in strings)
            {
                char[] ch = str.ToCharArray();
                Array.Sort(ch);
                var key = new string(ch);
                if(!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>());
                }
                dict[key].Add(str);
            }

            return new List<IList<string>>(dict.Values);
        }
    }
}
