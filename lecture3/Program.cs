using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int n = Int32.Parse(Console.ReadLine());
            int[] mas = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                mas[i] = rnd.Next(100);

            Console.WriteLine("введите число");
            int a = Int32.Parse(Console.ReadLine());

            int flag = -1;
            flag = Array.IndexOf(mas, a);

            if (flag != -1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
