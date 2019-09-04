using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Punto
    {
        private double iX;
        private double iY;

        //Constructor Punto
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        //Propiedades Punto
        public double X
        {
            get { return (this.iX); }
        }
        public double Y
        {
            get { return (this.iY); }
        }

        //Metodo del Punto
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow((this.iX - pPunto.X), 2) + Math.Pow((this.iY - pPunto.Y), 2));
        }

    }
}

