using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions.ArrayProblems
{
    public class TwoNumberAddSolution {
        public int[] TwoSum(int[] nums, int target) {
            int[] result = null;
            var dic = new Dictionary<int, int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                var dif = target - nums[i];
                if(!dic.TryGetValue(dif, out var index))
                    dic[nums[i]] = i;
                else
                    result = new int[2] { index, i };
            }
            return result;
        }
    }
}
