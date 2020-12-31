using System;
using LeetCodeSolutions.ArrayProblems;
using LeetCodeSolutions.Common.Statistic;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[]{1,8,6,2,5,4,8,3,7};
            HoldTheMostWaterSolution test = new HoldTheMostWaterSolution();
            int result = test.MaxArea(testArray);
            System.Console.WriteLine($"容器最大面积为：{result}");
        }
    }
}
