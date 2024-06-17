using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal abstract  class Premio
    {
        public int id { get; protected set; }
        public string Nombre { get; set; }  
        public int Tipo_Premio { get; set; }
        public string Simbolo1 { get; set; }
        public string Simbolo2 { get; set; }
        public string Simbolo3 { get; set; }

        public Premio (int id,string nombre, int tipo_Premio, string simbolo1, string simbolo2, string simbolo3) 
        {
            this.id = id;
            Nombre = nombre;
            Tipo_Premio = tipo_Premio;
            Simbolo1 = simbolo1;    
            Simbolo2 = simbolo2;
            Simbolo3 = simbolo3;
        }
        public abstract string MostrarConsejo();
        public virtual string MostrarInfo()
        {
            return $"Nombre: {Nombre} | Primer Símbolo: {Simbolo1} | Segundo Símbolo: {Simbolo2} | Tercer Símbolo: {Simbolo3}";
        }

    }

}
    
   

