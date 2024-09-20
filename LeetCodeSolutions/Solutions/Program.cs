using LeetCodeSolutions.Common.Statistic;
using LeetCodeSolutions.DataStructure;
using LeetCodeSolutions.DataStructure.Interface;
using LeetCodeSolutions.Solutions.ArrayProblems;
using System;

namespace LeetCodeSolutions
{
	class Program
    {
        static void Main(string[] args)
        {
           var action = () =>
            {
                var nums = new int[] { 1, 2, 3, 4, 5 };
                var target = 7;
                var algorithm = new TwoNumberAddSolution();
                var result = algorithm.TwoSum(nums, target);
                Console.WriteLine($"{result[0]},{result[1]}");
            };
            Statistics.Performance("两数相加测试", action);
        }
    }
}
