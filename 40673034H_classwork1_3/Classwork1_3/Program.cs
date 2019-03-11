using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month;
            bool flag;
            Console.Write("請輸入年分: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("請輸入月分: ");
            month = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
                flag = true;
            else
            {
                if (year % 100 == 0)
                    flag = false;
                else
                {
                    if (year % 4 == 0)
                        flag = true;
                    else
                        flag = false;
                }
            }
            switch(month)
            {
                case 1:
                    Console.WriteLine("{0}年{1}月有31天", year,month);
                    break;
                case 2:
                    if(flag == true)
                        Console.WriteLine("{0}年{1}月有29天", year,month);
                    else
                        Console.WriteLine("{0}年{1}月有28天", year, month);
                    break;
                case 3:
                    Console.WriteLine("{0}年{1}月有31天", year, month);
                    break;
                case 4:
                    Console.WriteLine("{0}年{1}月有30天", year, month);
                    break;
                case 5:
                    Console.WriteLine("{0}年{1}月有31天", year, month);
                    break;
                case 6:
                    Console.WriteLine("{0}年{1}月有30天", year, month);
                    break;
                case 7:
                    Console.WriteLine("{0}年{1}月有31天", year, month);
                    break;
                case 8:
                    Console.WriteLine("{0}年{1}月有31天", year, month);
                    break;
                case 9:
                    Console.WriteLine("{0}年{1}月有30天", year, month);
                    break;
                case 10:
                    Console.WriteLine("{0}年{1}月有31天", year, month);
                    break;
                case 11:
                    Console.WriteLine("{0}年{1}月有30天", year, month);
                    break;
                case 12:
                    Console.WriteLine("{0}年{1}月有31天", year, month);
                    break;
            }
            Console.ReadKey();
        }
    }
}
