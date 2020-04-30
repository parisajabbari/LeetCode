using System;
using System.Collections.Generic;

namespace project
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target) 
        {          
            for (int i = 0; i < nums.Length -1; i++)
            {               
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        return new int[] {i,j};

                    }
                }
            }
            return new int[]{};
        }

        public static int[] TwoSumDict(int[] nums, int target) 
        {
            Dictionary<int, int> map = new Dictionary<int, int>(nums.Length);
            int Compliment = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Compliment = target - nums[i];
                if(map.ContainsKey(Compliment))
                {
                    return new int[]{map[Compliment], i};
                }
                map.Add(nums[i], i);
            }
            return new int[]{};

            
        }

    }
}
