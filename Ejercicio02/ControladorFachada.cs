using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
 public class ControladorFachada
    {
        const string peso_moneda = "PESO";
        const string dolar_moneda = "DOLAR";
        RepositorioBanca repositorioCuentas = new RepositorioBanca();
        private double cotizacion = 57;

        internal void CrearCuenta(string dni, string nombre, double saldoInicialPesos, double saldoInicialDolar)
        {
            
            Banca banca = new Banca(dni, nombre);
            banca.iCuentaEnPesos.AcreditarSaldo(saldoInicialPesos);
            banca.iCuentaEnDolares.AcreditarSaldo(saldoInicialDolar);
            repositorioCuentas.Agregar(banca);
        }
        internal bool Transferir(string cOrigen, string cDestino, string moneda, double cantidad)
        {
            Banca origen = repositorioCuentas.Obtener(cOrigen);
            Banca destino = repositorioCuentas.Obtener(cDestino);
            if (origen == null || destino == null)
            {
                return false;
            }
            else 
            {
                if (!TransferirEntreCuenta(origen, moneda, cantidad))
                {
                    return false;
                }
                else
                    return true;
            
            }
        }
       
        public double DolarAPesos(double cantidadDolares)
        {
            return cantidadDolares * cotizacion;
        }
        public double PesoADolar(double cantidadPesos)
        {
            return cantidadPesos / cotizacion;
        }
        private bool TransferirEntreCuenta(Banca cuenta, string moneda, double cantidad)
        {
            Cuenta CuentaOrigen;
            Cuenta CuentaDestino;
            double CantidadTransferida;
            switch (moneda)
            {
                case ControladorFachada.peso_moneda:
                    CuentaOrigen = cuenta.CuentaEnPesos;
                    CuentaDestino = cuenta.CuentaEnDolares;
                    CantidadTransferida = PesoADolar(cantidad);
                    break;

                case ControladorFachada.dolar_moneda:
                    CuentaOrigen = cuenta.CuentaEnDolares;
                    CuentaDestino = cuenta.CuentaEnPesos;
                    CantidadTransferida = DolarAPesos(cantidad);
                    break;
                default:
                    return false;
            }
            if (CuentaOrigen.DebitarSaldo(cantidad) == true) 
            {
                
            }
            else
            {
                return false;
            }
            CuentaDestino.AcreditarSaldo(CantidadTransferida);
            return true;
        }
        internal BancaDTO InfoCuenta(string number)
        {
            return new BancaDTO(repositorioCuentas.Obtener(number));
        }
    }
}
               


        
    

