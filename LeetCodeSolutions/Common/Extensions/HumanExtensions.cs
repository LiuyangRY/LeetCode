using System;
using System.Text;

namespace LeetCodeSolutions.Common.Extensions
{
    /// <summary>
    /// 人性化扩展
    /// </summary>
    public static class HumanExtensions
    {
        /// <summary>
        /// 将时间跨度转换为易于人理解的中文信息
        /// </summary>
        /// <param name="timeSpan">时间跨度</param>
        /// <returns>时间跨度的中文信息</returns>
        public static string HumanTimeSpanCN(this TimeSpan timeSpan)
        {
            if(timeSpan.TotalMilliseconds.Equals(0))
            {
                return "";
            }

            StringBuilder time = new StringBuilder();
            if(timeSpan.Days > 0)
            {
                time.Append($"{timeSpan.Days}天");
            }
            if(timeSpan.Hours > 0)
            {
                time.Append($"{timeSpan.Hours}小时");
            }
            if(timeSpan.Minutes > 0)
            {
                time.Append($"{timeSpan.Minutes}分钟");
            }
            if(timeSpan.Seconds > 0)
            {
                time.Append($"{timeSpan.Seconds}秒");
            }
            if(timeSpan.Milliseconds > 0)
            {
                time.Append($"{timeSpan.Milliseconds}毫秒");
            }
            return time.ToString();
        }

        /// <summary>
        /// 空间占用转换为易于人理解的中文信息
        /// </summary>
        /// <param name="spaceSize">占用空间（比特）</param>
        /// <returns>空间占用的中文信息</returns>
        public static string HumanSpaceOccupied(this long spaceSize)
        {
            if(spaceSize.Equals(0))
            {
                return "";
            }

            StringBuilder space = new StringBuilder();
            if((spaceSize / 1073741824) > 0)
            {
                int gb = (int)(spaceSize / 1073741824);
                space.Append($"{gb}GB ");
                spaceSize -= ((long)gb * 1073741824);
            }
            if((spaceSize / 1048576) > 0)
            {
                int mb = (int)(spaceSize / 1048576);
                space.Append($"{mb}MB ");
                spaceSize -= (mb * 1048576);
            }
            if((spaceSize / 1024) > 0)
            {
                int kb = (int)(spaceSize / 1024);
                space.Append($"{kb}KB ");
                spaceSize -= kb * 1024;
            }
            if(spaceSize > 0)
            {
                space.Append($"{spaceSize}B");
            }
            return space.ToString();
        }

        /// <summary>
        /// 将正整数转换为易于人理解的中文信息
        /// </summary>
        /// <param name="number">正整数</param>
        /// <returns>正整数的中文信息</returns>
        public static string HumanNumber(this long number)
        {
            StringBuilder numberInfo = new StringBuilder();
            if(number < 10000)
            {
                numberInfo.Append($"{number}");
            }
            if(number >= 10000 && number < 99999999)
            {
                numberInfo.Append($"{number/10000}万");
            }
            if(number >= 100000000 && number < 999999999999)
            {
                numberInfo.Append($"{number/100000000}亿");
            }
            if(number >= 1000000000000 && number < 999999999999)
            {
                numberInfo.Append($"{number/1000000000000}万亿");
            }
            return numberInfo.ToString();
        }
    }
}