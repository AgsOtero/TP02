using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
   public class Banca
    {
        public Cuenta iCuentaEnDolares;
        public Cuenta iCuentaEnPesos;
        public string iNumero;
        public string iTitular;


        //Constructor
        public Banca(string pNumero, string pTitular)
        {
            Moneda Peso = new Moneda("ARS", "Pesos","$");
            Moneda Dolar = new Moneda("US", "Dolar", "U$D");
            iNumero = pNumero;
            iTitular = pTitular;
            iCuentaEnDolares = new Cuenta(0, Dolar);
            iCuentaEnPesos = new Cuenta(0, Peso);
        }
            
        //Properties
        public Cuenta CuentaEnPesos { get { return this.iCuentaEnPesos; }}   
        
        public Cuenta CuentaEnDolares {get { return this.iCuentaEnDolares; }}

        public string Numero { get { return this.iNumero; }}
        public string Titular{get { return this.iTitular; }}

       
        
    }
}
