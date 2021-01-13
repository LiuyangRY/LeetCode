using LeetCodeSolutions.Solutions.ArrayProblems;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[]{-100,-98,-2,-1};
            TheCLosestThreeNumSum test = new TheCLosestThreeNumSum();
            var result = test.ThreeSumClosest(testArray, -101);
            System.Console.WriteLine(result);
        }
    }
}
