/*********************************************
 * namespace
 * Author : S.D.Wu
 * Date: 2014/2/18
 **********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03.MyPoint
{
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
    struct MyPoint_S
    {
        public double X; //field
        public double Y; //field
        /// <summary>
        /// function member 
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
        /// function member
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double DistanceTo(MyPoint_S p)
        {
            return (this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y);
            //return (X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y);
        }
    }
}
