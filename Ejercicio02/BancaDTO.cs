using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class BancaDTO
    {
        public string Titular;
        public double SaldoEnDolares;
        public double SaldoEnPesos;

        public BancaDTO(Banca banca)
        {
            Titular = banca.iTitular;
            SaldoEnDolares = banca.CuentaEnDolares.Saldo;
            SaldoEnPesos = banca.CuentaEnPesos.Saldo;


        }
    }
}
