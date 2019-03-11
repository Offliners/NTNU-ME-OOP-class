using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("請輸入一個西元年分: ");
            year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
                Console.Write("閏年");
            else
            {
                if (year % 100 == 0)
                    Console.Write("平年");
                else
                {
                    if(year % 4 == 0)
                        Console.Write("閏年");
                    else
                        Console.Write("平年");
                }
            }
            Console.ReadKey();
        }
    }
}
