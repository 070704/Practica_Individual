using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Admin : Usuario 
    {
        private  string Password;
        public  List<Premio> PremiosActuales { get; private set; }

        public Admin(List<Premio> premios_actuales, string password, List<Premio> premios) : base(premios)
        {
            Password = password;
            PremiosActuales = premios_actuales;
        }
        public Admin() { }

        public  void Autentification()
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

        public  void CargarPremios() //Cargamos los premios con el archivo CSV
        {
            Console.Write("Introduce la dirección del archivo: ");
            var path = Console.ReadLine();
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = null;
                    string[] campos = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        campos = line.Split(';');
                        switch (int.Parse(campos[0]))
                        {
                            case 1:
                                Premio_Simple ps = new Premio_Simple(campos[1], campos[2], int.Parse(campos[3]), int.Parse(campos[4]), int.Parse(campos[5]), int.Parse(campos[6]));
                                Premios.Add(ps);
                                break;
                            case 2:
                                Premio_Aleatorio pa = new Premio_Aleatorio(campos[1], campos[2], double.Parse(campos[3]), campos[4], int.Parse(campos[5]), int.Parse(campos[6]), int.Parse(campos[7]), int.Parse(campos[8]));
                                Premios.Add(pa);
                                break;

                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("No se han encontrado los premios :( ");
            }
        }
    }
}
