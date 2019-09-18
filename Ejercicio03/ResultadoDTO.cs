using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class ResultadoDTO
    {
        public int iCantidadAciertos;
        public string iPalabraFormada;
        public bool iPertenece;

        public  int iCantidadAciertos
        {
            get { return this.iCantidadAciertos; }
            set { this.iCantidadAciertos = value; }
        }
        public string iPalabraFormada
        {
            get { return this.iPalabraFormada; }
            set { this.iPalabraFormada = value; }
        }
        public bool iPertenece
        {
            get { return this.iPertenece; }
            set { this.iPertenece = value; }
        }
    }
}
