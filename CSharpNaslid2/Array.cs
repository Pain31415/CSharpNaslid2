using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid2
{
    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements;
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }
        }

        public void Show(string info)
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"Інформаційне повідомлення: {info}");
        }
    }
}
