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
            int[] A = { 8, 3, 6, 4, 2, 5, 7, 1 };
            QuickSort(A, A[0], A[A.Length - 1]);
            String mensaje = "";
            for (int x = 0; x < A.Length; x++)
            {
                mensaje += A[x] + " ";

            }

            Console.WriteLine(mensaje);
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

        public static void RandomizeQS (int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = RandParti(A, p, r);
                RandomizeQS(A, p, q - 1);
                RandomizeQS(A, q + 1, r);
            }

        }

        public static int RandParti(int[] A, int p, int r)
        {
            Random n = new Random();
            int i = n.Next(p, r);
            int aux = A[r];
            A[r] = A[i];
            A[i] = aux;
            return Partition(A, p, r);
        }

    }
}
