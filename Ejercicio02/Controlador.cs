using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Controlador
    {
        private Banca iBanca = new Banca("1", "Agustin");
       

        public bool TransferirACP(double pSaldo)
        {
            double Cotizacion = 60;
            //pSaldo = Cotizacion * 60;
            if (iBanca.iCuentaEnDolares.DebitarSaldo(pSaldo))
              
                {
                pSaldo = pSaldo * Cotizacion;
                iBanca.iCuentaEnPesos.AcreditarSaldo(pSaldo);
                return (true);
                }
            else
            {
                return (false);
            }
            


        }

        public Cuenta GetCuentaEnPesos(String pNumeroDeCuenta)//Necesito Recuperar las cuentas y luego operar sobre ellas.
        {
            return this.iBanca.CuentaEnPesos;
        }
    }
}
