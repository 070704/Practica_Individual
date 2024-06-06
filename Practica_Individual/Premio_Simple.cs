using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Premio_Simple : Premio
    {
        public string Consejo { get; set; }

        public Premio_Simple(string consejo, string nombre, int tipo_Premio, int simbolo1, int simbolo2, int simbolo3) : base(nombre, tipo_Premio, simbolo1, simbolo2, simbolo3)
        {
            Consejo = consejo;
        }

        public override string MostrarConsejo()
        {
            return Consejo;


         }

    }
}