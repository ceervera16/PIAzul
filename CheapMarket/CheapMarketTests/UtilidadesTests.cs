using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheapMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapMarket.Tests
{
    [TestClass()]
    public class UtilidadesTests
    {
        [TestMethod()]
        public void NifCorrectoTest()
        {
            string nif = "11111111H";
            bool actual = Utilidades.NifCorrecto(nif);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ComprobarCorreoTest()
        {
            string correo = "prueba@gmail";
            bool actual = Utilidades.ComprobarCorreo(correo);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void ComprobarCorreoTest2()
        {
            string correo = "prueba@gmail.com";
            bool actual = Utilidades.ComprobarCorreo(correo);
            Assert.IsTrue(actual);
        }
    }
}