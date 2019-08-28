using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();

            int[,] M = new int[5, 7];
            string[] Dias = new string[] {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            int f, c;

            int dia = 0, tMyMes = 0, diaS;

            double suma = 0;
            

            for(f = 0; f < 5; f++)
            {
                Console.Write($"S{f + 1}|\t");
                for (c = 0; c < 7; c++)
                {

                    M[f, c] = rdn.Next(7, 38);
                    suma += M[f, c];

                    // Imprimer Matriz
                    Console.Write($"{M[f, c]}°\t");

                    if (f == 4 && c == 2)
                        c = 7;
                }

                Console.WriteLine();
            }
            Console.WriteLine();


            // Temperatura mas alta y baja por semana
            int mayorS = 0, menorS = 39;
            string diaMayorS = "", diaMenorS = "";
            for (f = 0; f < 5; f++)
            {
                mayorS = 0; menorS = 39;
                for (c = 0; c < 7; c++)
                {
                    if (M[f, c] > mayorS)
                    {
                        mayorS = M[f, c];
                        diaMayorS = Dias[c];
                    }

                    if (M[f, c] < menorS)
                    {
                        menorS = M[f, c];
                        diaMenorS = Dias[c];
                    }

                    if (f == 4 && c == 2)
                        break;
                }

                Console.WriteLine($"Semana {f + 1}.");
                Console.WriteLine($"T Mayor: {mayorS}° {diaMayorS}");
                Console.WriteLine($"T Menor: {menorS}° {diaMenorS}");
                Console.WriteLine();
            }


            // Promedio todas las temperaturas
            double promedio = Math.Round(suma / 31, 1);
            Console.WriteLine($"El promedio es: {promedio}°");
            Console.WriteLine();


            // Mayor del Mes
            int numMayorMes = 0, tMayorMes = 0;
            string diaMayorMes = "";

            for (f = 0; f < 5; f++)
            {
                for (c = 0; c < 7; c++)
                {
                    if(M[f, c] > tMayorMes)
                    {
                        tMayorMes = M[f, c];
                        numMayorMes = f * 7 + c + 1;
                        diaMayorMes = Dias[c];
                    }

                    if (f == 4 && c == 2)
                        break;
                }
            }

            Console.WriteLine($"Temperatura máxima del mes: {tMayorMes}° día {diaMayorMes} {numMayorMes}");





            Console.ReadKey();


        }
    }
}
