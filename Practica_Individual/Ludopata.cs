using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Ludopata : Usuario
    {
        public Ludopata() { }
        public Ludopata(List<Premio> premios) : base(premios) 
        {
        }
        public override void Menu()
        {
            
        }
    }
}
