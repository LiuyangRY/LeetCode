/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        if(height.Length < 2)
        {
            return 0;
        }

        int left = 0, right = height.Length - 1, maxArea = 0, tempArea= 0;
        while(left < right)
        {
            if(height[left] > height[right])
            {
                tempArea = (right - left) * height[right];
                right--;
            }
            else if(height[left] < height[right])
            {
                tempArea = (right - left) * height[left];
                left++;
            }
            else
            {
                tempArea = (right - left) * height[left];
                left++;
                right--;
            }
            if(tempArea > maxArea)
            {
                maxArea = tempArea;
            }
        }
        return maxArea;
    }
}
// @lc code=end

