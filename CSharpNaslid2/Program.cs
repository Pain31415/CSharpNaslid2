namespace CSharpNaslid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IntArray intArray = new IntArray(elements);

            Console.WriteLine("Парні елементи масиву:");
            intArray.ShowEven();

            Console.WriteLine("\nНепарні елементи масиву:");
            intArray.ShowOdd();
        }
    }
}
