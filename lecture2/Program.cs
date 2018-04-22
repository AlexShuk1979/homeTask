using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("введите размерность матрицы");
            n = int.Parse(Console.ReadLine());
            int[,] mat1 = new int[n, n];
            int[,] mat2 = new int[n, n];
            Random rnd = new Random();
            for(int i=0; i<n;i++)
                for(int j=0;j<n;j++)
                {
                    mat1[i, j] = rnd.Next(-100, 100);
                    mat2[i, j] = rnd.Next(-100, 100);
                }


        }
    }
}
