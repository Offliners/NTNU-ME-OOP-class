using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int year1, month1, day1, year2, month2, day2;
            bool flag1, flag2;
            int pass_day1 = 0, pass_day2 = 0;
            Console.Write("請輸入起始年分: ");
            year1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入起始月分: ");
            month1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入起始日期: ");
            day1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入結束年分: ");
            year2 = int.Parse(Console.ReadLine());
            Console.Write("請輸入結束月分: ");
            month2 = int.Parse(Console.ReadLine());
            Console.Write("請輸入結束日期: ");
            day2 = int.Parse(Console.ReadLine());
            if ((year1 > year2) || ((year1 == year2) && (month1 > month2)) || ((year1 == year2) && (month1 == month2) && (day1 > day2)))
                Console.WriteLine("Error input");
            else
            {
                if (year1 % 400 == 0)
                    flag1 = true;
                else
                {
                    if (year1 % 100 == 0)
                        flag1 = false;
                    else
                    {
                        if (year1 % 4 == 0)
                            flag1 = true;
                        else
                            flag1 = false;
                    }
                }
                if (year2 % 400 == 0)
                    flag2 = true;
                else
                {
                    if (year2 % 100 == 0)
                        flag2 = false;
                    else
                    {
                        if (year2 % 4 == 0)
                            flag2 = true;
                        else
                            flag2 = false;
                    }
                }
                switch (month1)
                {
                    case 1:
                        pass_day1 = day1;
                        break;
                    case 2:
                        pass_day1 = day1 + 31;
                        break;
                    case 3:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29;
                        else
                            pass_day1 = day1 + 31 + 28;
                        break;
                    case 4:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31;
                        else
                            pass_day1 = day1 + 31 + 28 + 31;
                        break;
                    case 5:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30;
                        break;
                    case 6:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30 + 31;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30 + 31;
                        break;
                    case 7:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30 + 31 + 30;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30 + 31 + 30;
                        break;
                    case 8:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30 + 31 + 30 + 31;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30 + 31 + 30 + 31;
                        break;
                    case 9:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                        break;
                    case 10:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                        break;
                    case 11:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                        break;
                    case 12:
                        if (flag1 == true)
                            pass_day1 = day1 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                        else
                            pass_day1 = day1 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                        break;
                }
                switch (month2)
                {
                    case 1:
                        pass_day2 = day2;
                        break;
                    case 2:
                        pass_day2 = day2 + 31;
                        break;
                    case 3:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29;
                        else
                            pass_day2 = day2 + 31 + 28;
                        break;
                    case 4:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31;
                        else
                            pass_day2 = day2 + 31 + 28 + 31;
                        break;
                    case 5:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30;
                        break;
                    case 6:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30 + 31;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30 + 31;
                        break;
                    case 7:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30 + 31 + 30;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30 + 31 + 30;
                        break;
                    case 8:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30 + 31 + 30 + 31;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30 + 31 + 30 + 31;
                        break;
                    case 9:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                        break;
                    case 10:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                        break;
                    case 11:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                        break;
                    case 12:
                        if (flag2 == true)
                            pass_day2 = day2 + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                        else
                            pass_day2 = day2 + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                        break;
                }
                Console.WriteLine("之間相差{0}天", ((year2 - year1) * 365 - pass_day1 + pass_day2));
            }
            Console.ReadKey();
        }
    }
}
