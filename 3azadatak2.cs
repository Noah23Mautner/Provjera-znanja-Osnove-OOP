using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3azadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            string s4;
            string s5;
            string s6;
          
            
                Console.WriteLine("Unesi ime");
                s1 = Console.ReadLine();

                Console.WriteLine("Unesi ime");
                s2 = Console.ReadLine();

            Console.WriteLine("Unesi ime");
            s4 = Console.ReadLine();

            Console.WriteLine("Unesi ime");
            s5 = Console.ReadLine();

            Console.WriteLine("Unesi ime");
            s6 = Console.ReadLine();





            string[] s3 = { s1,s2,s4,s5,s6 };
            
            Array.Sort(s3);

            Console.WriteLine("Sortirani stringovi");
            foreach (string s in s3) Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
