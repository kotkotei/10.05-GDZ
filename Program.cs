using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//2.19 Это его сумма
            Console.Write("Введите четырехзначное число");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (b > 0)
            {
                n = n + b % 1000;
                b = b / 1000;
            }
            Console.WriteLine(n);
            Console.ReadKey();
            // Произведение его цифр 
            int k = 1000;
            int s = 1;
            foreach (char a in k.ToString()) ;
            Console.WriteLine(k);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
