using System.Collections.Generic;
using LeetCodeSolutions.Common.Statistic;

namespace LeetCodeSolutions.Solutions.ArrayProblems
{
    public class FindMiddleNumberInTowOrderedArraysSolution
    {
        public double FindMedianBetweenTwoSortedArrays(int[] nums1, int[] nums2) 
        {
            int totalLength = nums1.Length + nums2.Length;
            if (totalLength == 0)
            {
                return 0;
            }
            bool isEven = (totalLength & 1) == 0;
            int midIndex = totalLength / 2;
            if (totalLength == nums1.Length || totalLength == nums2.Length)
            {
                if (nums1.Length == 0)
                {
                    if (isEven)
                    {
                        return (nums2[midIndex] + nums2[midIndex - 1]) / 2d;
                    }
                    else
                    {
                        return nums2[midIndex];
                    }
                }
                if (nums2.Length == 0)
                {
                    if (isEven)
                    {
                        return (nums1[midIndex] + nums1[midIndex - 1]) / 2d;
                    }
                    return nums1[midIndex];
                }
            }
            
            if (totalLength == 2)
            {
                return (nums1[0] + nums2[0]) / 2d;
            }
            int firstIndex = 0, secondIndex = 0, currentValue = 0, lastValue = 0;
            for (int i = 0; i < totalLength; i++)
            {
                lastValue = currentValue;
                if (firstIndex >= nums1.Length)
                {
                    currentValue = nums2[secondIndex++];
                }
                else if (secondIndex >= nums2.Length)
                {
                    currentValue = nums1[firstIndex++];
                }
                else if (nums1[firstIndex] <= nums2[secondIndex])
                {
                    currentValue = nums1[firstIndex++];
                }
                else
                {
                    currentValue = nums2[secondIndex++];
                }
                if(midIndex.Equals(i))
                {
                    if (isEven)
                    {
                        return (lastValue + currentValue) / 2d;
                    }
                    else
                    {
                        return currentValue;
                    }
                }
            }
            return 0; 
        }
        
        public void Test()
        {
            var action = () =>
            {
                var nums1 = new int[] { 1, 3 };
                var nums2 = new int[] { 2, 4 };
                var result = FindMedianBetweenTwoSortedArrays(nums1, nums2);
                System.Console.WriteLine($"中位数：{result}");
            };
            Statistics.Performance("寻找两个有序数组中位数测试", action);
        }
    }
}