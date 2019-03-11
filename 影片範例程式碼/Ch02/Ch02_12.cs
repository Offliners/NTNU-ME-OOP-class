/**********************************************
 * loop control : for, while, do while
 * Author: S.D. Wu
 * Date: 2014/2/18
 ***********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    class Ch02_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("求 1+3+5+....+n 之和(n>7)");
            //讀入成績
            string s;
            int n;
            int sum;
       Begin:   //Defined Lable
            Console.WriteLine("請輸入整數n ");
            s = Console.ReadLine();
            n = int.Parse(s);

            if (n % 2 == 0)
            {
                Console.WriteLine("{0}不是奇數,請重新輸入數字!", n);
                goto Begin; //結束主程式
            }

            // for 測試
            Console.WriteLine("===for測試==== ");
            sum = 0;
            for (int i = 1; i <= n; i += 2)
                sum += i;
            Console.WriteLine("1+3+5+....+{0}={1}",n,sum);

            Console.ReadKey();
        }
    }
}
