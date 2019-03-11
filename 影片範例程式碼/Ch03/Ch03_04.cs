/***************************************
 * Value Type v.s. Reference Type
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
    class Ch03_04
    {
        /// <summary>
        /// Entry Point of Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            
            // int, double, struct type ==> value type
            int X1;
            X1 = 2;
            int X2;
            X2 = X1;
            X2 = -1;

            Console.WriteLine("{0} \n{1}", X1, X2);

            // class ==> reference type
            MyPoint_C p1;
            p1 = new MyPoint_C(); //Create a MyPoint_C object and assign it to p2
            p1.X = 2;
            p1.Y = 3;
            MyPoint_C p2;
            p2 = p1;
            p2.X = -1;
            p2.Y = -2;
            Console.WriteLine("{0},{1}",p1.X, p1.Y);
            Console.WriteLine("{0},{1}",p2.X, p2.Y);
            Console.Read();

        }

    }
    /// <summary>
    /// Declared a new class and named it as MyPoint_C
    /// </summary>
    class MyPoint_C
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
        public double DistanceTo(MyPoint_C p)
        {
            return (this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y);
            //return (X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y);
        }
    }
}