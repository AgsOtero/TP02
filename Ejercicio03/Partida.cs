using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Partida
    {
        private string iJugador;
        private string iPalabra;

        private DateTime iFecha;
        private TimeSpan iDuracion;

        private int iCantidadFallosPermitidos;
        private int iCantidadFallosCometidos;
        private int iCantidadAciertos;
        private List<char> iLetrasProbadas;

        private bool PartidaActivada;
        private bool PartidaGanada;

        //Constructor

        public Partida(int pCantidadFallosPermitidos, string pJugador, Palabra pPalabra)
        {
            this.iJugador = pJugador;
            this.iPalabra = pPalabra;
            this.iFecha = DateTime.Now;
            this.iCantidadFallosPermitidos = pCantidadFallosPermitidos;
            this.iLetrasProbadas = new List<char>();
            this.iPartidaActivada = true;
            this.iPartidaGanada = false;

        }
        //Propiedades
        public string Jugador
        {
            get { return this.iJugador; }
        }
        public int CantidadFallosCometidos
        {
            get { return this.iCantidadFallosCometidos; }
            set { this.iCantidadFallosCometidos = value; }
        }
        public DateTime Fecha
        {
            get { return this.iFecha; }
        }
        public TimeSpan Duracion
        {
            get { return this.iDuracion; }
        }
        public Palabra Palabra
        {
            get { return this.iPalabra; }
        }
        public int FallosPermitidos
        {
            get { return this.iCantidadFallosPermitidos; }
        }
        public int CantidadAciertos
        {
            get { return this.iCantidadAciertos; }
        }
        //Metodo que calcula la duracion de la partida, restando a la hora inicial
        // la hora actual cuando termine la partida
        public void CalcularDuracion()
        {
            this.iDuracion = this.iFecha - DateTime.Now;
        }

        public string DevolverPalabra()
        {
            return (this.iPalabra.PalabraFormada);
        }
        public List<char> LetrasProbadas()
        {
            return (this.iLetrasProbadas);
        }
        public bool Gano()
        {
            return (this.iPartidaGanada);
        }

        public bool EnCurso()
        {
            return (this.iPartidaActivada);
        }
        //Busca si en la Lista, la letra ya ha sido ingresada
        public bool LetraProbada(char pLetra)
        {
            if (this.iLetrasProbadas.Contains(pLetra))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        public void Intento(char pLetra)
        {
            this.iLetrasProbadas.Add(pLetra);
            ResultadoDTO resultado = new ResultadoDTO();
            resultado = this.Palabra.LetraEnPalabra(pLetra);
            if (resultado.Pertenece == false) ;
            {
                iCantidadFallosCometidos++;
                if (iCantidadFallosCometidos > iCantidadFallosPermitidos)
                {
                    this.iPartidaActivada = false;
                    this.iPartidaGanada = true;
                }
                 
                else
                {
                    iCantidadAciertos++;
                    if (iCantidadAciertos == iPalabra.PalabraActual.Length)
                    {
                        this.iPartidaActivada(true);
                        this.iPartidaGanada(true);

                    }
                }
            }
        }
    }
}

  
