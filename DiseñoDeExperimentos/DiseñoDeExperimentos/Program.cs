using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoDeExperimentos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Para Arreglos de un tamaño menor a 10^4
            //QuickSort:
            //timeQuickSortD3(1);    
            //timeQuickSortD3(2);
            //timeQuickSortD3(3);
            //RandomizeQS               Formato: 1.Aleatorio. milis 1.Ascendente milis 1.Descendente milis \n 2.Aleatorio. milis 2.Ascendente milis 2.Descendente milis
            //timeRandomizeQSD3(1);
            //timeRandomizeQSD3(2);
            //timeRandomizeQSD3(3);

            //Para arreglos entre 10^4 y 10^5

            //QS Aleatorio
            //timeQuickSortAleatorio(4);
            //timeQuickSortAleatorio(5);
            //RQS Aleatorio
            //timeRandomizeQSAleatorio(4);
            //timeRandomizeQSAleatorio(5);


            //QS Ascendente
            //timeQuickSortAscendente(4);
            //timeQuickSortAscendente(5);
            //RQS Ascendente
            //timeRandomizeQSAscendente(4);
            //timeRandomizeQSAscendente(5);

            //QS Descendente
            //timeQuickSortDescendente(4);
            //timeQuickSortDescendente(5);
            //RQS Descendente
            //timeRandomizeQSDescendente(4);
            //timeRandomizeQSDescendente(5);




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

        private static int Partition(int[] A, int p, int r)
        {
            int x = A[r];
            int temp;

            int i = p;
            for (int j = p; j < r; j++)
            {
                if (A[j] <= x)
                {
                    temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                    i++;
                }
            }

            A[r] = A[i];
            A[i] = x;
            return i;
        }
        public static void RandomizeQS(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = RandParti(A, p, r);
                RandomizeQS(A, p, q - 1);
                RandomizeQS(A, q+1, r);
            }

        }

        public static int RandParti(int[] A, int p, int r)
        {
            Random n = new Random();
            int i = n.Next(p,r);
            int aux = A[r];
            A[r] = A[i];
            A[i] = aux;
            return Partition(A, p, r);
        }

        public static void imprimirArreglo(int[] A)
        {
            String mensaje = "";
            for (int i = 0; i < A.Length; i++)
            {
                mensaje += A[i] + " ";
            }
            Console.WriteLine(mensaje);

        }

        public static void timeQuickSortAleatorio(int pot)
        {
            String mensaje = "";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                Stopwatch t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ". " + t.Elapsed.TotalMilliseconds + "\n";
            }
            

        }
        public static void timeQuickSortDescendente(int pot)
        {
            String mensaje = "";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                A =  A.OrderByDescending(b => b).ToArray();
                Stopwatch t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ". " + t.Elapsed.TotalMilliseconds + "\n";
            }
            Console.WriteLine(mensaje);

        }
        public static void timeQuickSortAscendente(int pot)
        {
            String mensaje = "";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                A = A.OrderBy(b => b).ToArray();
                Stopwatch t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ". " + t.Elapsed.TotalMilliseconds + "\n";
            }
            Console.WriteLine(mensaje);

        }
        public static void timeRandomizeQSAleatorio(int pot)
        {
            String mensaje = "";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                Stopwatch t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ". " + t.Elapsed.TotalMilliseconds + "\n";
            }
            Console.WriteLine(mensaje);

        }
        public static void timeRandomizeQSDescendente(int pot)
        {
            String mensaje = "";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                A = A.OrderByDescending(b => b).ToArray();
                Stopwatch t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ". " + t.Elapsed.TotalMilliseconds + "\n";
            }
            Console.WriteLine(mensaje);

        }
 
        public static void timeRandomizeQSAscendente(int pot)
        {
            String mensaje = "";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                A = A.OrderBy(b => b).ToArray();
                Stopwatch t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ". " + t.Elapsed.TotalMilliseconds + "\n";
            }
            Console.WriteLine(mensaje);

        }
        public static void timeQuickSortD3(int pot)
        {
            String mensaje = "QuickSort: \n";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                Stopwatch t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ".Aleatorio " + t.Elapsed.TotalMilliseconds + " ";
                t.Stop();
                t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ".Ascendente " + t.Elapsed.TotalMilliseconds + " ";
                t.Stop();
                A.OrderByDescending(b => b);
                t = Stopwatch.StartNew();
                QuickSort(A, 0, A.Length - 1);
                mensaje += i + ".Descendente " + t.Elapsed.TotalMilliseconds + " \n";
            }
            Console.WriteLine(mensaje);


        }
        public static void timeRandomizeQSD3(int pot)
        {
            String mensaje = "Random QuickSort: \n";
            int[] A = null;
            for (int i = 0; i < 1000; i++)
            {
                A = GeneradorArreglos(pot);
                Stopwatch t = Stopwatch.StartNew();
                RandomizeQS(A, 0, A.Length - 1);
                mensaje += i + ".Aleatorio " + t.Elapsed.TotalMilliseconds + " ";
                t.Stop();
                t = Stopwatch.StartNew();
                RandomizeQS(A, 0, A.Length - 1);
                mensaje += i + ".Ascendente " + t.Elapsed.TotalMilliseconds + " ";
                t.Stop();
                A = A.Reverse().ToArray();
                t = Stopwatch.StartNew();
                RandomizeQS(A, 0, A.Length - 1);
                mensaje += i + ".Descendente " + t.Elapsed.TotalMilliseconds + " ";

            }
            Console.WriteLine(mensaje);

        }



        public static int[] GeneradorArreglos(int m)
        {
            int k = (int)Math.Pow(10, m);
            int[] A = new int[k];
            Random n = new Random();
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = n.Next(0, 100);
                A[i] = temp;
            }

            return A;

        }




        //--------------------------------------------------------------------------------------------
        // Para probarlos en UnitTest

        public void QuickSortP(int[] A, int p, int r)
        {

            if (p < r)
            {
                int q = Partition(A, p, r);
                QuickSortP(A, p, q - 1);
                QuickSortP(A, q + 1, r);
            }


        }

        public void RandomizeQSP(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = RandPartiP(A, p, r);
                RandomizeQSP(A, p, q - 1);
                RandomizeQSP(A, q + 1, r);
            }

        }

        public int RandPartiP(int[] A, int p, int r)
        {
            Random n = new Random();
            int i = n.Next(p, r);
            int aux = A[r];
            A[r] = A[i];
            A[i] = aux;
            return PartitionP(A, p, r);
        }


        public int PartitionP(int[] A, int p, int r)
        {
            int x = A[r];
            int temp;

            int i = p;
            for (int j = p; j < r; j++)
            {
                if (A[j] <= x)
                {
                    temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                    i++;
                }
            }

            A[r] = A[i];
            A[i] = x;
            return i;
        }

        public bool estaOrdenado(int[] arreglo)
        {
            bool estaordenado = false;
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 1; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[i] < arreglo[j])
                    {
                        estaordenado = true;
                    }
                }
            }

            return estaordenado;
        }


        //---------------------------------------------------------------------------------------------------------


    }
}
