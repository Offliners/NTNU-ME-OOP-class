using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_5_better
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            Console.Write("請輸入年分: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("請輸入月分: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("請輸入日期: ");
            day = int.Parse(Console.ReadLine());
            if (IsMonth(year,month,day) == false)
                Console.WriteLine("Error date!");
            else
                Console.WriteLine("valid date!");
            Console.ReadKey();
        }

        static bool IsFlag(int year)
        {
            bool flag;
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
            if (flag == true)
                return true;
            else
                return false;
        }

        static bool IsMonth(int year,int month,int day)
        {
            bool isFlag = true;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 31)
                        isFlag = false;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30)
                        isFlag = false;
                    break;
                case 2:
                    if (IsFlag(year) == true)
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
            }
            if (isFlag == true)
                return true;
            else
                return false;
        }
    }
}
