using System;
using System.Net.Security;

namespace PR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во товаров = ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] f = new int[n];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                f[i] = rnd.Next(100, 2001);
                Console.Write(f[i] + " ");
                if (f[i] > 1000) c += f[i];
            }
            Console.Write("\nОбщая стоимость товаров дороже 1000 рублей = {0}",c);
        }
    }
}
