/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var dif = target - nums[i];
            if(!hashMap.ContainsKey(dif))
            {
                hashMap.Add(nums[i], i);
            }
            else
            {
                return new int[2] { hashMap[dif], i };
            }
        }
        return new int[2] { 0, 0 };
    }
}
// @lc code=end

