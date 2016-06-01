using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pruebaunitariaordenamiento
{
    [TestClass]
    public class UnitTest1
    {
        private int[] resultado = new int[] { 1, 2, 3, 4, 5 };
        private burbuja ordena = new burbuja();
        [TestMethod]
        public void testordenado()
        {
            int[] entrada = new int[] { 1, 2, 3, 4, 5 };
            ordena.ordenar(entrada);
            CollectionAssert.AreEqual(resultado, entrada);
        }
        [TestMethod]
        public void pruebaultimo()
        {
            int[] entrada = new int[] { 5, 1, 2, 3, 4 };
            ordena.ordenar(entrada);
            CollectionAssert.AreEqual(resultado, entrada);
        }
        [TestMethod]
        public void pruebapar()
        {
            int[] entrada = new int[] { 1, 3, 2, 4, 5 };
            ordena.ordenar(entrada);
            CollectionAssert.AreEqual(resultado, entrada);                                                        //Are not equal porque no sabes que par se va a desordenar
        }
        [TestMethod]
        public void pruebaprimero()
        {
            int[] entrada = new int[] { 2, 3, 4, 5, 1 };
            ordena.ordenar(entrada);
            CollectionAssert.AreEqual(resultado, entrada);
        }
        [TestMethod]
        public void pruebainverso()
        {
            int[] entrada = new int[] { 5, 4, 3, 2, 1 };
            ordena.ordenar(entrada);
            CollectionAssert.AreEqual(resultado, entrada);
        }
        [TestMethod]
        public void repetido()
        {
            int[] salida2 = new int[] { 1, 2, 2, 3, 5 };
            int[] entrada = new int[] { 1, 2, 3, 2, 5 };
            ordena.ordenar(entrada);
            CollectionAssert.AreEqual(salida2, entrada);                                                      //Not equal porque no sabes que elemento se va a repetir.
        }

    }
}
