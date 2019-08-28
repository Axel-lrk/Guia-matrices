using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio 3

                Crear una matriz de tamaño definido por el usuario,  
                llénela con números aleatorios. 
                Traspasar todos los datos de la matriz a un arreglo. 
                Imprimir ambos elementos.
            */

            Console.WriteLine("Defina dimension de la Matriz\n");

            int filas, cols;
            do
            {
                Console.WriteLine("Ingrese n° de filas.\nDebe ser mayor a 0");
                filas = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (filas <= 0);

            do
            {
                Console.WriteLine("Ingrese n° de columnas.\nDebe ser mayor a 0");
                cols = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (cols <= 0);

            // Crear Matriz
            int[,] M = new int[filas, cols];

            // Cargar Matriz
            Random rdn = new Random();
            for (int f = 0; f < filas; f++)
                for (int c = 0; c < cols; c++)
                    M[f, c] = rdn.Next(0,50);

            // Crear y cargar arreglo
            int longArr = filas * cols;
            int[] A = new int[longArr];

            int count = 0;
            for (int f = 0; f < filas; f++)
                for (int c = 0; c < cols; c++)
                {
                    A[count] = M[f, c];
                    count++;
                }

            // Imprimir Matriz
            Console.WriteLine("===================");
            Console.WriteLine("Imprimir Matriz\n");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < cols; c++)
                    if (M[f, c] < 10)
                        Console.Write($" { M[f, c] }  ");
                    else
                        Console.Write($"{ M[f, c] }  ");

                Console.WriteLine();
            }
            Console.WriteLine("===================");

            // Imprimir Arreglo
            Console.WriteLine("\n===================");
            Console.WriteLine("Imprimir Arreglo\n");

            for (int i = 0; i < longArr; i++)
                Console.Write($"{ A[i] } ");

            Console.WriteLine("\n===================");

            Console.ReadKey();
        }
    }
}
