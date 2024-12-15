using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n= int.Parse(Console.ReadLine());
            var result = true;
            if (n <= 1)
            {
                result = false;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            if (result)
            {
                Console.WriteLine($"Числото {n} е сложно");
            }
            else
            {
                Console.WriteLine($"Числото {n} е просто");
            }    
            
        }
    }
}
