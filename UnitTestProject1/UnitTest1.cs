using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TratamientoDatos;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            Logica l = new Logica();
            Datos d = new Datos();
            d.Nombre = "Miguel";
            d.PrimerNumero = 15;
            d.SegundoNumero = 30;
            string cadena = l.MuestraDatos(d);
            string cadenaEsperada = "Miguel---15---30";
            Assert.AreEqual(cadenaEsperada, cadena);
        }
    }
}
