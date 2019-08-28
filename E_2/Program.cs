using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio 2

                Crear una matriz que contenga 3 columnas, 
                la cantidad de filas las da el usuario, 
                llenar las dos primeras columnas con números 
                y en la 3 columna guardar el resultado de sumar el número de la primera y segunda columna. 
                Imprima con forma de matriz. Tratar de mostrar con un solo ciclo.
            */

            Random rdn = new Random();
            int filas;
            do
            {
                Console.WriteLine("Ingrese cantidad de filas\nDebe ser un número mayor a 0");
                filas = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (filas <= 0);

            // Crear Matriz
            int[,] M = new int[filas, 3];

            // Cargar Matriz
            for (int f = 0; f < filas; f++)
                for (int c = 0; c < 3; c++)
                    M[f, c] = (c < 2) ? rdn.Next(0, 50) : ( M[f, 0] + M[f, 1] );

            // Imprimir Matriz
            Console.WriteLine("====================");
            Console.WriteLine("Imprimir Matriz");
            Console.WriteLine();

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < 3; c++)
                    Console.Write($"{ M[f, c] }\t");

                Console.WriteLine();
            }
            Console.WriteLine("====================");

            Console.ReadKey();

        }
    }
}
