using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid2
{
    public class IntArray : ICalc2
    {
        private int[] elements;

        public IntArray(int[] elements)
        {
            this.elements = elements;
        }

        public int CountDistinct()
        {
            return elements.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int element in elements)
            {
                if (element == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
