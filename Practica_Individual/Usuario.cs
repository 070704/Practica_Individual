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
            //Creo un Array donde indico el tamaño que va a tener mi matriz//
            string[,] rodillos = new string[3, 3];
            Random random =new Random();
            //Indico los valores que quiero que tenga mi matriz//
            string[] simbolosRodillos = { "*", "10", "0","?","@","-","o" };
         
            //Hago un bucle for anidado para poder recorrer mi matriz 3 x 3//
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rodillos[i, j] = simbolosRodillos[random.Next(0, simbolosRodillos.Length)]; //Lenght indica la longitud de mi string []//
                    Console.Write($"{rodillos[i, j]}");
                    //Importante poner un Console.Write para que me muestre la matriz en filas y en columnas//
                }
                Console.WriteLine();

            }
           
            bool premioGanado = false;
            //Genero un dato de tipo booleano para cuando toque un premio//
            foreach (var premio in Premios)
            {
                //Hago un for each para recorrer la matriz y creo una condición para que cuando coincidan los elementos de la matriz me muestre que he ganado un premio//
                if (rodillos[1, 0] == premio.Simbolo1 && rodillos[1, 1] == premio.Simbolo2 && rodillos[1, 2] == premio.Simbolo3)
                {
                    //Cada vez que salga un premio me muestra un consejo si es el consejo aleatorio me puede mostrar un tipo de consejo//
                    Console.WriteLine($"¡Ganaste! Premio: {premio.Nombre},{premio.MostrarConsejo()}");
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
            //Pido que me muestre la información de los distintos premios que da la máquina y cuales son las condiciones para obtenerlos//
            foreach (Premio p in Premios)
            {
                Console.WriteLine($"{p.id} | {p.Nombre} | {p.Simbolo1} | {p.Simbolo2} | {p.Simbolo3}");
            }
            Console.WriteLine();
            Console.Write("\t Introduce el Id: ");
            int id = int.Parse( Console.ReadLine() );
            Console.ReadKey();

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
 

