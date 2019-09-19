using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Juego
    {
        private List<Partida> iListaPartidas;

        public Juego()
        {
            this.iListaPartidas = new List<Partida>();
        }
    }
    public void FinalizarPartida(Partida pPartida)
    {
        this.iListaPartida.Add(pPartida);
        OrdenarListaPartidas(this.iListaPartidas);
    }
    private void OrdenarListaPartidas(Lista<Partidas> pLista)
    {
        this.iListaPartidas = Orderby(o => o.iDuracion).ToList();
    }
    private List <Partida> FiltrarGanadores(List<Partida> pLista)
    {
        List<Partida> partidasGanadoras = new List<Partida>();
        if (pLista.Count>0)
        {
            for (int i=0;i<pLista.Count;i++)
            {
                if (pLista[i].Gano())
                {
                    partidasGanadoras.Add(pLista[i]);
                }
            }
        }
        return (PartidasGanadoras);
    }
    public List <Partida> PartidasGanadoras(List<Partidas> pLista)
    {
        List<Partida> mejoresTiempos = new List<Partida>();
        List<Partida> partidasGanadoras = this.FiltrarGanadores(this.iListaPartidas);
        if (partidasGanadoras.Count >= 5)
        {
            for (int i = 0; i < 5; i++)
            {
                mejoresTiempos.Add(partidasGanadoras[i]);
            }

        }
        else
        {
            return (partidasGanadoras);
        }
        return (mejoresTiempos);
    }
       
}
