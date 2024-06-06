using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Premio_Aleatorio : Premio
    {
       public string Consejo1 { get; set; }
       public string Consejo2 { get; set; }
       public double Probabilidad { get; set; } 

       public Premio_Aleatorio (string consejo1, string consejo2, double probabilidad,string nombre, int tipo_Premio, int simbolo1, int simbolo2 , int simbolo3 ) : base(nombre,tipo_Premio,simbolo1,simbolo2,simbolo3)
       {
            Consejo1 = consejo1;
            Consejo2 = consejo2;
            Probabilidad = probabilidad;
       }
        public override string MostrarConsejo()
        {
            //Al ser un premio aleatorio creamos un dato Ramdom

            Random ramdom = new Random();

            return ramdom.NextDouble() < Probabilidad ? Consejo1 : Consejo2;
        }
    }
}
