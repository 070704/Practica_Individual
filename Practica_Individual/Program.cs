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
        
        static Random ramdom = new Random();
        
        static void Main(string[] args)
        {
            premios = new List<Premio>();
            CargarPremios();
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
            if (File.Exists("premios.txt"))
            {
               using (StreamReader sr = new StreamReader("premios.txt"))
                {
                    string line = null;
                    string[] campos = null;
                    while((line = sr.ReadLine()) != null) 
                    {
                        campos = line.Split(';');
                        switch (int.Parse(campos[0]))
                        {
                            case 1:
                                Premio_Simple ps = new Premio_Simple(premios.Count, campos[1], campos[2], int.Parse(campos[3]), campos[4], campos[5], campos[6]);
                                premios.Add(ps);
                                break;
                            case 2:
                                Premio_Aleatorio pa = new Premio_Aleatorio(premios.Count, campos[1], campos[2], double.Parse(campos[3]), campos[4], int.Parse(campos[5]),
                                    campos[6], campos[7], campos[8]);
                                premios.Add(pa);
                                break;
                        }
                    }
                }
            }
            
            
        }
    }
}
