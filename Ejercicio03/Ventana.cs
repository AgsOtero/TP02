using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ventana
    {
        private ControladorDeJuego iControlador;
        private List<Partida> iPartidas;
        private List<Char> iLetrasProbadas;

        public Ventana(ControladorDeJuego pControlador)
        {
            this.iControlador = pControlador;
        }
        public void Principal()
        {
            Console.Clear();
            Console.WriteLine("JUEGO");
            Console.WriteLine();
            Console.WriteLine("1.Nueva Partida");
            Console.WriteLine("2.Lista Mejores Partidas");


        }
        public void SelecionarNombre ()
        {
            Console.Clear();
            Console.Write("Jugador: ");
        }
        public void SeleccionarCantidadIntentos()
        {
            Console.Write("Cantidad de Fallos Permitidos: ");
        }
        public void Partida()
        {
            Console.Clear();
            Console.WriteLine(iControlador.DevolverPalabraFormada());
            Console.WriteLine();
            Console.WriteLine("Elija una letra");
            Console.WriteLine();
            this.iLetrasProbadas = iControlador.LetrasProbadas();
            if (this.iLetrasProbadas.Count > 0)
            {
                Console.WriteLine("Letras ya probadas ");
                for (int i=0;i<this.iLetrasProbadas.Count;i++)
                {
                    Console.WriteLine($" {this.iLetrasProbadas[i]}");
                }
            }
        }
        public void LetraYaElegida()
        {
            Console.Clear();
            Console.WriteLine("La letra seleccionada ya ha sido elegida");
            Console.WriteLine("Toque cualquier tecla para continuar");
            Console.ReadLine();

        }
        public void Gano()
        {
            Console.Clear();
            Console.WriteLine($"GANO!!!La palabra era: {iControlador.DevolverPalabraFormada()}");

        }
        public bool MejoresPartidas()
        {
            Console.Clear();
            this.iPartidas = this.iControlador.ListaMejoresPartidas();
            if (this.iPartidas.Count>0)
            {
                for (int i=0;i<this.iPartidas.Count;i++)
                {
                    Console.WriteLine($"Jugador: {iPartidas[i].Jugador}  Tiempo: {iPartidas[i].Duracion}");
                }
                return (true);
                }
            else
            {
                return (false);
            }
        }

        public void NoHayPartidasJugadas()
        {
            Console.Clear();
            Console.WriteLine("No hay partidas jugadas");
        }
    }
}
