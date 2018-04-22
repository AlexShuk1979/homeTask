using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2
{
    class Program
    {
        public static void output(int[,] value, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0:d3}", value[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("введите размерность матрицы");
            n = int.Parse(Console.ReadLine());
            int[,] mat1 = new int[n, n];
            int[,] mat2 = new int[n, n];
            int[,] mat3= new int[n, n];
            Random rnd = new Random();
            for(int i=0; i<n;i++)
                for(int j=0;j<n;j++)
                {
                    mat1[i, j] = rnd.Next(0, 100);
                    mat2[i, j] = rnd.Next(0, 100);
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                }
            Console.WriteLine("первая матрица");
            output(mat1, n);
            Console.WriteLine("вторая матрица");
            output(mat2, n);
            Console.WriteLine("сложение матриц");
            output(mat3, n);
          
            Console.ReadKey();

        }
    }
}
