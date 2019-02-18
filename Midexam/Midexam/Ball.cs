using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midexam
{
    class Ball:Shape3D,IRollable
    {
        new public static int _amount;
        protected double _radius;
        protected static double _pi = 3.1415926;

        public Ball():base()
        {
            _shape = Shapetype.Geometry.BALL;
            _radius = 0;
            _amount++;
        }

        public Ball(double radius,Shapetype.Material mtype):base(mtype)
        {
            _shape = Shapetype.Geometry.BALL;
            Radius = radius;
            _amount++;
        }

        new public static int Amount
        {
            get { return _amount; }
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
            return 4.0 / 3 * _pi * _radius * _radius * _radius;
        }

        public override string ShapeProperty()
        {
            string str = "";
            str += string.Format("{0,8}", "Ball");
            str += "\t";
            str += string.Format("{0,8:F2}", _radius);
            str += "\t";
            str += string.Format("{0,8}", "");
            str += "\t";
            str += Property();
            return str;
        }

        public double Distance()
        {
            return _radius * _radius;
        }

        public string RollableShapeProperty()
        {
            return ShapeProperty() + string.Format("{0,8:F2}", Distance());
        }
    }
}
