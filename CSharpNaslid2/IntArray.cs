using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid2
{
    public class IntArray : IOutput2
    {
        private int[] elements;

        public IntArray(int[] elements)
        {
            this.elements = elements;
        }

        public void ShowEven()
        {
            Console.WriteLine("Парні елементи масиву:");
            foreach (int element in elements)
            {
                if (element % 2 == 0)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні елементи масиву:");
            foreach (int element in elements)
            {
                if (element % 2 != 0)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
