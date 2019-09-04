using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
   public class Banca
    {
        private Cuenta iCuentaEnDolares;
        private Cuenta iCuentaEnPesos;
        private string iNumero;
        private string iTitular;

        //Constructor
        public Banca()
        {
            Cuenta iCuentaenDolares = new Cuenta(0, null);
            Cuenta iCuentaenPesos = new Cuenta(0, null);

        }
        public Banca(string pNumero, string pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
        }
       
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
