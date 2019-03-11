/***************************************
 * Introduction to Class
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
    class Ch03_03
    {
        /// <summary>
        /// Entry Point of Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input;    // declare variable input with string type
            MyPoint p1=new MyPoint(); //Create object p1

            double z;
            Console.WriteLine("求平面上一點到原點之距離的平方");
            Console.WriteLine("請輸入點P1的X座標:");
            input = Console.ReadLine(); //Read string from keyboad
            p1.X = double.Parse(input);    //Convert string into double and assign to the member,x, of p1
            Console.WriteLine("請輸入點P1的y座標:");
            input = Console.ReadLine(); 
            p1.Y = double.Parse(input);    

            z = p1.DistanceToOrigin(); // call Method
            Console.WriteLine("({0},{1})到原點之距離的平方為:{2}", p1.X, p1.Y, z);

            MyPoint p2 = new MyPoint(); //Create object p2

            Console.WriteLine("請輸入點P2的X座標:");
            input = Console.ReadLine(); //Read string from keyboad
            p2.X = double.Parse(input);    //Convert string into double and assign to the member,x, of p2
            Console.WriteLine("請輸入點P2的y座標:");
            input = Console.ReadLine();
            p2.Y = double.Parse(input);
            z = p2.DistanceToOrigin(); // call Method
            z = p1.DistanceTo(p2); // call Method
            Console.WriteLine("({0},{1})與({2},{3})距離的平方為:{4}", p1.X, p1.Y, p2.X, p2.Y, z);

            Console.Read();

        }
        /// <summary>
        /// Declare a new class which is named Point
        /// </summary>
        class MyPoint
        {
            public double X; //field
            public double Y; //field
            /// <summary>
            /// Method
            /// </summary>
            /// <returns></returns>
            public double DistanceToOrigin()
            {
                double s;
                s = this.X * this.X + this.Y * this.Y;//
                // s = X * X + Y * Y;
                return s;
            }
            /// <summary>
            /// Method
            /// </summary>
            /// <param name="p"></param>
            /// <returns></returns>
            public double DistanceTo(MyPoint p)
            {
                return (this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y);
                //return (X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y);
            }
        }

        
    }
}