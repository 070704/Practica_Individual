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

       public Premio_Aleatorio (int id,string nombre, string simbolo1, string simbolo2,string simbolo3, string consejo1, string consejo2, double probabilidad ) : base(id,nombre,simbolo1,simbolo2,simbolo3)
       {
            Consejo1 = consejo1;
            Consejo2 = consejo2;
            Probabilidad = probabilidad;
       }
        public override string MostrarConsejo()
        {
            //Al ser un premio aleatorio creamos un dato Ramdom

            Random random = new Random();
            //Creo un ramdom para que el programa me muestre o el consejo 1 o el consejo 2//

            return random.Next(0, 100) < Probabilidad * 100 ? Consejo1 : Consejo2;
            
        }

        public override string MostrarInfo()
        {
            return $"Premio Aleatorio | {base.MostrarInfo()} | Primer Consejo: {Consejo1} | Segundo consejo: {Consejo2} | Probabilidad: {Probabilidad}";
        }
        public override string ToString()
        {
            return $"2;{base.ToString()};{Consejo1};{Consejo2};{Probabilidad}";
        }
    }
}
