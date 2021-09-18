using System.Threading;
using System.Threading.Tasks;
using LeetCodeSolutions.Algorithm.Sort;
using LeetCodeSolutions.Common.Extensions;
using LeetCodeSolutions.Common.Helpers;

namespace LeetCodeSolutions
{
	class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Test(cts);
        }

        static void Test(CancellationTokenSource cts)
        {
            for(int i = 0; i < 10000; i++)
            {
                if(!cts.IsCancellationRequested)
                {
                    Task.Run(() =>
                    {
                        Thread.CurrentThread.IsBackground = false;
                        int[] testArray = ArrayHelper.CreateRandomArray(200000);
                        QuickSort quickSort = new QuickSort(testArray);
                        quickSort.Sort();
                        System.Console.WriteLine(quickSort.ToString());
                        bool isOrdered = quickSort.JudgeOrdered();
                        if(!isOrdered)
                        {
                            cts.Cancel();
                            System.Console.WriteLine($"数组无序:{quickSort.Array.ArrayContent()}");
                            System.Console.ReadLine();
                        }
                    }, cts.Token);
               }
            }
        }
    }
}
