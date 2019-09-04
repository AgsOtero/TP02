using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
  
    class Program
    {
        static void PantallaTriangulo(Controlador pControlador)
        {
            double iPuntoX1, iPuntoX2, iPuntoX3, iPuntoY1, iPuntoY2, iPuntoY3;
            Console.Clear();
            Console.WriteLine("TRIANGULO");
            Console.WriteLine();
            Console.WriteLine("Primer punto");
            Console.Write("X = "); iPuntoX1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = "); iPuntoY1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo punto");
            Console.Write("X = "); iPuntoX2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = "); iPuntoY2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tercer punto");
            Console.Write("X = "); iPuntoX3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = "); iPuntoY3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Punto 1: ({iPuntoX1},{iPuntoY1}) ;" +
                $" Punto 2: ({iPuntoX2},{iPuntoY2}) ;" +
                $" Punto 3: ({iPuntoX3},{iPuntoY3})");
            Console.WriteLine();
            Console.WriteLine($"Area del triangulo: " +
                $"{pControlador.CalcularAreaTriangulo(iPuntoX1, iPuntoY1, iPuntoX2, iPuntoY2, iPuntoX3, iPuntoY3)}");
            Console.WriteLine($"Perimetro del triangulo: " +
                $"{pControlador.CalcularPerimetroTriangulo(iPuntoX1, iPuntoY1, iPuntoX2, iPuntoY2, iPuntoX3, iPuntoY3)}");
        }

        static void PantallaCirculo(Controlador pControlador)
        {
            double iPuntoX, iPuntoY, iRadio;
            Console.Clear();
            Console.WriteLine("CIRCULO");
            Console.WriteLine();
            Console.WriteLine("Centro");
            Console.Write("X = "); iPuntoX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = "); iPuntoY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Radio");
            Console.Write("R = "); iRadio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Punto : ({iPuntoX},{iPuntoY}) ;" +
                $" Radio: {iRadio} ;");
            Console.WriteLine();
            Console.WriteLine($"Area del Circulo: " +
                $"{pControlador.CalcularAreaCirculo(iPuntoX, iPuntoY, iRadio)}");
            Console.WriteLine($"Perimetro del Circulo: " +
                $"{pControlador.CalcularPerimetroCirculo(iPuntoX, iPuntoY, iRadio)}");
        }

        static void Main(string[] args)
        {

            Controlador controlador = new Controlador();
            Console.WriteLine("Seleccione la opcion :");
            Console.WriteLine();
            Console.WriteLine("1 : TRIANGULO");
            Console.WriteLine("2 : CIRCULO");

            ConsoleKey iSeleccion = Console.ReadKey().Key;

            while (iSeleccion != ConsoleKey.Escape)
            {
                switch (iSeleccion)
                {
                    case ConsoleKey.D1:
                        PantallaTriangulo(controlador);
                        break;

                    case ConsoleKey.D2:
                        PantallaCirculo(controlador);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Seleccione la opcion :");
                        Console.WriteLine();
                        Console.WriteLine("1 : TRIANGULO");
                        Console.WriteLine("2 : CIRCULO");
                        Console.WriteLine();
                        Console.WriteLine("vuelva a seleccionar");
                        break;
                }
                iSeleccion = Console.ReadKey().Key;
            }
        }
    }
}