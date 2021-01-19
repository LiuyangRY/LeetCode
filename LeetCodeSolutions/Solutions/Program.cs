using LeetCodeSolutions.Common.Extensions;
using LeetCodeSolutions.Common.Helpers;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10000; i++)
            {
                int[] testArray = ArrayHelper.CreateRandomArray(200000);
                QuickSort quickSort = new QuickSort(testArray);
                quickSort.Sort();
                System.Console.WriteLine(quickSort.ToString());
                System.Console.WriteLine($"{quickSort.JudgeOrdered()}");
            }
        }
    }
}
