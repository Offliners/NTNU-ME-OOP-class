/* CH06_18_4 委託
 * Author: S.D.Wu
 * Date: 2014/4/29
 * ***********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_18_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("咪咪");
            Mouse mouse1 = new Mouse("米奇");
            Mouse mouse2 = new Mouse("米妮");
            cat.shoutDelegate += new Cat.EventDelegate(mouse1.Run); //把方法跟委託綁在一起
            cat.shoutDelegate += new Cat.EventDelegate(mouse2.Help); //把方法跟委託綁在一起
            cat.shoutDelegate += new Cat.EventDelegate(mouse2.Run); //把方法跟委託綁在一起
            mouse1.runDelegate += new Mouse.EventDelegate(cat.Catch);//把方法跟委託綁在一起
            mouse2.runDelegate += new Mouse.EventDelegate(cat.Catch);//把方法跟委託綁在一起

            cat.Shout();
            
            Console.Read();
        }
    }
}
