using System;
using System.Diagnostics;
using System.Text;
using LeetCodeSolutions.Common.Extensions;

namespace LeetCodeSolutions.Common.Sort
{
    /// <summary>
    /// 基本排序类
    /// </summary>
    public abstract class BaseSort
    {
        /// <summary>
        /// 排序类构造函数
        /// </summary>
        /// <param name="array"></param>
        public BaseSort(int[] array)
        {
            // 完整性检查
            if(array == null)
            {
                return ;
            }
            this.Array = new int[array.Length];
            array.CopyTo(this.Array, 0);
        }

        #region 属性
            /// <summary>
            /// 排序数组
            /// </summary>
            public int[] Array { get; set; }

            /// <summary>
            /// 交换次数
            /// </summary>
            public long SwapCount { get; set; } = 0;

            /// <summary>
            /// 比较次数
            /// </summary>
            public long CompareCount { get; set; } = 0;

            /// <summary>
            /// 排序耗时
            /// </summary>
            public TimeSpan SpendTimeSpan { get; set; }
        #endregion

        #region 公共方法
            /// <summary>
            /// 交换数组索引的值
            /// </summary>
            /// <param name="firstIndex">第一个值索引</param>
            /// <param name="secondIndex">第二个值索引</param>
            /// <returns>交换位置后的数组</returns>
            public int[] SwapIndex(int firstIndex, int secondIndex)
            {
                SwapCount++;
                int temp = Array[firstIndex];
                Array[firstIndex] = Array[secondIndex];
                Array[secondIndex] = temp;
                return Array;
            }

            /// <summary>
            /// 比较数组索引位置
            /// </summary>
            /// <param name="firstIndex">第一个值索引</param>
            /// <param name="secondIndex">第二个值索引</param>
            /// <returns>第一个值与第二个值的大小关系（第一个值大于第二个值，返回1；第一个值小于第二个值，返回-1；两数相等，返回0）</returns>
            public int CompareIndex(int firstIndex, int secondIndex)
            {
                CompareCount++;
                if(Array[firstIndex] > Array[secondIndex])
                {
                    return 1;
                }
                else if(Array[firstIndex] < Array[secondIndex])
                {
                    return -1;
                }
                return 0;
            }

            /// <summary>
            /// 比较两个数
            /// </summary>
            /// <param name="firstValue">第一个数</param>
            /// <param name="secondValue">第二个数</param>
            /// <returns>第一个数与第二个数的大小关系（第一个数大于第二个数，返回1；第一个数小于第二个数，返回-1；两数相等，返回0）</returns>
            public int CompareValue(int firstValue, int secondValue)
            {
                CompareCount++;
                if(firstValue > secondValue)
                {
                    return 1;
                }
                else if(firstValue < secondValue)
                {
                    return -1;
                }
                return 0;
            }

            /// <summary>
            /// 打印数组
            /// </summary>
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"【{this.GetType().Name}】：");
                sb.Append($"排序耗时：{SpendTimeSpan.HumanTimeSpanCN()}\t");
                sb.Append($"交换次数：{SwapCount.HumanNumber()}次\t");
                sb.Append($"比较次数：{CompareCount.HumanNumber()}次\t");
                sb.AppendLine();
                sb.AppendLine("--------------------------------------------------");
                return sb.ToString();
            }

            /// <summary>
            /// 判断数组是否有序
            /// </summary>
            /// <param name="isAsc">是否升序（默认为升序）</param>
            public bool JudgeOrdered(bool isAsc = true)
            {
                // 完整性检查
                if(Array == null)
                {
                    return false;
                }
                if(Array.Length.Equals(1))
                {
                    return true;
                }
                // 假设数组已经是有序的
                bool isSorted = true;
                Func<int, int, bool> compareFunc;
                if(isAsc)
                {
                    compareFunc = (int first, int second) => 
                    {
                        return CompareIndex(first, second) > 0;
                    };
                }
                else
                {
                    compareFunc = (int first, int second) => 
                    {
                        return CompareIndex(first, second) < 0;
                    };
                }
                for(int begin = 1; begin < Array.Length; begin++)
                {
                    if(compareFunc(begin - 1, begin))
                    {
                        // 后一个元素小于前一个元素，数组还不是有序的
                        isSorted = false;
                        break;
                    }
                }
                return isSorted;
            }
        #endregion

        #region 排序逻辑
            /// <summary>
            /// 排序
            /// </summary>
            public void Sort()
            {
                // 完整性检查
                if(Array == null || Array.Length < 2)
                {
                    return ;
                }
                Stopwatch watch = Stopwatch.StartNew();
                // 开始排序
                SortCore();
                watch.Stop();
                // 排序耗时
                SpendTimeSpan = watch.Elapsed;
            }

            /// <summary>
            /// 子类需要重写的排序算法核心逻辑
            /// </summary>
            protected abstract void SortCore();
        #endregion
    }
}