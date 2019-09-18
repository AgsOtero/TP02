using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        //Constructor

        public Cuenta(Moneda pMoneda) : this(0, pMoneda) //Llama al otro constructor.
        {

        }
        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }
        //Propiedades
        public double Saldo { get { return this.iSaldo; } }
        //Metodos
        public void AcreditarSaldo(double pSaldo)
        {
            iSaldo += pSaldo;

        }
        public bool DebitarSaldo(double pSaldo)
        {
            if (pSaldo > iSaldo)
            {
                return false;
            }
            iSaldo -= pSaldo;
            return true;
        }
        

    }
            
}

