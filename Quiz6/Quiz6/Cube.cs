using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Cube
    {
        private static int _amount;
        private double _density;
        private double _side;

        public Cube()
        {
            _density = 0;
            _side = 0;
            _amount++;
        }

        public Cube(double side,double density)
        {
            Side = side;
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

        public double Volumn()
        {
            return Math.Pow(_side, 3);
        }

        public double Weight()
        {
            return _density * Volumn();
        }

        public string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Cube");
            str += "\t";
            str += string.Format("{0,8:F2}", _side);
            str += "\t";
            str += string.Format("{0,8}", "");
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
