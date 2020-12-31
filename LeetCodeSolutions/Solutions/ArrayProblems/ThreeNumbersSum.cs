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
                else
                {
                    int left = i + 1;
                    while(left < nums.Length - 1)
                    {
                        if(left.Equals(nums[i]))
                        {
                            left++;
                        }
                        else
                        {

                        }
                    }
                }
            }
        }
    }
}