using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinboard
{
    class Point
    {
        public double xCoord;
        public double yCoord;
        public double Distance(Point target)
        {
            return Math.Sqrt(Math.Pow(this.xCoord - target.xCoord,2) + Math.Pow(this.yCoord - target.yCoord,2));
        }
    }
}
