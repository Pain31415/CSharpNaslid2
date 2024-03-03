using System.Collections;

namespace CSharpNaslid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5 };
            IntArray intArray = new IntArray(elements);

            Console.WriteLine($"Кількість елементів менших за 3: {intArray.Less(3)}");
            Console.WriteLine($"Кількість елементів більших за 3: {intArray.Greater(3)}");
        }
    }
}
