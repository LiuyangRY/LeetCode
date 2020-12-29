using System;
using LeetCodeSolutions.ArrayProblems;
using LeetCodeSolutions.Common.Extensions;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[]{1,8,6,2,5,4,8,3,7};
            HoldTheMostWaterSolution test = new HoldTheMostWaterSolution();
            // var result = test.MaxArea(nums1);
            // System.Console.WriteLine($"结果为：{result}");
            Console.Write("排序前数组：");
            nums1.Print();
            ArraySort.BubbleSort(nums1);
            // ArraySort.QuickSort(nums1, 0, nums1.Length - 1);
            Console.Write("排序后数组：");
            nums1.Print();
        }
    }
}
