using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {



        static void CrearCuenta(ControladorFachada controladorFachada)
        {
            Console.WriteLine("Ingrese el DNI de la nueva cuenta");
            string dni = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre del titular de la cuenta");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el saldo inicial de la cuenta en Pesos");
            double saldoInicialPesos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el saldo inicial de la cuenta en Dolares");
            double saldoInicialDolar = Convert.ToDouble(Console.ReadLine());
            controladorFachada.CrearCuenta(dni, nombre, saldoInicialPesos, saldoInicialDolar);
            
            
        }
        static void BuscarCuenta(ControladorFachada controladorFachada)
        {
            Console.WriteLine("Ingrese el DNI del titular de la cuenta");
            string dni = Console.ReadLine();
            BancaDTO banca = controladorFachada.InfoCuenta(dni);
            Console.WriteLine("El Titular de la cuenta es: " + banca.Titular);
            Console.WriteLine("El saldo en pesos es: " + banca.SaldoEnPesos);
            Console.WriteLine("El saldo en dolares es: " + banca.SaldoEnDolares);
        }
        static void RealizarTransferencia(ControladorFachada controlador)
        {
            Console.WriteLine("Ingrese el DNI de la cuenta origen");
            string dniOrigen = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI de la cuenta destino");
            string dniDestino = Console.ReadLine();
            Console.WriteLine("Ingrese la moneda");
            string moneda = Console.ReadLine();
            Console.WriteLine("Ingrese la Cantidad a Transferir");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            if (controlador.Transferir(dniOrigen, dniDestino, moneda, cantidad)) 
            {
                Console.WriteLine("La transferencia fue Exitosa");
            }
            else
            
                Console.WriteLine("El cliente no posee saldo para realizar la transferencia");
            
        }
        static void Main(string[] args)
        {

            ControladorFachada controlador = new ControladorFachada();
            Console.WriteLine("Seleccione la opcion :");
            Console.WriteLine();
            Console.WriteLine("1 : CREAR CUENTA");
            Console.WriteLine("2 : BUSCAR CUENTA");
            Console.WriteLine("3 : REALIZAR TRANSFERENCIA");

            ConsoleKey iSeleccion = Console.ReadKey().Key;

            while (iSeleccion != ConsoleKey.Escape)
            {
                switch (iSeleccion)
                {
                    case ConsoleKey.D1:
                        CrearCuenta(controlador);
                        break;

                    case ConsoleKey.D2:
                        BuscarCuenta(controlador);
                        break;
                    case ConsoleKey.D3:
                        RealizarTransferencia(controlador);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Seleccione la opcion :");
                        Console.WriteLine();
                        Console.WriteLine("1 : CREAR CUENTA");
                        Console.WriteLine("2 : BUSCAR CUENTA");
                        Console.WriteLine("3 : REALIZAR TRANSFERENCIA");
                        Console.WriteLine();
                        Console.WriteLine("vuelva a seleccionar");
                        break;
                }
                iSeleccion = Console.ReadKey().Key;
            }
        }
    }
}

