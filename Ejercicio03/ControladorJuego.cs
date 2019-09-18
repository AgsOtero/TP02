using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class ControladorJuego
    {
        private ManejadorDePalabras iManejador;
        private Juego iJuego;
        private Partida iPartida;

        public ControladorJuego ()
            {
            this.iManejador = new ManejadorDePalabras();
            this.iJuego = new Juego();
                            
            }
        public void IniciarPartida (string pJugador, int pFallosPermitidos)
        {
            Palabra palabraPartida;
            palabraPartida = iManejador.SeleccionarPalabra();
            this.iPartida = new Partida(iCantidadFallosPermitidos, iJugador, iPalabra);


        }

        //Valida un Intento si no se ha ingresado esa letra anteriormente 
        public bool Intento (char Letra)
        {
            if (this.iPartida.LetraProbada(letra))
            {
                return (false);
            }
            else
                this.iPartida.Intento(letra);
             return (true);
        }

        //Devuelve lista de todas las letras probadas
        public List<char> LetrasProbadas()
        {
            return (this.iPartida.LetrasProbadas());
        }

        public bool GanoPartida()
        {
            return (this.iPartida.Gano());
        }
        public bool EnCurso()
            {
            return (this.iPartida.EnCurso());
        }
        public void FinalizarPartida()
        {
            this.iPartida.CalcularDuracion();
            this.iJuego.FinalizarPartida(iPartida);
        }
        public string DevolverPalabraFormada()
        {
            return (this.iPartida.DevolverPalabraFormada());
        }
    }   public string MejoresTiempos()
        {
        return (this.iJuego.MejoresTiempos);
        }
}
