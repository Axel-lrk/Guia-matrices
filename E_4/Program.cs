using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] M = new int[10, 10];
            int f, c;

            // Cargar primera fila
            for (c = 0; c < 10; c++)
                M[0, c] = c;

            // Cargar Matriz
            for (f = 1; f < 10; f++)
            {
                M[f, 0] = f;
                for (c = 1; c < 10; c++)
                    M[f, c] = M[0, c] * f;
            }

            // Imprimir Matriz
            Console.WriteLine("Matriz\n");
            for (f = 0; f < 10; f++)
            {
                for (c = 0; c < 10; c++)
                    Console.Write($"{ M[f,c] }\t");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
