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
        

        public Admin(string password, List<Premio> premios) : base(premios)
        {
            Password = password;
           
        }
        public Admin() { }

        public override  void Menu()
        {
            //Contraseña para que solo pueda acceder el administrador al menú de la clase Admin//
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
                int opcion = 0;
                do
                {

                    //Menú del admin para acceder a el necesitas la contraseña que es admin123//
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t==================================");
                    Console.WriteLine("\t||         TRAGAPERRAS          ||");
                    Console.WriteLine("\t==================================");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("\t╔═══════════════════════════════╗");
                    Console.WriteLine("\t║ 1.- Jugar                     ║");
                    Console.WriteLine("\t║                               ║");
                    Console.WriteLine("\t║ 2.- Mostrar Información       ║");
                    Console.WriteLine("\t║                               ║");
                    Console.WriteLine("\t║ 3.- Cargar Premios            ║");
                    Console.WriteLine("\t║                               ║");
                    Console.WriteLine("\t║ 4.- Salir                     ║");
                    Console.WriteLine("\t╚═══════════════════════════════╝");
                    Console.WriteLine();
                    Console.Write("\tPor favor, introduzca su opción: ");
                    try
                    {
                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                JugarTraga();
                                break;
                            case 2:
                                MostrarInfo();
                                break;
                            case 3:
                                CargarPremios();
                                break;
                            case 4:
                                Console.WriteLine("Saliendo...");
                                break;

                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Seleccione una opción válida");
                    }

                } while (opcion != 4);

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
                                //Campos que tiene el archivo importante que coincidan con el txt//
                                Premio_Simple ps = new Premio_Simple(int.Parse(campos[0]),campos[1], campos[2], campos[3], campos[4], campos[5]);
                                Premios.Add(ps);
                                break;
                            case 2:
                                Premio_Aleatorio pa = new Premio_Aleatorio(int.Parse(campos[0]),campos[1], campos[2], campos[3], campos[4],campos[5], campos[6],int.Parse(campos[7]));
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
        public void GuardarPremios()
        {

        }
    }
}
