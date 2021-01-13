/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
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

    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();

        if(nums == null || nums.Length < 2)
        {
            return result;
        }
        QuickSort(nums, 0, nums.Length - 1);
        
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
                        while(left < right && nums[left].Equals(nums[left + 1]))
                        {
                            left++;
                        }
                        while(left < right && nums[right].Equals(nums[right - 1]))
                        {
                            right--;
                        }
                        left++;
                        right--;
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
// @lc code=end

