using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midexam
{
    class Cube:Shape3D
    {
        new public static int _amount;
        protected double _side;

        public Cube():base()
        {
            _shape = Shapetype.Geometry.CUBE;
            _side = 0;
            _amount++;
        }

        public Cube(double side,Shapetype.Material mtype):base(mtype)
        {
            _shape = Shapetype.Geometry.CUBE;
            Side = side;
            _amount++;
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

        new public static int Amount
        {
            get { return _amount; }
        }

        public override double Volumn()
        {
            return _side * _side * _side;
        }

        public override string ShapeProperty()
        {
            string str = "";
            str += string.Format("{0,8}", "Cube");
            str += "\t";
            str += string.Format("{0,8:F2}", _side);
            str += "\t";
            str += string.Format("{0,8}", "");
            str += "\t";
            str += Property();
            return str;
        }
    }
}
