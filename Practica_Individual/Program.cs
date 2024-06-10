﻿using System;
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
        
        static Random ramdom = new Random();
        
        static void Main(string[] args)
        {
            premios = new List<Premio>();
            Admin admin = new Admin("admin123", premios);
            Cliente cliente = new Cliente(premios); 
            

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
                Console.WriteLine("\t║ 1.- Cliente                   ║");
                Console.WriteLine("\t║                               ║");
                Console.WriteLine("\t║ 2.- Admin                     ║");
                Console.WriteLine("\t║                               ║");
                Console.WriteLine("\t║ 3.- Salir                     ║");
                Console.WriteLine("\t║                               ║");
                Console.WriteLine("\t╚═══════════════════════════════╝");
                Console.WriteLine();
                Console.Write("\tPor favor, introduzca su opción: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        cliente.Menu();
                        break;
                    case 2:
                        admin.Menu();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    
                }
               
            } while (option != 4);



        }

        public static void CargarPremios()
        {

        }
    }
}
