using System;
using System.Collections.Generic;
using LeetCodeSolutions.Common.Statistic;

namespace LeetCodeSolutions.Solutions.ArrayProblems
{
    public class TwoNumberAddSolution {
        public int[] TwoSum(int[] nums, int target) {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(!dic.TryGetValue(target - nums[i], out var index))
                    dic[nums[i]] = i;
                else
                    return [index, i];
            }
            return null;
        }

        public void Test()
        {
            var action = () =>
            {
                var nums = new int[] { 1, 2, 3, 4, 5 };
                var target = 7;
                var result = TwoSum(nums, target);
                Console.WriteLine($"{result[0]},{result[1]}");
            };
            Statistics.Performance("两数之和测试", action);
        }
    }
}
