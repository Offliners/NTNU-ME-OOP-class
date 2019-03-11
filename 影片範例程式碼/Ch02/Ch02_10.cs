/**********************************************
 * nested loop control
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
    class Ch02_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====九九乘法表");
            int outer;
            int inner;
            //for 迴圈測試
            Console.WriteLine("===for迴圈測試==== ");
            for (outer = 1; outer <= 9; outer++)
            {
                for (inner = 1; inner <= 9; inner++)
                {
                    //格式化輸出
                    //{0,2}代表第0個參數的對齊點為2
                    //參閱: http://msdn.microsoft.com/en-us/library/system.string.format.aspx
                    Console.Write("{0,2}*{1,2}={2,2}", inner, outer, inner * outer);
                }
                Console.WriteLine();
            }

            //while 迴圈測試
            Console.WriteLine("===while迴圈測試==== ");
            outer=1;
            while (outer <= 9)
            {
                inner = 1;
                while (inner <= 9)
                {
                    Console.Write("{0,2}*{1,2}={2,2}", inner, outer, inner * outer);
                    inner++;
                }
                Console.WriteLine();
                outer++;
            }

            //do while 迴圈測試
            Console.WriteLine("===do while迴圈測試==== ");
            outer = 1;
            do
            {
                inner = 1;
                do
                {
                    Console.Write("{0,2}*{1,2}={2,2}", inner, outer, inner * outer);
                    inner++;
                } while (inner <= 9);
                Console.WriteLine();
                outer++;
            } while (outer <= 9);
            

            Console.ReadKey();
        }
    }
}
