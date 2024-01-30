using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int rezultat;

            Console.WriteLine("Unesite koji clan zelite :");
             n = int.Parse(Console.ReadLine());

             rezultat = FibonaccijevNiz(n);

            Console.WriteLine(" član niza je: " + rezultat);

            Console.ReadKey();
        }

        static int FibonaccijevNiz(int n)
        {
            if (n == 0)
                return 0;

            else if (n == 1)
                return 1;

            else
            {
                int a = 0;
                int b = 1;
                int rezultat=0;

                for (int i = 2; i <= n; i++)
                {
                    rezultat = a + b;
                    a = b;
                    b = rezultat;
                }

                return rezultat;  
            }
        }
        
    }
}