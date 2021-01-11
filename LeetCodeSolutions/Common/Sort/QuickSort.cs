using System.Collections.Generic;

namespace LeetCodeSolutions.Common.Sort
{
    /// <summary>
    /// 快速排序
    public class QuickSort : BaseSort
    {
        /// <summary>
        /// 是否使用递归方式排序
        /// </summary>
        public bool IsRecursive { get; set; }

        /// <summary>
        /// 快速排序构造函数
        /// </summary>
        /// <param name="array">排序数组</param>
        /// <returns>快速排序类实例</returns>
        public QuickSort(int[] array, bool isRecursive = true) : base(array)
        {
            this.IsRecursive = isRecursive;
        }

        /// <summary>
        /// 排序算法核心逻辑
        /// </summary>
        protected override void SortCore()
        {
            if(IsRecursive)
            {
                QuickSortWithRecursion(0, Array.Length - 1);
            }
            else
            {
                QuickSortWithoutRecursion(0, Array.Length - 1);
            }
        }

        /// <summary>
        /// 双路指针快速排序（递归方式）
        /// </summary>
        /// <param name="startIndex">排序开始索引</param>
        /// <param name="endIndex">排序结束索引</param>
        public void QuickSortWithRecursion(int startIndex, int endIndex)
        {
            // 完整性检查
            if(startIndex >= endIndex)
            {
                return;
            }
            // 将数组按照基准索引分段（左边都小于基准值，右边都大于基准值）
            int index = Partition(startIndex, endIndex);
            // 递归对基准索引左边进行排序
            QuickSortWithRecursion(startIndex, index - 1);
            // 递归对基准索引右边进行排序
            QuickSortWithRecursion(index + 1, endIndex);
        }

        /// <summary>
        /// 双路指针快速排序（非递归方式）
        /// </summary>
        /// <param name="startIndex">排序开始索引</param>
        /// <param name="endIndex">排序结束索引</param>
        public void QuickSortWithoutRecursion(int startIndex, int endIndex)
        {
            // 完整性检查
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
                int index = Partition(position.Key, position.Value);
                if(index != position.Key)
                {
                    // 如果区间还可以继续划分，就将划分后的区间存储到栈中
                    positionStack.Push(new KeyValuePair<int, int>(position.Key, index - 1));
                    positionStack.Push(new KeyValuePair<int, int>(index + 1, position.Value));
                }
            }
        }

        /// <summary>
        /// 根据基准值将数组分为两部分（左边都小于基准值，右边都大于基准值）
        /// </summary>
        /// <param name="startIndex">排序开始索引</param>
        /// <param name="endIndex">排序结束索引</param>
        /// <returns>基准索引值</returns>
        private int Partition(int startIndex, int endIndex)
        {
            // 完整性检查
            if(startIndex >= endIndex)
            {
                return startIndex;
            }
            // 初始化基准索引、基准值、左指针与右指针
            int baseIndex = startIndex + ((endIndex - startIndex) >> 1); // 防止指针过大导致溢出问题
            int baseNum = Array[baseIndex];
            int leftPointer = startIndex, rightPointer = endIndex;
            // 开始交换排序
            while(leftPointer < rightPointer)
            {
                while(leftPointer < rightPointer && CompareValue(Array[rightPointer], baseNum) >= 0)
                {
                    rightPointer--;
                }
                while(leftPointer < rightPointer && CompareValue(Array[leftPointer], baseNum) < 0)
                {
                    leftPointer++;
                }
                if(leftPointer < rightPointer)
                {
                    SwapIndex(leftPointer, rightPointer);
                }
            }
            return baseIndex;
        }
    }
}