using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiseñoDeExperimentos;

namespace TestAlgoritmos
{
    [TestClass]
    public class UnitTestAlgoritmos
    {

        Program relacion = new Program();
        //Entrada pequeña 
        int[] entradaP = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        int[] entradaG = { };

        [TestMethod]
        public void TestQuickSortEntradaPequeña()
        {
            int [] arregloP = entradaP;
            
            relacion.QuickSortP(arregloP, 0, arregloP.Length - 1);
            //Resultado esperado
            int[] resultado = { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i=0; i<arregloP.Length;i++)
            {
                Assert.AreEqual(resultado[i], arregloP[i]);
            }

        }

        
        [TestMethod]
        public void TestRandomizedQSEntradaPequeña()
        {
            int []arregloP = entradaP;
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
            
            
            int[] arregloP = entradaP;
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

            int[] arregloP = entradaP;
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
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void TestRandomizedQSEntradaGrande()
        {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void TestPartitionEntradaGrande()
        {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void TestRandPartiEntradaGrande()
        {
            Assert.AreEqual(1, 2);
        }


    }
}
