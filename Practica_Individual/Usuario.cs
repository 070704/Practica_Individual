using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal abstract  class Usuario 
    {
        protected static List <Premio> Premios = new List <Premio> ();
        public Usuario() { }

        public Usuario (List<Premio> premios)
        {
            Premios = premios;

        }
        
        
    }
}
