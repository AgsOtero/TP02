using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio02.Test
{
    [TestClass]
    public class Testdebitarsaldo
    {
        [TestMethod]
        public void PruebaDebitarSaldo()
        {
                
            double iSaldo = 500;
            double pSaldo = 300;
            Boolean ResultadoEsperado = true;
            Boolean Resultado;

            Resultado= Cuenta.DebitarSaldo(pSaldo);

            Assert.AreEqual(ResultadoEsperado, Resultado);
            
        }
    }
}
