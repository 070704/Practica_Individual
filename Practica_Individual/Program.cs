using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Program
    {
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
                        CargarPremios();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
               
            } while (option != 4);



        }
        public static void JugarTraga()
        {

        }
        public static void MostrarPremios()
        {

        }
        public static void CargarPremios()
        {

        }
    }
}
