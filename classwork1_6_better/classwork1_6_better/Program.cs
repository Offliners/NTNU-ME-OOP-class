using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1_6_better
{
    class Program
    {
        static void Main(string[] args)
        {
            int year1, month1, day1, year2, month2, day2;
            bool flag1, flag2;
            int sum = 0;
            int count = 0;
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
                flag1 = IsLeap(year1);
                flag2 = IsLeap(year2);
                for(int i=year1;i<=year2;i++)
                {
                    if (IsLeap(i) == true)
                        count++;
                }
                sum = (year2 - year1) * 365 + count + PassDay(month2, year2, day2) - PassDay(month1, year1, day1) - 1;
                Console.WriteLine("相差{0}天", sum);
                Console.ReadKey();
            }
        }


        static bool IsLeap(int year)
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

        static int PassDay(int month,int year,int day)
        {
            int pass_day = 0;
            switch (month)
            {
                case 1:
                    pass_day = day;
                    break;
                case 2:
                    pass_day = day + 31;
                    break;
                case 3:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29;
                    else
                        pass_day = day + 31 + 28;
                    break;
                case 4:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31;
                    else
                        pass_day = day + 31 + 28 + 31;
                    break;
                case 5:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30;
                    else
                        pass_day = day + 31 + 28 + 31 + 30;
                    break;
                case 6:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30 + 31;
                    else
                        pass_day = day + 31 + 28 + 31 + 30 + 31;
                    break;
                case 7:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30 + 31 + 30;
                    else
                        pass_day = day + 31 + 28 + 31 + 30 + 31 + 30;
                    break;
                case 8:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30 + 31 + 30 + 31;
                    else
                        pass_day = day + 31 + 28 + 31 + 30 + 31 + 30 + 31;
                    break;
                case 9:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                    else
                        pass_day = day + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                    break;
                case 10:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                    else
                        pass_day = day + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                    break;
                case 11:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                    else
                        pass_day = day + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                    break;
                case 12:
                    if (IsLeap(year) == true)
                        pass_day = day + 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                    else
                        pass_day = day + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                    break;
            }
            return pass_day;
        }
    }
}