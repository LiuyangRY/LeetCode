using System;
using Xunit;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions.Tests.Sort
{
    public class ArraySort_ReturnOrderedArray
    {
        /// <summary>
        /// 快速排序（递归方式）测试
        /// </summary>
        /// <param name="array"></param>
        [Theory]
        [InlineData(new int[]{1,8,6,2,5,4,8,3,7})]
        public void QuickSortTest(int[] array)
        {
            ArraySort.QuickSort(array, 0, array.Length - 1);

            int[] excepted = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8};

            Assert.Equal(array, excepted);
        }

        /// <summary>
        /// 快速排序（非递归方式）测试
        /// </summary>
        /// <param name="array"></param>
        [Theory]
        [InlineData(new int[]{1,8,6,2,5,4,8,3,7})]
        public void QuickSortWithoutRecursionTest(int[] array)
        {
            ArraySort.QuickSortWithoutRecursion(array, 0, array.Length - 1);

            int[] excepted = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8};

            Assert.Equal(array, excepted);
        }
    }
}
