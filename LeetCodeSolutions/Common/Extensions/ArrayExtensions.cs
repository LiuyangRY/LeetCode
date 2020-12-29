namespace LeetCodeSolutions.Common.Extensions
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

        /// <summary>
        /// 判断数组是否有序
        /// </summary>
        /// <param name="array">需要判断的数组</param>
        /// <param name="isAsc">是否升序（默认为升序）</param>
        public static bool JudgeOrdered(this int[] array, bool isAsc = true)
        {
            // 完整性检查
            if(array == null)
            {
                return false;
            }
            // 假设数组已经是有序的
            bool isSorted = true;
            for(int begin = 1; begin < array.Length; begin++)
            {
                bool compareResult = isAsc ? array[begin - 1] > array[begin] : array[begin - 1] < array[begin];
                if(compareResult)
                {
                    // 后一个元素小于前一个元素，数组还不是有序的
                    isSorted = false;
                    break;
                }
            }
            return isSorted;
        }
    }
}