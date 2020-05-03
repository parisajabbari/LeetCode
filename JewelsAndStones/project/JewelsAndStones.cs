using System;
using System.Collections.Generic;

namespace project
{
    public class JewelsAndStones   
    {
        public static int NumJewelsInStones(string J, string S)
        {
            var JewelsArray = J.ToCharArray();
            var StonesArray = S.ToCharArray();
            int TotalJewel = 0;

            Dictionary<int, int> JewelsDict = new Dictionary<int, int>();
            foreach (var Jewel in JewelsArray)
            {
                JewelsDict.Add(Jewel, 1);
            }

            foreach (var Stone in StonesArray)
            {
                if(JewelsDict.ContainsKey(Stone))
                {
                    TotalJewel++;
                }
            }

            return TotalJewel;
        }
    }
}
