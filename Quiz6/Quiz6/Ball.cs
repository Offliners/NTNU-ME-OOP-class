using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Ball
    {
        public static int _amount;
        public static double _pi = 3.1415926;
        public double _density;
        public double _radius;
        
        public Ball()
        {
            _density = 0;
            _radius = 0;
            _amount++;
        }

        public Ball(double radius,double density)
        {
            Radius = radius;
            Density = density;
            _amount++;
        }

        public static int Amount
        {
            get { return _amount; }
        }

        public double Density
        {
            get { return _density; }
            set
            {
                if (value < 0)
                    _density = 0;
                else
                    _density = value;
            }
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    _radius = 0;
                else
                    _radius = value;
            }
        }

        public double Volumn()
        {
            return 4 * _pi * Math.Pow(_radius, 3) / 3;
        }

        public double Weight()
        {
            return _density * Volumn();
        }

        public string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Ball");
            str += "\t";
            str += string.Format("{0,8:F2}", _radius);
            str += "\t";
            str += string.Format("{0,8:F2}","");
            str += "\t";
            str += string.Format("{0,0:F2}", _density);
            str += "\t";
            str += string.Format("{0,8:F2}", Volumn());
            str += "\t";
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
    }
}
