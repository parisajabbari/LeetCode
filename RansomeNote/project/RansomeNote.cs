using System;
using System.Collections.Generic;

namespace project
{
    public class RansomeNote
    {
        public static bool CanConstruct(string ransomNote, string magazine) 
        {
            if(String.IsNullOrEmpty(ransomNote))
            {
                return true;
            }
            //bool output = magazine.Contains(ransomNote);
            Dictionary<char, int> noteDict = new Dictionary<char, int>();
            Dictionary<char, int> magazineDict = new Dictionary<char, int>();

            // var ArrayRansomeNote = ransomNote.ToCharArray();
            // Array.Sort(ArrayRansomeNote);

            // var ArrayMagazine = magazine.ToCharArray();
            // Array.Sort(ArrayMagazine);

            foreach (var ch in ransomNote)
            {
                if(!noteDict.ContainsKey(ch))
                {
                    noteDict.Add(ch ,0);
                }
                noteDict[ch]++;

            }
            
            foreach (var ch in magazine)
            {
                if(!magazineDict.ContainsKey(ch))
                {
                    magazineDict.Add(ch, 0);
                }
                magazineDict[ch]++;
                
            }

            foreach (var kvpRansomeNote in noteDict)
            {
                if(magazineDict.ContainsKey(kvpRansomeNote.Key))
                {
                    int value = 0;
                    magazineDict.TryGetValue(kvpRansomeNote.Key, out value);
                    if(value >= kvpRansomeNote.Value) 
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }           
                }
                else
                {
                    return false;
                }    
                
            }
            return true;
        }
    }
}
