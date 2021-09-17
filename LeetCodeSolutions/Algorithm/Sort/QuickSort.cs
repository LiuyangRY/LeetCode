using System.Collections.Generic;

namespace LeetCodeSolutions.Algorithm.Sort
{
    /// <summary>
    /// 快速排序
    public class QuickSort : BaseSort
    {
        /// <summary>
        /// 快速排序构造函数
        /// </summary>
        /// <param name="array">排序数组</param>
        /// <returns>快速排序类实例</returns>
        public QuickSort(int[] array) : base(array)
        {
        }

        /// <summary>
        /// 排序算法核心逻辑
        /// </summary>
        protected override void SortCore()
        {
            QuickSortCore(0, Array.Length - 1);
        }

        /// <summary>
        /// 双路指针快速排序（递归方式）
        /// </summary>
        /// <param name="startIndex">排序开始索引</param>
        /// <param name="endIndex">排序结束索引</param>
        public void QuickSortCore(int startIndex, int endIndex)
        {
            // 完整性检查
            if(startIndex >= endIndex)
            {
                return;
            }
            // 将数组按照基准索引分段（左边都小于基准值，右边都大于基准值）
            int index = Partition(startIndex, endIndex);
            // 递归对基准索引左边进行排序
            QuickSortCore(startIndex, index - 1);
            // 递归对基准索引右边进行排序
            QuickSortCore(index + 1, endIndex);
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
                if(index != position.Value)
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
            if((endIndex - startIndex).Equals(1))
            {
                // 只有两个元素时，直接比较并返回结束位置
                if(CompareIndex(startIndex, endIndex) > 0)
                {
                    SwapIndex(startIndex, endIndex);
                }
                return endIndex;
            }
            // 初始化基准索引、基准值、左指针与右指针
            int baseNum = CalculateBaseNumber(startIndex, endIndex);
            int leftPointer = startIndex, rightPointer = endIndex - 1;
            // 开始交换排序
            while(leftPointer < rightPointer)
            {
                while(leftPointer < rightPointer && CompareValue(Array[rightPointer], baseNum) >= 0)
                {
                    rightPointer--;
                }
                while(leftPointer < rightPointer && CompareValue(Array[leftPointer], baseNum) <= 0)
                {
                    leftPointer++;
                }
                if(leftPointer < rightPointer)
                {
                    SwapIndex(leftPointer, rightPointer--);
                }
            }
            SwapIndex(++leftPointer, endIndex);
            return leftPointer;
        }

        /// <summary>
        /// 计算数组中的基数，并将基数放在排序结束位置
        /// </summary>
        /// <param name="startIndex">排序开始索引</param>
        /// <param name="endIndex">排序结束索引</param>
        /// <returns>排序位置间合适的比较基数</returns>
        private int CalculateBaseNumber(int startIndex, int endIndex)
        {
            int middleIndex = startIndex + ((endIndex - startIndex) >> 1); // 防止指针过大导致溢出问题
            if(CompareIndex(startIndex, middleIndex) > 0)
            {
                // 将开始位置和中间位置之间较小的数放到开始位置
                SwapIndex(startIndex, middleIndex);
            }
            if(CompareIndex(middleIndex, endIndex) < 0)
            {
                // 将中间位置和结束位置之间较小的数放到结束位置
                SwapIndex(middleIndex, endIndex);
            }
            if(CompareIndex(startIndex, endIndex) > 0 )
            {
                // 将开始位置和结束位置中较大的数放到结束位置
                SwapIndex(startIndex, endIndex);
            }
            // 结束位置的值满足1. 大于开始位置的数 2. 小于中间位置的数 两个条件
            // 可以理解为：
            // 1. 将开始位置、中间位置、结束位置的数按照从小到大的顺序排列；
            // 2. 将中间位置的数放到结束位置，并作为基数返回
            // 将基数放到结束位置是为了在排序的过程中保证基数的位置不变，在左右指针相遇后，将基数放置到正确的位置
            return Array[endIndex];
        }
    }
}