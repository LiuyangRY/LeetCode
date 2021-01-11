namespace LeetCodeSolutions.Common.Sort
{
    /// <summary>
    /// 选择排序
    /// </summary>
    public class SelectionSort : Sort
    {
        /// <summary>
        /// 选择排序构造函数
        /// </summary>
        /// <param name="array">排序数组</param>
        /// <returns>选择排序类实例</returns>
        public SelectionSort(int[] array) : base(array){}

        /// <summary>
        /// 排序算法核心逻辑
        /// </summary>
        protected override void SortCore()
        {
            // 当前最大值
            int maxIndex = 0;
            // 从后往前排序
            for(int end = Array.Length - 1; end > 0; end--)
            {
                
                for(int start = 0; start <= end; start++)
                {
                    // 从未排序的元素中找到最大值索引
                    if(CompareIndex(start, maxIndex) > 0)
                    {
                        maxIndex = start;
                    }
                }
                // 将最大值移到最后
                SwapIndex(maxIndex, end);
                // 重置最大值索引
                maxIndex = 0;
            }
        }
    }
}