using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class RepositorioBanca
    {
        private List<Banca> lBanca = new List<Banca>();
        public Banca Obtener (string pNumero)
        {
            
            return lBanca.Find(x => x.Numero.Equals(pNumero));
        }
        public void Agregar (Banca pBanca)
        {
            lBanca.Add(pBanca);
        }
    
    }
    } 
    
        

