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

        public Premio_Simple(int id,string nombre, string simbolo1, string simbolo2, string simbolo3, string consejo) : base(id,nombre, simbolo1, simbolo2, simbolo3)
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
        public override string ToString()
        {
            return $"1;{base.ToString()};{Consejo};;";
        }


    }
}