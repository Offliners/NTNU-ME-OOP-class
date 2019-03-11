/* CH06_19_1 事件
 * Author: S.D.Wu
 * Date: 2014/4/29
 * ***********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("咪咪");
            Mouse mouse1 = new Mouse("米奇");
            //Mouse mouse2 = new Mouse("米妮");
            cat.shout += new Cat.CatShoutEventHandler(mouse1.Run); //把方法跟事件綁在一起
            //cat.shout += new Cat.CatShoutEventHandler(mouse2.Help); //把方法跟事件綁在一起
            //cat.shout += new Cat.CatShoutEventHandler(mouse2.Run); //把方法跟事件綁在一起
            mouse1.run += new Mouse.MouseRunEventHandler(cat.Catch);//把方法跟事件綁在一起

            cat.Shout();
            
            Console.Read();
        }
    }
}
