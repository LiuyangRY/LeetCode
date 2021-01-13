using Xunit;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions.Tests.Sort
{
    public class QuickSortTest
    {
        /// <summary>
        /// 选择排序测试
        /// </summary>
        /// <param name="array">测试数组</param>
        [Theory]
        [InlineData(new int[]{-1,0,1,0})]
        [InlineData(new int[]{1,8,6,2,5,4,8,3,7})]
        public void QuickSortOrderTest(int[] array)
        {
            QuickSort qs = new QuickSort(array);
            qs.Sort();

            bool actual = qs.JudgeOrdered(true);
            bool excepted = true;

            Assert.Equal(excepted, actual);
        }
    }
}
