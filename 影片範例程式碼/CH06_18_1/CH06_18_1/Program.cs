/* CH06_18_1 委託: 在類別A 呼叫類別 B的方法
 * Author: S.D.Wu
 * Date: 2014/4/29
 * ***********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("咪咪");
            Mouse mouse = new Mouse("米奇");
            
            //如果shoutDelegate沒有綁定任何方法，其值為 null
            cat.shoutDelegate = new Cat.EventDelegate(mouse.Run); //把方法跟委託綁在一起
            //cat.shoutDelegate = new Cat.EventDelegate(mouse.Help); //把方法跟委託綁在一起
            Console.WriteLine("{0}", cat.Shout());
            Console.Read();
        }
    }
}
