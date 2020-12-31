/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        if(nums == null || nums.Length < 2)
        {
            return new List<IList<int>>();
        }
        IList<IList<int>> result = new List<IList<int>>();
        HashSet<HashSet<int>> existElement = new HashSet<HashSet<int>>();
        for (int i = 0; i < (nums.Length - 2); i++)
        {
            int left = i + 1;
            while (left < (nums.Length - 1))
            {
                int target = nums[i] + nums[left];
                int right = left + 1;
                while (right < nums.Length)
                {
                    if(target.Equals((-nums[right])))
                    {
                        if(result.Count > 0)
                        {
                            HashSet<int> temp = new HashSet<int>();
                            temp.Add(nums[i]);
                            temp.Add(nums[left]);
                            temp.Add(nums[right]);
                            if(!(existElement.Contains(temp)))
                            {
                                result.Add(new List<int>()
                                {
                                    nums[i],nums[left],nums[right]
                                });
                                existElement.Add(temp);
                            }
                        }
                        else
                        {
                            HashSet<int> temp = new HashSet<int>();
                            temp.Add(nums[i]);
                            temp.Add(nums[left]);
                            temp.Add(nums[right]);
                            result.Add(new List<int>()
                            {
                                nums[i],nums[left],nums[right]
                            });
                            existElement.Add(temp);
                        }
                        break;
                    }
                    right++;
                }
                left++;
            }
        }
        return result;
    }
}
// @lc code=end

