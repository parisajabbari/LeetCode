using System;
using System.Linq;
using System.Collections.Generic;

namespace project
{
    public class Solution
    {
        public static int SingleNumber(int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                            nums = nums.Where(val => val != nums[i]).ToArray();
                        i = -1;
                        break;

                    }
                }
            }
            if(nums != null)
            {
                foreach (var item in nums)
                {
                    return item;
                }
            }
            return 0;
        }

        public static int SingleNumDic(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if(!dic.ContainsKey(num))
                {
                    dic.Add(num, 0);
                }
                dic[num]++;
            }
            foreach (var kvp in dic)
            {
                if(kvp.Value == 1)
                {
                    return kvp.Key;
                }
                
            }
            return 0;
        }
    }
}
