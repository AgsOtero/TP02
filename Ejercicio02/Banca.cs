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
        private string iNumero;
        private string iTitular;

        //Constructor
        public Banca(string pNumero, string pTitular)
        {
            Cuenta iCuentaenDolares = new Cuenta(0, new Moneda("US", "Dolares", "USD"));
            Cuenta iCuentaenPesos = new Cuenta(0, new Moneda("AR", "Pesos", "AR"));
            this.iNumero = pNumero;
            this.iTitular = pTitular;

        }
        /*public Banca(string pNumero, string pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
        }
        */
       
        //Propiedad 
        public Cuenta CuentaEnPesos
        {
            get { return this.iCuentaEnPesos; }
         
        }
        public Cuenta CuentaEnDolares
        {
            get { return this.iCuentaEnDolares; }

        }

        public string Numero
        {
            get { return this.iNumero; }
        }
        public string Titular
        {
            get { return this.iTitular; }
        }

    }
}
