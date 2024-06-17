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

        public Premio_Simple(int id,string consejo, string nombre, int tipo_Premio, string simbolo1, string simbolo2, string simbolo3) : base(id,nombre, tipo_Premio, simbolo1, simbolo2, simbolo3)
        {
            Consejo = consejo;
        }

        public override string MostrarConsejo()
        {
            return Consejo;
        }

        public override string MostrarInfo()
        {
            return $"Premio Simple | {base.MostrarInfo()} | Consejo: {Consejo}";
        }


    }
}