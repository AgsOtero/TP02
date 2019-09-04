using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        //Constructor


        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;

        }
        //Propiedades
        public Punto Punto1
        {
            get { return (this.iPunto1); }

        }
        public Punto Punto2
        {
            get { return (this.iPunto2); }

        }
        public Punto Punto3
        {
            get { return (this.iPunto3); }

        }
        //Agrego Propiedades del Punto para calcular los Lados

        public double Lado1 { get { return (Punto1.CalcularDistanciaDesde(Punto2)); } }
        public double Lado2 { get { return (Punto1.CalcularDistanciaDesde(Punto3)); } }
        public double Lado3 { get { return (Punto2.CalcularDistanciaDesde(Punto3)); } }


        //Sigo con las otras propiedades

        public double Perimetro
        {
            get { return (Lado1 + Lado2 + Lado3); }
        }
        public double Area
        {
            get { return (Math.Sqrt((this.Perimetro / 2) * ((this.Perimetro / 2) - this.Lado1) * ((this.Perimetro / 2) - this.Lado2) * ((this.Perimetro / 2) - this.Lado3))); }


        }
    }
}





