using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1_1057
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Primul program grupa 1057");

            //Console.Write("Introduceti numele: ");
            //string nume;
            //nume = Console.ReadLine();

            //Console.Write("Introduceti varsta: ");
            //string varsta;
            //varsta = Console.ReadLine();
            //int varstaint=0;
            //try
            //{
            //     varstaint = Convert.ToInt32(varsta);
            //}
            //catch { }

            //Console.WriteLine("Numele este {0} si are varsta {1}", nume,varstaint);

            int[] vector = {4,6,3,2,10 };

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    Console.Write("{0},", vector[i]);
            //}

            vector = new int[3] {4, 7 ,2};

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    Console.Write("{0},", vector[i]);
            //}

            int[,] matrice = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write("{0},",matrice[i, j]);
                }
                Console.WriteLine();
            }

            int[][] matr = new int[3][];

            for (int i = 0; i < matr.Length; i++)
            {
                matr[i] = new int[vector[i]];
                for (int j = 0; j < matr[i].Length; j++)
                {
                    matr[i][j] = i + j;
                    Console.Write("{0},", matr[i][j]);
                }
                Console.WriteLine();
            }

            int[] vector2 = vector;

            vector2[1] = 5;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0},", vector[i]);
            }

            Console.Read();
        }
    }
}
