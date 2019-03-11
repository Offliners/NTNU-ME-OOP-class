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
    class Ch02_06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("求 1+3+5+....+n 之和(n>7)");
            //讀入成績
            string s;
            int n;
            int sum;
            Console.WriteLine("請輸入整數n ");
            s = Console.ReadLine();
            n = int.Parse(s);

            if (n % 2 == 0)
            {
                Console.WriteLine("{0}不是奇數,程式即將終止!", n);
                Console.Read();
                return; //結束主程式
            }

            // for 測試
            Console.WriteLine("===for測試==== ");
            sum = 0;
            for (int i = 1; i <= n; i += 2)
                sum += i;
            Console.WriteLine("1+3+5+....+{0}={1}",n,sum);
 
            // for 測試 multiple condition
            Console.WriteLine("===for (multiple conditions) 測試 ==== ");
            sum = 0;
            for (int i = 1; i <= n; sum += i, i += 2 );  //sum+=i, i+=2 若改成 i+=2, sum+=i 將會產生錯誤的sum值
            Console.WriteLine("1+3+5+....+{0}={1}", n, sum);

            // while 測試
            sum = 0;
            int iw = 1;
            while (iw <= n)
            {
                sum += iw;
                iw += 2;
            }
            Console.WriteLine("1+3+5+....+{0}={1}", n, sum);

            // do while 測試
            sum = 0;
            iw = 1;
            do
            {
                sum += iw;
                iw += 2;
            } while (iw <= n);
            Console.WriteLine("1+3+5+....+{0}={1}", n, sum);

            Console.ReadKey();
        }
    }
}
