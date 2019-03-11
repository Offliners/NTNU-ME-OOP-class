/***************************************
 * struct v.s. class
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
    class Ch03_05
    {
        /// <summary>
        /// Entry Point of Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            
            // int, double, struct type ==> value type

            MyPoint_S sp1;
            sp1.X = 2;
            sp1.Y = 3;
            MyPoint_S sp2;
            sp2 = sp1;
            sp2.X = -1;
            sp2.Y = -2;
            Console.WriteLine("{0},  {1}", sp1.X, sp1.Y);
            Console.WriteLine("{0},  {1}", sp2.X, sp2.Y);
            // class ==> reference type
            MyPoint_C cp1;
            cp1 = new MyPoint_C(); //Create a MyPoint_C object and assign it to p2
            cp1.X = 2;
            cp1.Y = 3;
            MyPoint_C cp2;
            cp2 = cp1;
            cp2.X = -1;
            cp2.Y = -2;
            Console.WriteLine("{0},  {1}", cp1.X, cp1.Y);
            Console.WriteLine("{0},  {1}", cp2.X, cp2.Y);
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
    /// <summary>
    ///  Declared a new struct and named it as MyPoint_S
    /// </summary>
    struct MyPoint_S
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
            return s;
        }
        /// <summary>
        /// Method
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double DistanceTo(MyPoint_S p)
        {
            return (this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y);
        }
          
    }
}