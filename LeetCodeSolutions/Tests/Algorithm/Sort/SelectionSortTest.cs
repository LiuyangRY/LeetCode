using Xunit;
using LeetCodeSolutions.Algorithm.Sort;

namespace LeetCodeSolutions.Tests.Algorithm.Sort
{
    public class SelectionSortTest
    {
        /// <summary>
        /// 选择排序测试
        /// </summary>
        /// <param name="array">测试数组</param>
        [Theory]
        [InlineData(new int[]{-1,0,1,2,-1,-4})]
        [InlineData(new int[]{1,8,6,2,5,4,8,3,7})]
        public void SelectionSortOrderTest(int[] array)
        {
            SelectionSort ss = new SelectionSort(array);

            ss.Sort();

            bool actual = ss.JudgeOrdered(true);
            bool excepted = true;

            Assert.Equal(excepted, actual);
        }
    }
}
