using Xunit;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions.Tests.Sort
{
    /// <summary>
    /// 排序类测试
    /// </summary>
    public class BaseSortTest
    {
        /// <summary>
        /// 升序数组判断测试
        /// </summary>
        /// <param name="array">测试数组</param>
        [Theory]
        [InlineData(new int[]{1111})]
        [InlineData(new int[]{1,1,1,1,1})]
        [InlineData(new int[]{1,1,2,2,2,3,3,3,3})]
        public void OrderAscJudgeTrueTest(int[] array)
        {
            BaseSort baseSort = new BubbleSort(array);

            bool actual = baseSort.JudgeOrdered(true);
            bool excepted = true;

            Assert.Equal(excepted, actual);
        }

        /// <summary>
        /// 非升序数组判断测试
        /// </summary>
        /// <param name="array">测试数组</param>
        [Theory]
        [InlineData(null)]
        [InlineData(new int[]{1,8,6,2,5,4,8,3,7})]
        [InlineData(new int[]{7,6,5,4,4,4,3,2,1})]
        public void OrderAscJudgeFalseTest(int[] array)
        {
            BaseSort baseSort = new BubbleSort(array);

            bool actual = baseSort.JudgeOrdered(true);
            bool excepted = false;

            Assert.Equal(excepted, actual);
        }

        /// <summary>
        /// 降序数组判断测试
        /// </summary>
        /// <param name="array">测试数组</param>
        [Theory]
        [InlineData(new int[]{1111})]
        [InlineData(new int[]{1,1,1,1,1})]
        [InlineData(new int[]{7,6,5,4,4,4,3,2,1})]
        [InlineData(new int[]{3,3,3,3,2,2,2,1,1})]
        public void OrderDescJudgeTrueTest(int[] array)
        {
            BaseSort baseSort = new BubbleSort(array);

            bool actual = baseSort.JudgeOrdered(false);
            bool excepted = true;

            Assert.Equal(excepted, actual);
        }

        /// <summary>
        /// 非降序数组判断测试
        /// </summary>
        /// <param name="array">测试数组</param>
        [Theory]
        [InlineData(null)]
        [InlineData(new int[]{7,6,5,4,4,4,3,2,3})]
        [InlineData(new int[]{1,1,2,2,2,3,3,3,3})]
        public void OrderDescJudgeFalseTest(int[] array)
        {
            BaseSort baseSort = new BubbleSort(array);

            bool actual = baseSort.JudgeOrdered(false);
            bool excepted = false;

            Assert.Equal(excepted, actual);
        }
    }
}
