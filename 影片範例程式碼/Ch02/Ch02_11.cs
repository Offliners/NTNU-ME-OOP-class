/**********************************************
 * continue
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
    class Ch02_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====計算1~n 中,不是3的倍數的數字的總和==============");
            Console.WriteLine("請輸入n");
            
            //變數宣告
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            
            //利用 for +if 來實現
            Console.WriteLine("====for + if============");
            for (int i = 1; i <= n; i++)
            {
                //若是3的倍數就做累加的動作
                if (i % 3 != 0)
                    sum += i;
            }
            Console.WriteLine("總和={0}",sum);

            //利用 for + continue 來實現
            Console.WriteLine("====for + continue============");
            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                //若是3的倍數就回到 loop 的開頭
                if (i % 3 == 0)
                    continue;

                sum += i;
            }
            Console.WriteLine("總和={0}", sum);
            Console.ReadKey();
        }
    }
}
