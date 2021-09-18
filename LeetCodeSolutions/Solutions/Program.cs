using LeetCodeSolutions.DataStructure;
using LeetCodeSolutions.DataStructure.Interface;
using System;

namespace LeetCodeSolutions
{
	class Program
    {
        static void Main(string[] args)
        {
            int opCount = 10000;

            ArrayQueue<int> arrayQueue = new();
            double time1 = TestQueue(arrayQueue, opCount);
            System.Console.WriteLine($"ArrayQueue, ticks: {time1}");

            LoopQueue<int> loopQueue = new();
            double time2 = TestQueue(loopQueue, opCount);
            System.Console.WriteLine($"LoopQueue, ticks: {time2}");
        }

        static double TestQueue(IQueue<int> queue, int opCount)
        {
            Random random = new();
            long startTime = DateTime.Now.Ticks;
            for(int i = 0; i < opCount; i++)
            {
                queue.EnQueue(random.Next(int.MaxValue));
            }
            for(int i = 0; i < opCount; i++)
            {
                queue.DeQueue();
            }
            long endTime = DateTime.Now.Ticks;
            return endTime - startTime;
        }
    }
}
