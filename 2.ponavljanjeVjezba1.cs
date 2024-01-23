using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ponavljanjeVjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string rez = "";
           if (s1.Length < 5)
            {
                rez = s1;
            }
           else
            {
               rez = s1.Substring(2, s1.Length - 4);

            }
           Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}
