using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal class Cliente : Usuario
    {
        public Cliente(List<Premio> premios) : base(premios)
        {

        }

        public Cliente() { }

        public override void Menu()
        {
           
            
            int opcion = 0;
            do
            {

                //Menu del cliente//
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
                Console.WriteLine("\t║ 3.- Salir                     ║");
                Console.WriteLine("\t║                               ║");
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
                           

                            
                            break;

                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Por favor, introduce una opción válida");
                }

               

            } while (opcion != 4);


        }

    }
}


