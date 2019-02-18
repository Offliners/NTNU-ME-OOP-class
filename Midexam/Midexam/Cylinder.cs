using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midexam
{
    class Cylinder:Shape3D,IRollable
    {
        new public static int _amount;
        protected double _radius;
        protected double _height;
        protected static double _pi = 3.1415926;

        public Cylinder() : base()
        {
            _shape = Shapetype.Geometry.CYLINDER;
            _radius = 0;
            _height = 0;
            _amount++;
        }

        public Cylinder(double radius,double height,Shapetype.Material mtype) : base(mtype)
        {
            _shape = Shapetype.Geometry.CYLINDER;
            Radius = radius;
            Height = height;
            _amount++;
        }

        new public static int Amount
        {
            get { return _amount; }
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

        public override double Volumn()
        {
            return _pi * _radius * _radius * _height;
        }

        public override string ShapeProperty()
        {
            string str = "";
            str += string.Format("{0,8}", "Cylinder");
            str += "\t";
            str += string.Format("{0,8:F2}", _radius);
            str += "\t";
            str += string.Format("{0,8:F2}", _height);
            str += "\t";
            str += Property();
            return str;
        }

        public double Distance()
        {
            return _radius * _height;
        }

        public string RollableShapeProperty()
        {
            return ShapeProperty() + string.Format("{0,8:F2}", Distance());
        }
    }
}
