using System;
using LeetCodeSolutions.Common.Statistic;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = () => {
                int[] a = new int[10000];
                for(int i = 0; i < 10000; i++)
                {
                    a[i] = i;
                }
                System.Threading.Thread.Sleep(1234);
            };
            Statistics.Performance("测试任务", action);
        }
    }
}
