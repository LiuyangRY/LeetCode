using LeetCodeSolutions.Common.Extensions;
using LeetCodeSolutions.Common.Sort;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[]{1,8,6,2,5,4,8,3,7};
            BubbleSort bubbleSort = new BubbleSort(testArray);
            SelectionSort selectionSort = new SelectionSort(testArray);
            QuickSort quickSort = new QuickSort(testArray);
            bubbleSort.Sort();
            System.Console.WriteLine(bubbleSort.ToString());
            selectionSort.Sort();
            System.Console.WriteLine(selectionSort.ToString());
            quickSort.Sort();
            System.Console.WriteLine(quickSort.ToString());
        }
    }
}
