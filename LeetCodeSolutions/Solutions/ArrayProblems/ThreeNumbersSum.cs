using System.Collections.Generic;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions.Solutions.ArrayProblems
{
    public class ThreeNumbersSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums) {
            IList<IList<int>> result = new List<IList<int>>();

            if(nums == null || nums.Length < 2)
            {
                return result;
            }
            ArraySort.QuickSort(nums, 0, nums.Length - 1);
            
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > 0)
                {
                    return result;
                }
                if(i > 0 && nums[i].Equals(nums[i - 1]))
                {
                    continue;
                }
                else
                {
                    int left = i + 1;
                    int right = nums.Length - 1;
                    while(left < right)
                    {
                        int currentValue = nums[i] + nums[left] + nums[right];
                        if(currentValue.Equals(0))
                        {
                            result.Add(new List<int>
                            {
                                nums[i],
                                nums[left],
                                nums[right]
                            });
                            left++;
                            right--;
                            while(left < right && nums[left].Equals(nums[left - 1]))
                            {
                                left++;
                            }
                            while(left < right && nums[right].Equals(nums[right + 1]))
                            {
                                right--;
                            }
                        }
                        else if(currentValue > 0)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }
                }
            }
            return result;
        }
    }
}