using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio 1

                Crear una matriz con números aleatorios, 
                el tamaño de la matriz debe darlo el usuario. 
                Imprima con forma de matriz.
            */


            int y, x; // Alto x Ancho / Plano cartesiano

            Console.WriteLine("Ingrese dimensión de la matriz (Alto x ancho)");
            do
            {
                Console.WriteLine("\nIngrese el alto");
                Console.WriteLine("Debe ser mayor a 0");

                y = int.Parse(Console.ReadLine());

                Console.WriteLine();
            } while (y <= 0);

            do
            {
                Console.WriteLine("\nIngrese el ancho");
                Console.WriteLine("Debe ser mayor a 0");

                x = int.Parse(Console.ReadLine());

                Console.WriteLine();
            } while (x <= 0);

            //Crear Matriz
            int[,] M = new int[y, x];

            // Cargar Matriz
            Random rdn = new Random();
            for(int f = 0; f < y; f++)
                for (int c = 0; c < x; c++)
                    M[f, c] = rdn.Next(0,20);

            // Imprimir Matriz
            Console.WriteLine("================");
            Console.WriteLine("Imprimir Matriz\n");
            for (int f = 0; f < y; f++)
            {
                for (int c = 0; c < x; c++)
                    Console.Write($"{M[f, c]}\t");

                Console.WriteLine();
            }
            Console.WriteLine("\n================");

            Console.ReadKey();
        }
    }
}
