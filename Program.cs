using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d, somalinha, somacoluna, somaprinci, somasecunda;

            somalinha = somacoluna = somaprinci = somasecunda = 0;
            
            Random r = new Random();

            Console.WriteLine("Informe a dimensão da matriz:");
            d = int.Parse(Console.ReadLine());

            int[,] mat = new int[d, d];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                somalinha = 0;
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(1, 11);
                    somalinha += mat[i, j];
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"A soma da linha {i + 1} é igual a {somalinha}");
                
            }

            Console.WriteLine();

            for (int j = 0; j < mat.GetLength(0); j++)
            {
                somacoluna = 0;
                for (int i = 0; i < mat.GetLength(1); i++)
                {
                    
                    somacoluna += mat[i, j];
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"A soma da coluna {j + 1} é igual a {somacoluna}");

            }

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                somaprinci += mat[i, i];  
            }

            Console.WriteLine($"A soma da diagonal prncipal é igual a {somaprinci}");

            for (int i = 0, j = mat.GetLength(1); i < mat.GetLength(0); i++, j--)
            {
                somalinha = 0;
                for (int j = 0; ; j++)
                {
                    mat[i, j] = r.Next(1, 11);
                    somalinha += mat[i, j];
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"A soma da linha {i + 1} é igual a {somalinha}");

            }

            Console.Read();

        }
    }
}
