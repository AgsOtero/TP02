using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        //Constructores
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;

        }
        public Circulo(double pX, double pY, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX, pY);

        }
        //Propiedades
        public double Radio
        {
            get { return this.iRadio; }

        }

        public double Centro
        {
            get { return this.iRadio; }
            
        }

        public double Area
        {
            get { return (Math.PI * Math.Pow(this.iRadio, 2)); }
        }
        public double Perimetro
        {
            get { return (2 * Math.PI * this.iRadio); }
        }

    }
}

