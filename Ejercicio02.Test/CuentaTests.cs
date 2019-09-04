using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio02.Test
{
    [TestClass]
    public class CuentaTests
    {
        [TestMethod]
        public void PruebaAcreditarSaldoConSaldoInicial()
        {

            double iSaldo = 500;
            double mMonto = 300;
            double ResultadoEsperado = 800;
            double Resultado;
            Cuenta mcuenta = new Cuenta(iSaldo, new Moneda("AR", "Peso", "$"));


            mcuenta.AcreditarSaldo(mMonto);

            Resultado = mcuenta.Saldo;


            Assert.AreEqual(ResultadoEsperado, Resultado);

        }


        [TestMethod]
        public void PruebaAcreditarSaldoSinSaldoInicial()
        {


            double mMonto = 300;
            double ResultadoEsperado = 300;
            double Resultado;
            Cuenta mcuenta = new Cuenta(new Moneda("AR", "Peso", "$"));


            mcuenta.AcreditarSaldo(mMonto);

            Resultado = mcuenta.Saldo;


            Assert.AreEqual(ResultadoEsperado, Resultado);

        }

        [TestMethod]
        public void PruebaDebitarSaldoCorrecta()
        {
            double iSaldo = 500;
            double Descuento = 300;
            double ResultadoEsperado = 200;
            double Resultado;
            Cuenta mcuenta = new Cuenta(iSaldo,new Moneda("AR", "Peso", "$"));

            mcuenta.DebitarSaldo(Descuento);
            Resultado = mcuenta.Saldo;

            Assert.AreEqual(ResultadoEsperado, Resultado);
        }
        [TestMethod]
        public void PruebaDebitarSaldoIncorrecta()
        {
            double iSaldo = 200;
            double Descuento = 300;
            double ResultadoEsperado = 200;
            double Resultado;
            Cuenta mcuenta = new Cuenta(iSaldo, new Moneda("AR", "Peso", "$"));

            mcuenta.DebitarSaldo(Descuento);
            Resultado = mcuenta.Saldo;

            Assert.AreEqual(ResultadoEsperado, Resultado);
        }
        [TestMethod]
        public void TrasnferirACP()
        {
            Banca mcuenta = new Banca ("1", "Agustin");
            Cuenta Dolares= new Cuenta(20, new Moneda("US", "Dolar", "$"));
            Cuenta Pesos = new Cuenta(20, new Moneda("AR", "Pesos", "$"));
            double Descuento = 10;
            double Resultado;
            double ResultadoEsperado = 80;
            Controlador iPesos = new Controlador();
            iPesos.TransferirACP(Descuento);
            Resultado = Pesos.Saldo;       
            
            Assert.AreEqual(ResultadoEsperado, Resultado);
        }
    }
}
