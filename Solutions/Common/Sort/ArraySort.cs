using System.Collections.Generic;
using LeetCode.Solutions.Common.Extensions;

namespace LeetCode.Solutions.Common.Sort
{
    public class ArraySort 
    {
        #region 冒泡排序
        
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
                Stack<KeyValuePair<int, int>> positionStack = new Stack<KeyValuePair<int, int>>();
                positionStack.Push(new KeyValuePair<int, int>(startIndex, endIndex));
                while (positionStack.Count > 0)
                {
                    var position = positionStack.Pop();
                    int index = Partition(array, position.Key, position.Value);
                    if(index != position.Key)
                    {
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
                int index = Partition(array, startIndex, endIndex);
                QuickSort(array, startIndex, index - 1);
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
                // 将基准值保存在数组首部
                array.Swap(baseIndex, startIndex);
                int leftPointer = startIndex + 1, rightPointer = endIndex;
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
                // 将基准数据放到合适的位置
                array.Swap(startIndex, leftPointer);
                return leftPointer;
            }
        #endregion
    }
}