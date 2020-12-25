/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start
public class Solution {
    public int[] QuickSort(int position, int[] nums)
    {

    }

    public int MaxArea(int[] height) {
        if(height.Length < 2)
        {
            return 0;
        }
        int left = 0, right = 0;
        int lowHeight = 0, currentMax = 0;
        for(; left < height.Length - 1; left++)
        {
            right = height.Length - 1;
            for(; left < right; right--)
            {
                lowHeight = (height[left] <= height[right]) ? height[left] : height[right];
                int temp = lowHeight * (right - left);
                if(temp > currentMax)
                {
                    currentMax = temp;
                }
            }
        }
        return currentMax;
    }
}
// @lc code=end

