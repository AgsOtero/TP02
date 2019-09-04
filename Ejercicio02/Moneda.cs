using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Moneda
    {
        private string iCodigoISO;
        private string iNombre;
        private string iSimbolo;

        //Constructor
        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            this.iCodigoISO = pCodigoISO;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }
        //Propiedades

        public string CodigoISO
        {
           get { return this.iCodigoISO; }   
        }
        public string Nombre
        {
            get { return this.iNombre; }
        }
        public string Simbolo
        {
            get { return this.Simbolo; }
        }

    }
}
