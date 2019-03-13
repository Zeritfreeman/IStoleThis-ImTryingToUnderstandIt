using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosNumerosEnteros
{
    class Program
    {
        static void Main()
        {
            int[] U = { 0, 0, 0, 1, 2, 2, 3, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12, 13, 14, 15, 16, 17, 18, 18, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] A = { 0, 0, 3, 6, 6, 6, 9, 12, 12, 12, 15, 18, 18 };
            int[] B = { 0, 0, 2, 2, 4, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };


            int[] complemento = new int[U.Length];

            Console.WriteLine("Los complementos");

            int contador = 0, posicion = 0;
            string True = "True";

            for (int i = 0; i < U.Length; i++)
            {
                True = "True";
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (U[i] == A[j] || U[i] == B[j])
                    {
                        True = "False";
                    }
                    contador++;
                }
                for (int j = contador; j < B.Length - 1; j++)
                {
                    if (U[i] == B[j])
                    {
                        True = "False";
                    }
                }
                if (True == "True")
                {
                    Console.WriteLine(U[i]);
                    complemento[posicion] = U[i];
                    posicion++;
                }
            }


            int[] union = new int[(A.Length + B.Length)];

            for (int i = 0; i < A.Length; i++)
            {
                union[i] = A[i];
            }
            for (int i = A.Length; i < union.Length; i++)
            {
                union[i] = B[i - (A.Length)];
            }

            Console.WriteLine("La union es  ");

            for (int i = 0; i < union.Length; i++)
            {
                Console.WriteLine("" + union[i]);
            }


            int[] intersecto = new int[U.Length];
            int posicion2 = 0;

            Console.WriteLine("Interseccion entre conjuntos");

            for (int b = 0; b < B.Length; b++) // Revise las veces que sean necesarias y no se salga del ancho 
            {
                for (int c = 0; c < A.Length; c++)
                {
                    if (B[b] == A[c])
                    {
                        intersecto[posicion2] = B[b];
                        Console.WriteLine(intersecto[posicion2]);
                        posicion2++;
                    }
                }
            }
        }
    }
}

