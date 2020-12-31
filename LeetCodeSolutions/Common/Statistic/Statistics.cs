using System;
using System.Diagnostics;
using LeetCodeSolutions.Common.Extensions;

namespace LeetCodeSolutions.Common.Statistic
{
    /// <summary>
    /// 统计类
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// 操作耗时
        /// </summary>
        /// <param name="actionName">操作名称</param>
        /// <param name="action">操作委托</param>
        public static void TimePerformance(string actionName, Action action)
        {
            if(action == null)
            {
                return;
            }
            Stopwatch watch = Stopwatch.StartNew();
            action.Invoke();
            watch.Stop();
            if(string.IsNullOrWhiteSpace(actionName))
            {
                actionName = "临时任务";
            }
            System.Console.WriteLine($"【{actionName}】耗时：{watch.Elapsed.HumanTimeSpanCN()}");
        }

        /// <summary>
        /// 操作占用空间
        /// </summary>
        /// <param name="actionName">操作名称</param>
        /// <param name="action">操作委托</param>
        public static void SpacePerformance(string actionName, Action action)
        {
            if(action == null)
            {
                return;
            }
            Process currentProcess = Process.GetCurrentProcess();
            action.Invoke();
            long spaceSize = currentProcess.PrivateMemorySize64;
            if(string.IsNullOrWhiteSpace(actionName))
            {
                actionName = "临时任务";
            }
            System.Console.WriteLine($"【{actionName}】占用空间：{spaceSize.HumanSpaceOccupied()}");
        }

        /// <summary>
        /// 操作性能（时间、空间）
        /// </summary>
        /// <param name="actionName">操作名称</param>
        /// <param name="action">操作委托</param>
        public static void Performance(string actionName, Action action)
        {
            if(action == null)
            {
                return;
            }
            Process currentProcess = Process.GetCurrentProcess();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            action.Invoke();
            watch.Stop();
            long spaceSize = currentProcess.PrivateMemorySize64;
            if(string.IsNullOrWhiteSpace(actionName))
            {
                actionName = "临时任务";
            }
            System.Console.WriteLine($"【{actionName}】总计耗时：{watch.Elapsed.HumanTimeSpanCN()}");
            System.Console.WriteLine($"【{actionName}】占用空间：{spaceSize.HumanSpaceOccupied()}");
        }
    }
}