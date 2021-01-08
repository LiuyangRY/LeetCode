using System.Collections.Generic;
using LeetCodeSolutions.Common.Extensions;

namespace LeetCodeSolutions.Common.Sort
{
    public class ArraySort 
    {
        #region 冒泡排序
            /// <summary>
            /// 冒泡排序
            /// </summary>
            /// <param name="array">排序数组</param>
            public static void BubbleSort(int[] array)
            {
                // 完整性检查
                if(array == null || array.Length < 2)
                {
                    return ;
                }
                for(int end = array.Length - 1; end > 0; end--)
                {
                    // 假设数组从 sortedIndex 开始就是有序的
                    int sortedIndex = 0;
                    for(int begin = 1; begin <= end; begin++)
                    {
                        if(array[begin - 1] > array[begin])
                        {
                            array.Swap(begin - 1, begin);
                            // 如果发生交换，说明数组还不是有序的，更新不需要排序的位置
                            sortedIndex = begin;
                        }
                    }
                    // 更新排序结束位置
                    end = sortedIndex;
                }
            }
        #endregion

        #region 选择排序
            /// <summary>
            /// 选择排序
            /// </summary>
            /// <param name="array">排序数组</param>
            public static void SelectionSort(int[] array)
            {
                // 完整性检查
                if(array == null || array.Length < 2)
                {
                    return;
                }
                // 当前最大值
                int maxIndex = 0;
                // 从后往前排序
                for(int end = array.Length - 1; end > 0; end--)
                {
                    for(int start = 0; start <= end; start++)
                    {
                        // 从未排序的元素中找到最大值索引
                        if(array[start] > array[maxIndex])
                        {
                            maxIndex = start;
                        }
                    }
                    // 将最大值移到最后
                    array.Swap(maxIndex, end);
                }
            }
        #endregion

        #region 快速排序
            /// <summary>
            /// 双路指针快速排序（非递归方式）
            /// </summary>
            /// <param name="array">排序数组</param>
            /// <param name="startIndex">排序开始索引</param>
            /// <param name="endIndex">排序结束索引</param>
            public static void QuickSortWithoutRecursion(int[] array, int startIndex, int endIndex)
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
                // 使用栈保存需要排序的索引区间
                Stack<KeyValuePair<int, int>> positionStack = new Stack<KeyValuePair<int, int>>();
                positionStack.Push(new KeyValuePair<int, int>(startIndex, endIndex));
                // 当栈中还有索引区间，继续进行排序
                while (positionStack.Count > 0)
                {
                    // 从栈顶弹出下一个索引区间
                    var position = positionStack.Pop();
                    int index = Partition(array, position.Key, position.Value);
                    if(index != position.Key)
                    {
                        // 如果区间还可以继续划分，就将划分后的区间存储到栈中
                        positionStack.Push(new KeyValuePair<int, int>(position.Key, index - 1));
                        positionStack.Push(new KeyValuePair<int, int>(index + 1, position.Value));
                    }
                }
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
                int leftPointer = startIndex, rightPointer = endIndex;
                // 开始交换排序
                while(leftPointer < rightPointer)
                {
                    while(leftPointer < rightPointer && array[rightPointer] >= baseNum)
                    {
                        rightPointer--;
                    }
                    while(leftPointer < rightPointer && array[leftPointer] < baseNum)
                    {
                        leftPointer++;
                    }
                    if(leftPointer < rightPointer)
                    {
                        array.Swap(leftPointer, rightPointer);
                    }
                }
                return baseIndex;
            }
        #endregion
    }
}