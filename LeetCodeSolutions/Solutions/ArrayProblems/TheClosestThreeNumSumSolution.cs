using System.Collections.Generic;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions.Solutions.ArrayProblems
{
    public class TheClosestThreeNumSumSolution
    {
        public int ThreeSumClosest(int[] nums, int target) {
            if(nums == null)
            {
                return 0;
            }
            if(nums.Length == 1)
            {
                return nums[0];
            }
            if(nums.Length == 2)
            {
                return nums[0] + nums[1];
            }
            if(nums.Length == 3)
            {
                return nums[0] + nums[1] + nums[2];
            }
            ArraySort.QuickSort(nums, 0, nums.Length - 1);

            if(target > 0 && nums[0] > target)
            {
                return nums[0] + nums[1] + nums[2];
            }

            int sum = 0;
            int diff = 2001;
            for(int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                while(left < nums.Length)
                {
                    int right = nums.Length - 1;
                    while(left < right)
                    {
                        int currentSum = nums[i] + nums[left] + nums[right];
                        int currentDiff = currentSum - target;
                        if(currentDiff.Equals(0))
                        {
                            return currentSum;
                        }
                        else if((currentDiff * currentDiff) < (diff * diff))
                        {
                            sum = currentSum;
                            diff = currentDiff;
                        }
                        right--;
                    }
                    left++;
                }
            }
            return sum;
        }
    }
}