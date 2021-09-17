/*
 * @lc app=leetcode.cn id=16 lang=csharp
 *
 * [16] 最接近的三数之和
 */

// @lc code=start
public class Solution {
    public static int[] Swap(int[] array, int firstPosition, int secondePosition)
    {
        int temp = array[firstPosition];
        array[firstPosition] = array[secondePosition];
        array[secondePosition] = temp;
        return array;
    }

    /// <summary>
    /// 双路指针快速排序（递归方式）
    /// </summary>
    /// <param name="array">排序数组</param>
    /// <param name="startIndex">排序开始索引</param>
    /// <param name="endIndex">排序结束索引</param>
    public static void QuickSort(int[] array, int startIndex, int endIndex)
    {
        // 完整性检查
        if(array == null || array.Length < 2)
        {
            return;
        }
        if(startIndex >= endIndex)
        {
            return;
        }
        // 将数组按照基准索引分段（左边都小于基准值，右边都大于基准值）
        int index = Partition(array, startIndex, endIndex);
        // 递归对基准索引左边进行排序
        QuickSort(array, startIndex, index - 1);
        // 递归对基准索引右边进行排序
        QuickSort(array, index + 1, endIndex);
    }

    /// <summary>
    /// 根据基准值将数组分为两部分（左边都小于基准值，右边都大于基准值）
    /// </summary>
    /// <param name="array">排序数组</param>
    /// <param name="startIndex">排序开始索引</param>
    /// <param name="endIndex">排序结束索引</param>
    /// <returns>基准索引值</returns>
    private static int Partition(int[] array, int startIndex, int endIndex)
    {
        // 完整性检查
        if(startIndex >= endIndex)
        {
            return startIndex;
        }
        // 初始化基准索引、基准值、左指针与右指针
        int baseIndex = (startIndex + endIndex) >> 1;
        int baseNum = array[baseIndex];
        // 将基准数放到最开始的位置
        Swap(array, startIndex, baseIndex);
        int leftPointer = startIndex, rightPointer = endIndex;
        // 开始交换排序
        while(leftPointer < rightPointer)
        {
            while(leftPointer < rightPointer && array[rightPointer] >= baseNum)
            {
                rightPointer--;
            }
            while(leftPointer < rightPointer && array[leftPointer] <= baseNum)
            {
                leftPointer++;
            }
            if(leftPointer < rightPointer)
            {
                Swap(array, leftPointer, rightPointer);
            }
        }
        // 判断是否交换左只针与基准数的位置
        if(array[startIndex] > array[leftPointer])
        {
            Swap(array, startIndex, leftPointer);
        }
        return leftPointer;
    }

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
        QuickSort(nums, 0, nums.Length - 1);

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
// @lc code=end

