using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Pyramid
    {
        private static int _amount;
        private double _density;
        private double _side;
        private double _height;

        public Pyramid()
        {
            _density = 0;
            _side = 0;
            _height = 0;
            _amount++;
        }

        public Pyramid(double side, double height, double density)
        {
            Side = side;
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

        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 0)
                    _side = 0;
                else
                    _side = value;
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
            return Math.Pow(_side, 2) * _height / 3;
        }

        public double Weight()
        {
            return _density * Volumn();
        }

        public string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Pyramid");
            str += "\t";
            str += string.Format("{0,8:F2}", _side);
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