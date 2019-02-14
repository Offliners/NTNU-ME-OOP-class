using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Cylinder
    {
        private static int _amount;
        private static double _pi = 3.1415926;
        private double _density;
        private double _radius;
        private double _height;

        public Cylinder()
        {
            _density = 0;
            _radius = 0;
            _height = 0;
            _amount++;
        }

        public Cylinder(double radius, double height, double density)
        {
            Radius = radius;
            Height = height;
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

        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    _height = 0;
                else
                    _height = value;
            }
        }

        public double Volumn()
        {
            return _pi * Math.Pow(_radius, 2) * _height;
        }

        public double Weight()
        {
            return _density * Volumn();
        }

        public string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Cylinder");
            str += "\t";
            str += string.Format("{0,8:F2}", _radius);
            str += "\t";
            str += string.Format("{0,8}", _height);
            str += "\t";
            str += string.Format("{0,0:F2}", _density);
            str += "\t";
            str += string.Format("{0,8}:F2", Volumn());
            str += "\t";
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
    }
}
