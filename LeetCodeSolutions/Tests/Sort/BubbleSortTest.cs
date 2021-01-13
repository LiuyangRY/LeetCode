using Xunit;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions.Tests.Sort
{
    public class BubbleSortTest
    {
        /// <summary>
        /// 冒泡排序测试
        /// </summary>
        /// <param name="array">测试数组</param>
        [Theory]
        [InlineData(new int[]{-1,0,1,2,-1,-4})]
        [InlineData(new int[]{1,8,6,2,5,4,8,3,7})]
        public void BubbleSortOrderTest(int[] array)
        {
            BubbleSort bs = new BubbleSort(array);

            bs.SortArray();

            bool actual = bs.JudgeOrdered(true);
            bool excepted = true;

            Assert.Equal(excepted, actual);
        }
    }
}
