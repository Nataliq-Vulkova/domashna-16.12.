using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число, на което да разделим: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Число, на което да не се дели: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Брой числа, които ще въвеждаме: ");
            int n= int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                if ((num % a==0) && (num % b!=0))
                {
                    Console.WriteLine("num" + num);
                }  
            }


        }
    }
}
