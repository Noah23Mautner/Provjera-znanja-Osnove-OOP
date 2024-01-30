using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4
{
    internal class Program
    {
        int a;
        int b;
        int c;
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi duljine stranice trokuta");
            string i = Console.ReadLine();

            string[] strane = i.Split(' ');
            
             a = int.Parse(strane[0]);
             b = int.Parse(strane[1]);
             c = int.Parse(strane[2]);

            if(a * a+b * b == c + c || a * a + c * c ) 
        }
    }
}
