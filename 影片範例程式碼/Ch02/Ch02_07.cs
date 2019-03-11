/**********************************************
 * flow control: switch case
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
    class Ch02_07
    {
        static void Main(string[] args)
        {
            //讀入成績
            string s;
            int score;
            Console.WriteLine("請輸入成績 (0~100的整數)");
            s = Console.ReadLine();
            score = int.Parse(s);

            // switch case 測試
 
            int grade = score / 10; //取得十位數的數值
            switch (grade)
            {
                case 10:
                case 9:
                    Console.WriteLine("你的成績是A");
                    break;
                case 8:
                    Console.WriteLine("你的成績是B");
                    break;
                case 7:
                    Console.WriteLine("你的成績是C");
                    break;
                case 6:
                    Console.WriteLine("你的成績是D");
                    break;
                default:
                    Console.WriteLine("很遺憾你被當了!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
