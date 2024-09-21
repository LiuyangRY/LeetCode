using System;

namespace LeetCodeSolutions.Solutions.ArrayProblems
{
    public class HoldTheMostWaterSolution
    {
        public int MaxArea(int[] height) {
            int left = 0, right = height.Length - 1, maxArea = 0, tempArea= 0;
            while(left < right)
            {
                int width = right - left;
                if(height[left] > height[right])
                {
                    tempArea =  width * height[right];
                    right--;
                }
                else
                {
                    tempArea = width * height[left];
                    left++;
                }
                if(tempArea > maxArea)
                {
                    maxArea = tempArea;
                }
            }
            return maxArea;
        }
    }
}