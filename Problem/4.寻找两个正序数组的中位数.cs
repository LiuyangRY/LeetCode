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
        var lastIndex = isEven ? midIndex - 1 : -1;
        #region 处理一个数组长度为0的情况，该情况下可以直接根据索引计算中位数，时间复杂度为O(1)
        if (totalLength == nums1.Length || totalLength == nums2.Length)
        {
            if (nums1.Length == 0)
            {
                if (isEven)
                {
                    return (nums2[midIndex] + nums2[lastIndex]) / 2d;
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
                    return (nums1[midIndex] + nums1[lastIndex]) / 2d;
                }
                return nums1[midIndex];
            }
        }
        #endregion
        
        if (totalLength == 2)
        {
            // 处理两个数组长度都是1的情况，时间复杂度是O(1)
            return (nums1[0] + nums2[0]) / 2d;
        }
        #region 处理两个数组都不为0的情况，使用两个指针计数跳转的方式找到两个数组合并后的中位数
        int firstIndex = 0, secondIndex = 0, currentValue = 0, lastValue = 0;
        for (int i = 0; i < totalLength; i++)
        {
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
            if (lastIndex == i)
            {
                lastValue = currentValue;
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
        #endregion
        return 0; 
    }
}
// @lc code=end

