using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Individual
{
    internal abstract  class Usuario 
    {
      
        protected List<Premio> Premios;
        public Usuario() { }

        public Usuario (List<Premio> premios)
        {
            Premios = new List<Premio>();
            Premios = premios;

        }
        public abstract void Menu();

        public void JugarTraga()
        {
            string[,] rodillos = new string[3, 3];
            Random random =new Random();
            string[] simbolosRodillos = { "*", "10", "0" };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rodillos[i, j] = simbolosRodillos[random.Next(0, 3)];
                    Console.WriteLine($"{rodillos[i, j]}");
                    Console.ReadKey();
                }

            }
            bool premioGanado = false;

            foreach (var premio in Premios)
            {
                if (rodillos[1, 0] == premio.Simbolo1 && rodillos[1, 1] == premio.Simbolo2 && rodillos[1, 2] == premio.Simbolo3)
                {
                    Console.WriteLine($"¡Ganaste! Premio: {premio.Nombre}");
                    premioGanado = true;
                    Console.ReadKey();
                }
            }

            if (!premioGanado)
            {
                Console.WriteLine("No has ganado esta vez.");
                Console.ReadKey();
            }



        }

        public void MostrarInfo()
        {
            foreach (Premio p in Premios)
            {
                Console.WriteLine($"{p.id} | {p.Nombre} | {p.Simbolo1} | {p.Simbolo2} | {p.Simbolo3}");
            }
            Console.WriteLine();
            Console.Write("\t Introduce el Id: ");
            int id = int.Parse( Console.ReadLine() );

            foreach(Premio premio in Premios)
            {
                if(premio.id == id)
                {
                    premio.MostrarInfo();
                }
            }
        }
    }
        
        
    }
 

