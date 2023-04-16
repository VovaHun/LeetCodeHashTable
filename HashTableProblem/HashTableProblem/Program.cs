
using HashTableProblem;

internal class Program
{
    private static void Main(string[] args)
    {

        SortThePeople sortThePeople = new SortThePeople();

        string[] names = new string[] { "Mary", "John", "Emma" };
        int[] heights = new int[] { 180, 165, 170 };
        
        
        sortThePeople.SortPeople(names,heights);




        Console.WriteLine();

        Console.ReadKey();
    }
}