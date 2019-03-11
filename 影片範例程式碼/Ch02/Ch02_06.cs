/**********************************************
 * flow control: Nested if...else..., ? :
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
            //讀入成績
            string s;
            int score;
            Console.WriteLine("請輸入成績 (0~100的整數)");
            s = Console.ReadLine();
            score = int.Parse(s);

            // if else 巢狀控制指令
            Console.WriteLine("========if 指令測試==============");
            if (score >= 60)
            {
                if (score >= 80)
                {
                    if (score>=90)
                        Console.WriteLine("你的成績是A");
                    else
                        Console.WriteLine("你的成績是B");
                }
                else
                {
                    if (score >= 70)
                        Console.WriteLine("你的成績是C");
                    else
                        Console.WriteLine("你的成績是D");
                }
            }
            else
                Console.WriteLine("很遺憾你被當了!");


            //多重選擇的 if else 控制指令
            Console.WriteLine("========if else 指令測試==============");
            if (score >= 90)
                Console.WriteLine("你的成績是A");
            else if (score >= 80)
                Console.WriteLine("你的成績是B");
            else if (score >= 70)
                Console.WriteLine("你的成績是C");
            else if (score >= 60)
                Console.WriteLine("你的成績是D");
            else
                Console.WriteLine("很遺憾你被當了!");

            Console.ReadKey();
        }
    }
}
