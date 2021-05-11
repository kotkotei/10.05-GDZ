using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {///1.46
            Console.Write("Ввведи сюда ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведи сюда ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведи сюда ");
            int c = Convert.ToInt32(Console.ReadLine());
            int s = b * c;
            int v = s * a;
            Console.Write("Площадь: " + s + " Объем : " + v);
            Console.ReadKey();
        }
    }
}
