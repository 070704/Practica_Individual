using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.WriteLine();
            Console.Write("\tIntroduce una contraseña: ");
            string password = Console.ReadLine();
            if (password != Password)
            {
                Console.Write("\tContraseña incorrecta");
                Thread.Sleep(2000);
            }
            else
            {
                CargarPremios();
            }

        }

        public void CargarPremios() //Cargamos los premios con el archivo CSV
        {
            Console.Write("Introduce la dirección del archivo: ");
            var path = Console.ReadLine();
            if(File.Exists(path))
            {
                string [] cargapremios = File.ReadAllLines(path);
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = null;
                    string[] campos = null; 
                    while ((line = sr.ReadLine()) != null) { }
                }
            }
        }
       

        


    }
}
