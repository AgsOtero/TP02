using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class ManejadorDePalabras
    {
        private Palabra[] iListaPalabras;

        public ManejadorDePalabras()
        {
            
            this.iListaPalabras = new Palabra[30];
            this.iListaPalabras[0] = new Palabra("mesa");
            this.iListaPalabras[1] = new Palabra("celular");
            this.iListaPalabras[2] = new Palabra("computadora");
            this.iListaPalabras[3] = new Palabra("silla");
            this.iListaPalabras[4] = new Palabra("elefante");
            this.iListaPalabras[5] = new Palabra("perro");
            this.iListaPalabras[6] = new Palabra("banco");
            this.iListaPalabras[7] = new Palabra("pelota");
            this.iListaPalabras[8] = new Palabra("futbol");
            this.iListaPalabras[9] = new Palabra("tablet");
            this.iListaPalabras[10] = new Palabra("botella");
            this.iListaPalabras[11] = new Palabra("ventana");
            this.iListaPalabras[12] = new Palabra("auto");
            this.iListaPalabras[13] = new Palabra("avion");
            this.iListaPalabras[14] = new Palabra("milanesa");
            this.iListaPalabras[15] = new Palabra("fideos");
            this.iListaPalabras[16] = new Palabra("programa");
            this.iListaPalabras[17] = new Palabra("foto");
            this.iListaPalabras[18] = new Palabra("cajon");
            this.iListaPalabras[19] = new Palabra("pajaro");
            this.iListaPalabras[20] = new Palabra("gato");
            this.iListaPalabras[21] = new Palabra("presidente");
            this.iListaPalabras[22] = new Palabra("argentina");
            this.iListaPalabras[23] = new Palabra("galpon");
            this.iListaPalabras[24] = new Palabra("sol");
            this.iListaPalabras[25] = new Palabra("mochila");
            this.iListaPalabras[26] = new Palabra("facebook");
            this.iListaPalabras[27] = new Palabra("taza");
            this.iListaPalabras[28] = new Palabra("puente");
            this.iListaPalabras[29] = new Palabra("facultad");
        }
        public string PalabraRandom()
        {
            Random rnd = new Random();
            return (this.iListaPalabras[rnd.Next(0, this.iListaPalabras.Length - 1)]);
            
        }
    }
}
