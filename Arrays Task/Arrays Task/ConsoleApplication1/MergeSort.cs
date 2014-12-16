using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MergeSort
    {




        public int[] Sort(int[] mass)
        {

            if (mass.Length == 1)
            {
                return mass;
            }

            int mid = mass.Length / 2;
            return SortedArr(Sort(mass.Take(mid).ToArray()), Sort(mass.Skip(mid).ToArray()));

        }


        private static int[] SortedArr(int[] m1, int[] m2)
        {
            int a = 0;
            int b = 0;
            int[] sorted = new int[m1.Length + m2.Length];
            for (int i = 0; i < m1.Length + m2.Length; i++)
            {
                if (b < m2.Length && a < m1.Length)
                    if (m1[a] > m2[b])
                        sorted[i] = m2[b++];
                    else
                        sorted[i] = m1[a++];
                else
                    if (b < m2.Length)
                        sorted[i] = m2[b++];
                    else
                        sorted[i] = m1[a++];

            }
            return sorted;

        }

    }
}
