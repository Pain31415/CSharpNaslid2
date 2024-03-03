using ArrayProject;
using System;
using IMathProject;

namespace CSharpNaslid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5 };
            IntArray intArray = new IntArray(elements);

            intArray.Show();

            Console.WriteLine($"Максимум: {intArray.Max()}");
            Console.WriteLine($"Мінімум: {intArray.Min()}");
            Console.WriteLine($"Середнє: {intArray.Avg()}");

            int valueToSearch = 3;
            if (intArray.Search(valueToSearch))
            {
                Console.WriteLine($"Значення {valueToSearch} знайдено.");
            }
            else
            {
                Console.WriteLine($"Значення {valueToSearch} не знайдено.");
            }
        }
    }
}
