namespace CSharpNaslid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5, 2, 3, 4, 5, 6 };
            IntArray intArray = new IntArray(elements);

            Console.WriteLine($"Кількість унікальних значень: {intArray.CountDistinct()}");

            int valueToCompare = 3;
            Console.WriteLine($"Кількість елементів, рівних {valueToCompare}: {intArray.EqualToValue(valueToCompare)}");
        }
    }
}
