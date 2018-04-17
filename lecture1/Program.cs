using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0,sum=0, max,min, mult=1,count=0;
            Console.WriteLine("введите количество чисел");
            n=Int32.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for(int a=0;a<n;a++)
            {
                Console.WriteLine("введите  число");
               mas[a] = int.Parse(Console.ReadLine());
               
            }
            foreach(int x in mas)
            {
                sum = sum+x;
                if (x % 2 == 0)
                    count++;
                else
                    mult =mult *x;
            }
            min = mas[0];
            max = mas[0];
            for (int a = 1; a < n; a++) {
                if (min > mas[a])
                    min = mas[a];
                if (max < mas[a])
                    max = mas[a];
                    }
            Console.WriteLine("сумма={0}  минимум ={1} максимум={2} кол-во четных ={3} произвед нечетных ={4}", sum, min, max, count, mult);
            Console.ReadKey();
                }
    }
}
