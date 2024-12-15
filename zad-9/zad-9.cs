using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n=int.Parse(Console.ReadLine());
            int i = 0;
            while (n > 0)
            {
                n = n / 10;
                i++;
            }
            Console.WriteLine("i= " + i);

        }
    }
}
