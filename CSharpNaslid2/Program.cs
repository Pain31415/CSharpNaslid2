namespace CSharpNaslid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 5, 3, 8, 1, 4 };
            IntArray intArray = new IntArray(elements);

            Console.WriteLine("Масив до сортування:");
            intArray.Show();

            Console.WriteLine("\nСортування за зростанням:");
            intArray.SortAsc();
            intArray.Show();

            Console.WriteLine("\nСортування за спаданням:");
            intArray.SortDesc();
            intArray.Show();

            Console.WriteLine("\nСортування в залежності від параметра (за зростанням):");
            intArray.SortByParam(true);
            intArray.Show();

            Console.WriteLine("\nСортування в залежності від параметра (за спаданням):");
            intArray.SortByParam(false);
            intArray.Show();
        }
    }
}
