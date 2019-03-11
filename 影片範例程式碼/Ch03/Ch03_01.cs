/***************************************
 * introduction to function 
 * Author: S.D.Wu
 * Date: 2014/2/16
 **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    class Ch03_01
    {
        /// <summary>
        /// Entry Point of Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input;    // declare variable input with string type
            double x, y;  // declare four variables,x,y with double type
            double z;
            Console.WriteLine("求平面上一點到原點之距離的平方");
            Console.WriteLine("請輸入點的X座標:");
            input = Console.ReadLine(); //Read string from keyboad
            x = double.Parse(input);    //Convert string into double
            Console.WriteLine("請輸入點的y座標:");
            input = Console.ReadLine(); //Read string from keyboad
            y = double.Parse(input);    //Convert string into double
            
            z = DistanceToOrigin(x, y); //function call
            Console.WriteLine("兩點距離的平方為:{0}", z);
            Console.Read();

        }
        /// <summary>
        /// Purpose:
        /// Calculate the distance between the given point and the origin.
        /// 
        /// Note:
        /// You can't access non-static members from a static method. 
        /// Note that Main() is static
        /// Therefore, this function should be declared as static function
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static double DistanceToOrigin(double xCood, double yCood)
        {
            double s;
            s = xCood * xCood + yCood * yCood;
            return s;
        }
    }
}