using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Program
    {
        static List<Premio> premios;
        static List<Premio> Premios_Actuales;
        static Random ramdom = new Random();
        Admin admin = new Admin(Premios_Actuales,"admin123", premios);
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
               
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
                Console.WriteLine("\t║ 2.- Mostrar Premios           ║");
                Console.WriteLine("\t║                               ║");
                Console.WriteLine("\t║ 3.- Cargar Premios            ║");
                Console.WriteLine("\t║                               ║");
                Console.WriteLine("\t║ 4.- Salir                     ║");
                Console.WriteLine("\t╚═══════════════════════════════╝");
                Console.WriteLine();
                Console.Write("\tPor favor, introduzca su opción: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        JugarTraga();
                        break;
                    case 2:
                        MostrarPremios();
                        break;
                    case 3:
                        Admin.Autentification();
                        Admin.CargarPremios();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
               
            } while (option != 4);



        }
        public static  void JugarTraga()
        {
            int rodillo1 = ramdom.Next(0, 21);
            int rodillo2 = ramdom.Next(0, 21);
            int rodillo3 = ramdom.Next(0, 21);


            if (rodillo1 == rodillo2 && rodillo2 == rodillo3)
            {
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
                            if (rodillo1 == int.Parse(campos[2]) && rodillo2 == int.Parse(campos[2]) && rodillo3 == int.Parse(campos[2])) ;
                            {
                                Console.WriteLine(campos[5]);
                            }

                        }
                    }
                }
            }


        }
        public static void MostrarPremios()
        {

        }
        public static void CargarPremios()
        {

        }
    }
}
