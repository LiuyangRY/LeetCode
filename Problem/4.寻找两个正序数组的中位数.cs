/*
 * @lc app=leetcode.cn id=4 lang=csharp
 *
 * [4] 寻找两个正序数组的中位数
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
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
                    return (nums2[midIndex] + nums2[midIndex - 1]) * 0.5d;
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
                    return (nums1[midIndex] + nums1[midIndex - 1]) * 0.5d;
                }
                return nums1[midIndex];
            }
        }
        if (totalLength == 2)
        {
            return (nums1[0] + nums2[0]) * 0.5d;
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
                    return (lastValue + currentValue) * 0.5d;
                }
                else
                {
                    return currentValue;
                }
            }
        }
        return 0; 
    }
}
// @lc code=end

