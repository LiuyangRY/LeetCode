using System.Collections.Generic;

namespace LeetCode.Solutions.ArrayProblems
{
    public class TwoNumberAddSoultion {
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var dif = target - nums[i];
                if(!hashMap.ContainsKey(dif))
                {
                    hashMap.Add(nums[i], i);
                }
                else
                {
                    return new int[2] { hashMap[dif], i };
                }
            }
            return new int[2] { 0, 0 };
        }
    }
}
