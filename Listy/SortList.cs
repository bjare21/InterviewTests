using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    public static class SortList
    {
        public static void BubbleSort(int[] tab, int count)
        {
            int pom;
            for (int i = count - 1; i > 0; i--)
            {
                for (int j=0; j<i; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        pom = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = pom;
                    }
                }
            }
        }
    }
}
