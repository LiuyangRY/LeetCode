using Xunit;
using LeetCodeSolutions.Common.Sort;
using LeetCodeSolutions.Common.Extensions;

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

            bool actual = array.JudgeOrdered(true);
            bool excepted = true;

            Assert.Equal(actual, excepted);
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

            bool actual = array.JudgeOrdered(true);
            bool excepted = true;

            Assert.Equal(actual, excepted);
        }
    }
}
