using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisi recenicu");
            string s1 = Console.ReadLine();

            s1 = s1.Replace(' ' ,'_');
       
            Console.WriteLine(s1);

            Console.ReadKey();  
        }
    }
}
