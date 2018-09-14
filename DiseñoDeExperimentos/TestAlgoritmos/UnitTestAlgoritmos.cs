using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiseñoDeExperimentos;
using System.Linq;

namespace TestAlgoritmos
{
    [TestClass]
    public class UnitTestAlgoritmos
    {

        Program relacion = new Program();
        

        [TestMethod]
        public void TestQuickSortEntradaPequeña()
        {
            int [] arregloP = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            
            relacion.QuickSortP(arregloP, 0, arregloP.Length - 1);
            int[] resultado = { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i=0; i<arregloP.Length;i++)
            {
                Assert.AreEqual(resultado[i], arregloP[i]);
            }

        }

        
        [TestMethod]
        public void TestRandomizedQSEntradaPequeña()
        {
            int []arregloP = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            relacion.RandomizeQSP(arregloP, 0, arregloP.Length - 1);
            int [] result = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i =0; i<arregloP.Length;i++)
            {
                Assert.AreEqual(result[i], 0, arregloP.Length - 1);
            }
        }


        [TestMethod]
        public void TestPartitionEntradaPequeña()
        {
            
            
            int[] arregloP = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            relacion.PartitionP(arregloP,0,arregloP.Length-1);
            int[] result = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < arregloP.Length; i++)
            {
                Assert.AreEqual(result[i], 0, arregloP.Length - 1);
            }
        }


        [TestMethod]
        public void TestRandPartiEntradaPequeña()
        {

            int[] arregloP = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            relacion.PartitionP(arregloP, 0, arregloP.Length - 1);
            int[] result = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < arregloP.Length; i++)
            {
                Assert.AreEqual(result[i], 0, arregloP.Length - 1);
            }
        }


        //Entradas grandes

        [TestMethod]
        public void TestQuickSortEntradaGrande()
        {


            int[] arregloP = relacion.GeneradorArreglosP(3);
            relacion.QuickSortP(arregloP, 0, arregloP.Length - 1);

            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);


        }

        [TestMethod]
        public void TestRandomizedQSEntradaGrande()
        {

            int[] arregloP = relacion.GeneradorArreglosP(3);
            arregloP.OrderBy(a => a).ToArray();
            relacion.RandomizeQSP(arregloP, 0, arregloP.Length - 1);

            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);
            

        }

        [TestMethod]
        public void TestPartitionEntradaGrande()
        {

            int[] arregloP = relacion.GeneradorArreglosP(3);
            arregloP.OrderBy(a => a).ToArray();
            relacion.PartitionP(arregloP, 0, arregloP.Length - 1);

            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);



        }

        [TestMethod]
        public void TestRandPartiEntradaGrande()
        {
            int[] arregloP = relacion.GeneradorArreglosP(3);
            arregloP.OrderBy(a => a).ToArray();
            relacion.RandPartiP(arregloP, 0, arregloP.Length - 1);

            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);


        }

        //Entradas aleatorias
        [TestMethod]
        public void TestQuickSortEntradaAleatoria()
        {

            int[] arregloP = relacion.GeneradorArreglosP(3);
            relacion.QuickSortP(arregloP, 0, arregloP.Length - 1);
            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);


        }

        [TestMethod]
        public void TestRandomizeQSEntradaAleatoria()
        {
            int[] arregloP = relacion.GeneradorArreglosP(3);
            relacion.RandomizeQSP(arregloP, 0, arregloP.Length - 1);
            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);

        }

        [TestMethod]
        public void TestPartitionEntradaAleatoria()
        {
            int[] arregloP = relacion.GeneradorArreglosP(3);
            relacion.PartitionP(arregloP, 0, arregloP.Length - 1);
            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);

        }

        [TestMethod]
        public void TestRandPartiEntradaAleatoria()
        {
            int[] arregloP = relacion.GeneradorArreglosP(3);
            relacion.RandPartiP(arregloP, 0, arregloP.Length - 1);
            bool ordenado = relacion.estaOrdenado(arregloP);
            Assert.IsTrue(ordenado);

        }


    }
}
