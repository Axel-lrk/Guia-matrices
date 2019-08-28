using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guia Clases

            int[,] M1 = new int[3, 3];
            int[,] M2 = new int[3, 3];
            int[,] M3 = new int[3, 3];

            Random rdn = new Random();

            int f, c;

            // Cargar Matriz 1
            for(f = 0; f < 3; f++)
            {
                for(c = 0; c < 3; c++)
                {
                    M1[f, c] = rdn.Next(0,9);
                }
            }

            // Cargar Matriz 2
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    M2[f, c] = rdn.Next(0, 9);
                }
            }

            // Cargar Matriz 3
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    /*
                    if (M1[f, c] == M2[f, c])
                        M3[f, c] = 1;
                    else
                        M3[f, c] = 0;
                    */

                    M3[f, c] = (M1[f, c] == M2[f, c]) ? 1 : 0;
                }
            }

            // Imprimir Matriz 1
            Console.WriteLine("Matriz 1\n");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                    Console.Write($"{M1[f, c]}\t");

                Console.WriteLine();
            }
            Console.WriteLine("\n\n===========================\n\n");

            // Imprimir Matriz 2
            Console.WriteLine("Matriz 2\n");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                    Console.Write($"{M2[f, c]}\t");

                Console.WriteLine();
            }
            Console.WriteLine("\n\n===========================\n\n");

            // Imprimir Matriz 3
            Console.WriteLine("Matriz 3\n");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                    Console.Write($"{M3[f, c]}\t");

                Console.WriteLine();
            }
            Console.WriteLine("\n\n===========================\n\n");

            // Esperar tecla
            Console.ReadKey();
        }
    }
}
