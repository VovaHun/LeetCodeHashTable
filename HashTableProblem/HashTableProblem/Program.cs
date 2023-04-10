
using HashTableProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        NumberOfGoodPairs numberOf = new NumberOfGoodPairs();

        int[] mas1 = new int[] { 1, 2, 3, 1, 1, 3 };



        int res1 =  numberOf.NumIdenticalPairs(mas1);

        Console.WriteLine(res1);

        Console.ReadKey();
    }
}