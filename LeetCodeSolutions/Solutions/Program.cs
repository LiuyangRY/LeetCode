using LeetCodeSolutions.Common.Extensions;
using LeetCodeSolutions.Common.Helpers;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = ArrayHelper.CreateRandomArray(20000);
            BubbleSort bubbleSort = new BubbleSort(testArray);
            SelectionSort selectionSort = new SelectionSort(testArray);
            QuickSort quickSort = new QuickSort(testArray);

            bubbleSort.Sort();
            System.Console.WriteLine(bubbleSort.ToString());
            System.Console.WriteLine($"{bubbleSort.JudgeOrdered()}");

            selectionSort.Sort();
            System.Console.WriteLine(selectionSort.ToString());
            System.Console.WriteLine($"{bubbleSort.JudgeOrdered()}");

            quickSort.Sort();
            System.Console.WriteLine(quickSort.ToString());
            System.Console.WriteLine($"{bubbleSort.JudgeOrdered()}");

            testArray = ArrayHelper.CreateRandomArray(20000, 10, 100000);

            BubbleSort bubbleSort2 = new BubbleSort(testArray);
            SelectionSort selectionSort2 = new SelectionSort(testArray);
            QuickSort quickSort2 = new QuickSort(testArray);
            
            bubbleSort2.Sort();
            System.Console.WriteLine(bubbleSort2.ToString());
            System.Console.WriteLine($"{bubbleSort2.JudgeOrdered()}");

            selectionSort2.Sort();
            System.Console.WriteLine(selectionSort2.ToString());
            System.Console.WriteLine($"{selectionSort2.JudgeOrdered()}");

            quickSort2.Sort();
            System.Console.WriteLine(quickSort2.ToString());
            System.Console.WriteLine($"{quickSort2.JudgeOrdered()}");
        }
    }
}
