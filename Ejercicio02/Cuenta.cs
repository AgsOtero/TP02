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
        public Cuenta ()
            {
            }
           
        public Cuenta (Moneda pMoneda)
        {
            this.iMoneda = pMoneda;
        }
        public Cuenta (double pSaldoInicial,Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }
        //Propiedades
        public double Saldo
        {
            get { return this.iSaldo; }
        }
        //Metodos
        public void AcreditarSaldo (double pSaldo)
        {
            this.iSaldo = iSaldo + pSaldo;
            Console.WriteLine("Su saldo ha sido acreditado");
        }
        public bool DebitarSaldo (double pSaldo)
        {
            if (this.iSaldo - pSaldo > 0)
            {
                iSaldo = iSaldo - pSaldo;
                return (true);
            }
            else
            {
                return (false);
            }
            
            
        }
            
    }
}
