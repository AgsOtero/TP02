using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Palabra
    {
        public string iPalabra;
        public string iPalabraFormada;

        //Constructor

        public Palabra(string pPalabra)
        {
            this.iPalabra = pPalabra;
            this.iPalabraFormada = "";
            for (int i = 0; i < pPalabra.Length; i++)
            {
                this.iPalabraFormada += "_";

            }
        }

        // Propiedades
        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }

        }
        public string PalabraFormada
        {
            get { return this.iPalabraFormada; }
            set { this.iPalabraFormada = value; }

        }
        //Metodo que devuelve un DTO resultado indicando si la letra existe en la palabra
        public ResultadoDTO LetraEnPalabra (char pLetra)
        {
            ResultadoDTO resultado = new ResultadoDTO();
            int Aciertos = 0;
            for (int i = 0;i < this.Palabra.Length;i++)
            {
                if (this.Palabra[i]=pLetra)
                {
                    Aciertos = +1;
                    this.PalabraFormada = ReemplazarLetra(pLetra, this.PalabraFormada, i);
                }
            }
            resultado.CantidadAciertos = Aciertos;
            resultado.PalabraFormada = this.PalabraFormada;
            if (Aciertos>0)
            {
                resultado.Pertenece(true);
            }
            else
            {
                resultado.Pertenece(false);
            }
            return (resultado);
        }
        public string ReemplazarLetra(char pLetra,string pPalabra,int pLugar)
        {
            string PalabraModificada = "";
            for (int i=0; i < pPalabra.Length;i++)
            {
                if (i==pLugar)
                {
                    PalabraModificada = +pLetra;    
                }
                else
                {
                    PalabraModificada = +pPalabra[i];
                }
            }
            return (PalabraModificada);
        }


    }
}
