namespace CSharpNaslid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5 };
            Array array = new Array(elements);

            Console.WriteLine("Виклик методу Show():");
            array.Show();

            Console.WriteLine("\nВиклик методу Show(string info):");
            array.Show("Це інформаційне повідомлення.");
        }
    }
}
