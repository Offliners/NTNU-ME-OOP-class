using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_Classwork5
{
    class Shape3D
    {
        protected double _density;
        protected static int _amount;

        public Shape3D()
        {
            _density = 0;
            _amount++;
        }

        public Shape3D(double density)
        {
            Density = density;
            _amount++;
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

        public static int Amount
        {
            get { return _amount; }
        }
        public virtual double Volumn()
        {
            return 0;
        }

        public double Weight()
        {
            return _density*Volumn();
        }

        public virtual string ShapeProperty()
        {
            return "";
        }

        public string Property()
        { 
            string str = "";
            str += string.Format("{0,8:F2}", _density);
            str += '\t';
            str += string.Format("{0,8:F2}", Volumn());
            str += '\t';
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }

    }
}
