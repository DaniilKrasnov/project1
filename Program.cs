using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Console.Write("Количество предметов:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] mass = new int[n];
            //Random random = new Random();
            //for(int i=0;i<n;i++)
            //{
            //    mass[i] = random.Next(1,20);
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //int summ = 0;
            //for(int i=0;i<n;i++)
            //{
            //    summ = summ + mass[i];
            //}
            //Console.WriteLine($"summ={summ}");

            //Задача 2
            //int[] mass = new int[22];
            //Random random = new Random();
            //for(int i=0;i<22;i++)
            //{
            //    mass[i] = random.Next(160,180);
            //    Console.WriteLine($"mass[{i}]-{mass[i]}");
            //}
            //int summ = 0;
            //for (int i = 0; i < 22; i++)
            //{
            //    summ = summ + mass[i];
            //}
            //Console.WriteLine($"Средний рост студентов-{summ / 22}");

            //Задача 3
            //int[] mass = new int[15];
            //Random random = new Random();
            //for(int i=0;i<15;i++)
            //{
            //    mass[i] = random.Next(-10,10);
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //int plus = 0;
            //int minus = 0;
            //int nul = 0;
            //for(int i=0;i<15;i++)
            //{
            //    if (mass[i]>0)
            //    {
            //        plus++;
            //    }
            //    if(mass[i]<0)
            //    {
            //        minus++;
            //    }
            //    if (mass[i]==0)
            //    {
            //        nul++;
            //    }
            //}
            //Console.WriteLine($"Положительные={plus} Отрицательные={minus} Нулевые={nul}"); 

            //Задача 4
            //int[] mass = new int[10] { 1, 4, 5, 8, 12, 46, 23, 21, 16, 32 };
            //int c = 0;
            //for(int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i]%2==0)
            //    {
            //        c++;
            //    }
            //}
            //Console.WriteLine($"Четные элементы:{c}");
            Console.ReadKey();
        }
    }
}
