using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid2
{
    public class IntArray : IOutput, IMath, ISort, ICalc
    {
        private int[] elements;

        public IntArray(int[] elements)
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

        public int Max()
        {
            int max = elements[0];
            foreach (int element in elements)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = elements[0];
            foreach (int element in elements)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return (float)sum / elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int element in elements)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(elements);
        }

        public void SortDesc()
        {
            Array.Sort(elements);
            Array.Reverse(elements);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int element in elements)
            {
                if (element < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int element in elements)
            {
                if (element > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
