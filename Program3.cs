using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {//5.7
            const double ITEM_PRICE = 20.4;
            for (int i = 2; i <= 20; i++)
            {
                Console.WriteLine("Цена за {0} едениц товара: {1} рублей", i, ITEM_PRICE * i);
            }
            Console.ReadKey();
        }
    }
}
