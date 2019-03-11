/***************************************
 * namespace
 * Author: S.D.Wu
 * Date: 2014/2/16
 **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch03.MyPoint;

namespace Ch03
{
    class Ch03_06
    {
        /// <summary>
        /// Entry Point of Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            
            // int, double, struct type ==> value type

            MyPoint_S p1;
            p1.X = 2;
            p1.Y = 3;
            Console.WriteLine("({0},{1})", p1.X, p1.Y);

            // class ==> reference type
            MyPoint_C p2;
            p2 = new MyPoint_C(); //Create a Point object and assign it to p2
            p2.X = 2;
            p2.Y = 3;
            Console.WriteLine("({0},{1})", p2.X, p2.Y);
            Console.Read();
        }
    }
}