using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoDeExperimentos
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        public static void QuickSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(A, p, r);
                QuickSort(A, p, q - 1);
                QuickSort(A, q + 1, r);
            }


        }

        public static int Partition(int[] A, int p, int r)
        {
            int X = A[r];
            int i = p - 1;
            for (int j = p; j < r - 1; j++)
            {
                if (A[j] <= X)
                {
                    i = i + 1;
                    A[i] = A[j];
                }
                A[i + 1] = A[r];
            }
            return i + 1;
        }
    }
}
