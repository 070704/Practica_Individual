using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Admin : Usuario
    {

        private string  Password { get; set; }  
        public List<Premio> PremiosActuales { get;private set; }

        public Admin(List<Premio>premios_actuales, string password, List<Premio> premios) : base(premios)
        {
            Password = password;
            PremiosActuales = premios_actuales; 
        }
        public Admin() { }

        public override void Menu()
        {
            
        }




    }
}
