/**********************************************
 * infinite loop control : for, while, do while
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
    class Ch02_09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("求輸入之正整數的總和,當輸入負整數時結束計算");
            //變數宣告
            int input;
            int sum;
            
            //for 無窮迴圈測試
            Console.WriteLine("===for無窮迴圈測試==== ");
            sum = 0;
            for(;;)
            {
                input=int.Parse(Console.ReadLine());
                if (input < 0)
                    break;
                sum+=input;
            }
            Console.WriteLine("總和={0}",sum);

            //while 無窮迴圈測試
            Console.WriteLine("===while無窮迴圈測試==== ");
            sum = 0;
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input < 0)
                    break;
                sum += input;
            }
            Console.WriteLine("總和={0}", sum);

            // do while 無窮迴圈測試
            Console.WriteLine("===do while 無窮迴圈測試==== ");
            sum = 0;
            do
            {
                input = int.Parse(Console.ReadLine());
                if (input < 0)
                    break;
                sum += input;
            } while (true) ;
            Console.WriteLine("總和={0}", sum);

            Console.ReadKey();
        }
    }
}
