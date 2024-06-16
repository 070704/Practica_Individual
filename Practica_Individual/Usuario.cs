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
        private int[,] rodillos;
        private Random random;
        protected static List <Premio> Premios = new List <Premio> ();
        public Usuario() { }

        public Usuario (List<Premio> premios)
        {
            Premios = premios;

        }
        public abstract void Menu();

        public void JugarTraga()
        {
            rodillos = new int[3,3];
            random = new Random();

            for(int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 3;j++)
                {
                    rodillos[i,j] = random.Next(1,7);
                    Console.WriteLine($"{rodillos[i,j]}");
                }

            }
           


        }

        public void MostrarInfo()
        {
            foreach (var premio in Premios)
            {
                if (rodillos[1, 0] == premio.Simbolo1 && rodillos[1, 1] == premio.Simbolo2 && rodillos[1, 2] == premio.Simbolo3)
                {
                    Console.WriteLine($"¡Ganaste! Premio: {premio.Nombre}");
                    
                    return;
                }
            }
            Console.WriteLine("No has ganado esta vez.");
        }
    }
        
        
    }
 

