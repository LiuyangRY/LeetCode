namespace LeetCodeSolutions.Common.Sort
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort : Sort
    {
        /// <summary>
        /// 冒泡排序构造函数
        /// </summary>
        /// <param name="array">排序数组</param>
        /// <returns>冒泡排序类实例</returns>
        public BubbleSort(int[] array) : base(array){}

        /// <summary>
        /// 排序算法核心逻辑
        /// </summary>
        protected override void SortCore()
        {
            for(int end = Array.Length - 1; end > 0; end--)
            {
                // 假设数组从 sortedIndex 开始就是有序的
                int sortedIndex = 0;
                for(int begin = 1; begin <= end; begin++)
                {
                    if(CompareIndex(begin - 1, begin) > 0)
                    {
                        SwapIndex(begin - 1, begin);
                        // 如果发生交换，说明数组还不是有序的，更新不需要排序的位置
                        sortedIndex = begin;
                    }
                }
                // 更新排序结束位置
                end = sortedIndex;
            }
        }
    }
}