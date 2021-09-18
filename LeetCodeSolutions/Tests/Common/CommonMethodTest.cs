using LeetCodeSolutions.Common.Extensions;
using Xunit;

namespace LeetCodeSolutions.Tests.Common
{
    public class CommonMethodTest
    {
        /// <summary>
        /// 升序数组返回true
        /// </summary>
        /// <param name="array"></param>
        [Theory]
        [InlineData(new int[]{1})]
        [InlineData(new int[]{1, 2, 3, 4, 5, 6})]
        public void JudgeOrdered_AscendingReturnTrue(int[] array)
        {
            bool actual = array.JudgeOrdered(true);

            bool excepted = true;

            Assert.Equal(excepted, actual);
        }

        /// <summary>
        /// 升序数组返回false
        /// </summary>
        /// <param name="array"></param>
        [Theory]
        [InlineData(new int[]{2, 1})]
        [InlineData(new int[]{6, 1, 2, 3, 4, 5})]
        public void JudgeOrdered_AscendingReturnFalse(int[] array)
        {
            bool actual = array.JudgeOrdered(true);

            bool excepted = false;

            Assert.Equal(excepted, actual);
        }

        /// <summary>
        /// 降序数组返回true
        /// </summary>
        /// <param name="array"></param>
        [Theory]
        [InlineData(new int[]{2, 1})]
        [InlineData(new int[]{6, 5, 4, 3, 2, 1})]
        public void JudgeOrdered_DescendingReturnTrue(int[] array)
        {
            bool actual = array.JudgeOrdered(false);

            bool excepted = true;

            Assert.Equal(excepted, actual);
        }

        /// <summary>
        /// 降序数组返回false
        /// </summary>
        /// <param name="array"></param>
        [Theory]
        [InlineData(new int[]{2, 1, 10})]
        [InlineData(new int[]{6, 5, 4, 3, 1, 2})]
        public void JudgeOrdered_DescendingReturnFalse(int[] array)
        {
            bool actual = array.JudgeOrdered(false);

            bool excepted = false;

            Assert.Equal(excepted, actual);
        }
    }
}