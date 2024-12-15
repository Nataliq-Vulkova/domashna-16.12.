using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n= int.Parse(Console.ReadLine());
            string dvoichno = Convert.ToString(n,2);
            Console.WriteLine($"Двоичното представяне е: {dvoichno}");
        }
    }
}
