namespace LeetCode.Solutions.Common.Extensions
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


        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="array">数组</param>
        public static void Print(this int[] array)
        {
            System.Console.Write("[");
            foreach (var num in array)
            {
                System.Console.Write($" {num} ");
            }
            System.Console.Write("]");
            System.Console.WriteLine();
        }
    }
}