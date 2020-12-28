namespace LeetCode.Solutions.Common.Extensions.ArrayExtensions
{
    /// <summary>
    /// 数组扩展方法
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// 交换数组位置
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="firstPosition">第一个位置</param>
        /// <param name="secondePosition">第二个位置</param>
        public static int[] Swap(this int[] array, int firstPosition, int secondePosition)
        {
            int temp = array[firstPosition];
            array[firstPosition] = array[secondePosition];
            array[secondePosition] = temp;
            return array;
        }
    }
}