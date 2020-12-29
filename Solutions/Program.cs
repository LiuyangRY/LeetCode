﻿using System;
using LeetCode.Solutions.ArrayProblems;
using LeetCode.Solutions.Common.Sort;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[]{1,8,6,2,5,4,8,3,7};
            HoldTheMostWaterSolution test = new HoldTheMostWaterSolution();
            // var result = test.MaxArea(nums1);
            // System.Console.WriteLine($"结果为：{result}");
            ArraySort.QuickSort(nums1, 0, nums1.Length - 1);
            Console.Write("排序结果为：");
            foreach (var num in nums1)
            {
                System.Console.Write($"{num} ");
            }
            System.Console.WriteLine();
        }
    }
}