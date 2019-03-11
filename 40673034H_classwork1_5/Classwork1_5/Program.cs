using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            bool flag;
            bool isFlag = true;
            Console.Write("請輸入年分: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("請輸入月分: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("請輸入日期: ");
            day = int.Parse(Console.ReadLine());
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
            switch (month)
            {
                case 1:
                    if (day > 31)
                        isFlag = false;
                    break;
                case 2:
                    if (flag == true)
                    {
                        if (day > 29)
                            isFlag = false;
                    }
                    else
                    {
                        if (day > 28)
                            isFlag = false;
                    }
                    break;
                case 3:
                    if (day > 31)
                        isFlag = false;
                    break;
                case 4:
                    if (day > 30)
                        isFlag = false;
                    break;
                case 5:
                    if (day > 31)
                        isFlag = false;
                    break;
                case 6:
                    if (day > 30)
                        isFlag = false;
                    break;
                case 7:
                    if (day > 31)
                        isFlag = false;
                    break;
                case 8:
                    if (day > 31)
                        isFlag = false;
                    break;
                case 9:
                    if (day > 30)
                        isFlag = false;
                    break;
                case 10:
                    if (day > 31)
                        isFlag = false;
                    break;
                case 11:
                    if (day > 30)
                        isFlag = false;
                    break;
                case 12:
                    if (day > 31)
                        isFlag = false;
                    break;
                default:
                    isFlag = false;
                    break;
            }
            if (isFlag == false)
                Console.WriteLine("Error date!");
            else
                Console.WriteLine("valid date!");
            Console.ReadKey();
        }
    }
}
