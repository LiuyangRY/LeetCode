using System;
using LeetCode.Solutions.ArrayProblems;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };
            FindMiddleNumberInTowOrderedArraysSoultion test = new FindMiddleNumberInTowOrderedArraysSoultion();
            var result = test.FindMedianSortedArrays(nums1, nums2);
            System.Console.WriteLine($"结果为：{result}");
        }
    }
}
