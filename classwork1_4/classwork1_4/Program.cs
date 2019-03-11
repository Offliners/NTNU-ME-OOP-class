using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day, weekday;
            int y, c, m;
            Console.Write("請輸入年分: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("請輸入月分: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("請輸入日期: ");
            day = int.Parse(Console.ReadLine());
            y = year % 100;
            c = year / 100;
            if (month <= 2)
                month += 12;
            m = month - 2;
            weekday = (day + Convert.ToInt32(Math.Floor(2.6 * m - 0.2) + 5 * (y % 4) + 3 * y + 5 * (c % 4))) % 7;
            switch(weekday)
            {
                case 1:
                    Console.WriteLine("星期一");
                    break;
                case 2:
                    Console.WriteLine("星期二");
                    break;
                case 3:
                    Console.WriteLine("星期三");
                    break;
                case 4:
                    Console.WriteLine("星期四");
                    break;
                case 5:
                    Console.WriteLine("星期五");
                    break;
                case 6:
                    Console.WriteLine("星期六");
                    break;
                case 7:
                    Console.WriteLine("星期日");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadKey();
        }
    }
}
