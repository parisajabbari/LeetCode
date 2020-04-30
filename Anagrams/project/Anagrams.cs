using System;
using System.Collections.Generic;

namespace project
{
    public class Anagrams
    {
        public static List<List<string>> FindAnagrams(string[] strings)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            List<string> output = new List<string>();
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

                // if(dict[key] >= 1)
                // {
                //     output.Add(str);
                // }
            }

            return new List<List<string>>(dict.Values);
        }
    }
}
