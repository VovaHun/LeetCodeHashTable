
using HashTableProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        HowManyNumbersAreSmaller func = new HowManyNumbersAreSmaller();

        int[] mas1 = new int[] { 6, 5, 4, 8 };



        int[] res1 = func.SmallerNumbersThanCurrent(mas1);

        Console.WriteLine(res1);

        Console.ReadKey();
    }
}