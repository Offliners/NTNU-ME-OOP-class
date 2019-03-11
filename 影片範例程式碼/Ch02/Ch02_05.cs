/**********************************************
 * flow control if , if...else..., ? :
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
    class Ch02_05
    {
        static void Main(string[] args)
        {
            //讀入成績
            string s;
            int score;
            Console.WriteLine("請輸入成績 (0~100的整數)");
            s = Console.ReadLine();
            score = int.Parse(s);

            // if 控制指令
            Console.WriteLine("========if 指令測試==============");
            if (score >= 60)
            {
                Console.WriteLine("你的成績是{0}分", score);
                Console.WriteLine("恭喜你及格了!");
            }


            // if else 控制指令
            Console.WriteLine("========if else 指令測試==============");
            if (score >= 60)
                Console.WriteLine("恭喜你及格了!");
            else
                Console.WriteLine("很遺憾你被當了!");

            //三元運算子
            Console.WriteLine("======== ? : 指令測試==============");
            string message = (score >= 60) ? "恭喜你及格了!" : "很遺憾你被當了!";
            Console.WriteLine(message);

            Console.Read();
        }
    }
}
