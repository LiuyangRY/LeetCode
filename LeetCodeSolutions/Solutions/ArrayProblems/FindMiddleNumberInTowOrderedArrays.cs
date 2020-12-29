using System.Collections.Generic;

namespace LeetCodeSolutions.ArrayProblems
{
    public class FindMiddleNumberInTowOrderedArraysSoultion
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
        {
            int firstIndex = 0, secondIndex = 0;
            int totalLength = nums1.Length + nums2.Length;

            if(totalLength < 2)
            {
                if(nums1.Length > 0)
                {
                    return nums1[0];
                }
                else
                {
                    return nums2[0];
                }
            }

            bool isEven = (totalLength & 1).Equals(0);
            int midIndex = totalLength / 2;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < totalLength; i++)
            {
                if(firstIndex >= nums1.Length)
                {
                    stack.Push(nums2[secondIndex++]);
                }
                else if(secondIndex >= nums2.Length)
                {
                    stack.Push(nums1[firstIndex++]);
                }
                else if(nums1[firstIndex] <= nums2[secondIndex])
                {
                    stack.Push(nums1[firstIndex++]);
                }
                else
                {
                    stack.Push(nums2[secondIndex++]);
                }
                if(midIndex.Equals(i))
                {
                    break;
                }
            }
            if(isEven)
            {
                return (stack.Pop() + stack.Pop()) / 2.0;
            }
            return stack.Pop();
        }
    }
}