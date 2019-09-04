using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Controlador
    {
        public Controlador()
        {

        }


        public double CalcularPerimetroTriangulo(double pPuntoX1, double pPuntoY1, double pPuntoX2, double pPuntoY2, double pPuntoX3, double pPuntoY3)
        {
            Punto punto1 = new Punto(pPuntoX1, pPuntoY1);
            Punto punto2 = new Punto(pPuntoX2, pPuntoY2);
            Punto punto3 = new Punto(pPuntoX3, pPuntoY3);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return (triangulo.Perimetro);

        }

        public double CalcularAreaTriangulo(double pPuntoX1, double pPuntoY1, double pPuntoX2, double pPuntoY2, double pPuntoX3, double pPuntoY3)
        {
            Punto punto1 = new Punto(pPuntoX1, pPuntoY1);
            Punto punto2 = new Punto(pPuntoX2, pPuntoY2);
            Punto punto3 = new Punto(pPuntoX3, pPuntoY3);

            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return (triangulo.Area);

        }
        public double CalcularAreaCirculo(double pPuntoX, double pPuntoY, double pRadio)
        {

            Circulo circulo = new Circulo(pPuntoX, pPuntoY, pRadio);

            return (circulo.Area);
        }

        public double CalcularPerimetroCirculo(double pPuntoX, double pPuntoY, double pRadio)
        {

            Circulo circulo = new Circulo(pPuntoX, pPuntoY, pRadio);

            return (circulo.Perimetro);
        }
    }
}




