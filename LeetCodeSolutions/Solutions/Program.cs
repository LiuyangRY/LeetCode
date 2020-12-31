using LeetCodeSolutions.Solutions.ArrayProblems;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[]{-1,0,1,2,-1,-4};
            ThreeNumbersSumSolution test = new ThreeNumbersSumSolution();
            var result = test.ThreeSum(testArray);
            System.Console.WriteLine("[");
            foreach (var item in result)
            {   
                System.Console.Write("  [");
                foreach (var num in item)
                {
                    System.Console.Write($" {num} ");
                }
                System.Console.WriteLine("],");
            }
            System.Console.WriteLine("]");
        }
    }
}
