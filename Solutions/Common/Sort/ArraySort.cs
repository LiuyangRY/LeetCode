using System;

namespace LeetCode.Solutions.Common.Sort
{
    /// <summary>
    /// 数组排序
    /// </summary>
    public class ArraySort
    {

        public static void QuickSort(int[] arrs, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }
            int first = startIndex, last = endIndex;
            //此时a[startIndex]被保存到key，所以元素a[startIndex]可以当作是一个空位，用于保存数据，之后每赋值一次，也会有一个位置空出来，
            //直到last ==first，此时a[last]==a[first]=key
            int key = arrs[startIndex];
            while (first < last)
            {
                while (first < last && arrs[last] >= key)
                {
                    last--;
                }
                arrs[first] = arrs[last];
                while (first < last && arrs[first] <= key)
                {
                    first++;
                }
                arrs[last] = arrs[first];
            }
            arrs[first] = key;
            //递归排序数组左边的元素
            QuickSort(arrs, startIndex, first - 1);
            //递归排序右边的元素
            QuickSort(arrs, first + 1, endIndex);
        }
        
        /// <summary>
        /// 将数组指定区间进行快速排序并返回基准索引
        /// </summary>
        /// <param name="arrs">排序数组</param>
        /// <param name="left">排序左边界</param>
        /// <param name="right">排序右边界</param>
        /// <returns>基准索引</returns>
        public static int Partition(int[] arrs, int left, int right)
        {
            // 完整性检查
            if(arrs == null || arrs.Length < 2)
            {
                return 0;
            }
            // 初始化基数及基数索引值
            int baseIndex = new Random().Next(left, right);
            int baseNum = arrs[baseIndex];
            int leftPointer = left, rightPointer = right;

            // 将小于基数的数放到左边，将大于基数的值放到右边
            while(leftPointer < rightPointer)
            {
                while(arrs[rightPointer] > baseNum && leftPointer < rightPointer)
                {
                    rightPointer--;
                }
                while(arrs[leftPointer] <= baseNum && leftPointer < rightPointer)
                {
                    leftPointer++;
                }
                if(leftPointer < rightPointer)
                {
                    int temp = arrs[leftPointer];
                    arrs[leftPointer] = arrs[rightPointer];
                    arrs[rightPointer] = temp;
                }
            }
            // 将基数放到指针重合处
            arrs[baseIndex] = arrs[leftPointer];
            arrs[leftPointer] = baseNum;
            
            // 返回基准位置索引
            return leftPointer;
        }
    }
}