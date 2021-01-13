using System;

namespace LeetCodeSolutions.Common.Helpers
{
    /// <summary>
    /// 数组帮助类
    /// </summary>
    public class ArrayHelper
    {
        /// <summary>
        /// 生成一个指定长度的随机数组
        /// </summary>
        /// <param name="length">数组长度</param>
        /// <returns>随机数组</returns>
        public static int[] CreateRandomArray(int length)
        {
            return CreateRandomArray(length, int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// 生成一个指定值在区间内的随机数组
        /// </summary>
        /// <param name="length">数组长度</param>
        /// <param name="minValue">最小值</param>
        /// <param name="maxValue">最大值</param>
        /// <returns></returns>
        public static int[] CreateRandomArray(int length, int minValue, int maxValue)
        {
            if(length < 0)
            {
                return null;
            }
            Random rd = new Random();
            int[] result = new int[length];
            for(int i = 0; i < length; i++)
            {
                result[i] = rd.Next(minValue, maxValue);
            }
            return result;
        }
    }
}