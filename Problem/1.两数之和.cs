/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(!dic.TryGetValue(target - nums[i], out var index))
                dic[nums[i]] = i;
            else
                return [index, i];
        }
        return null;
    }
}
// @lc code=end

