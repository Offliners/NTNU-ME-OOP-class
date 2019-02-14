using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz6;
using _104_Classwork5;


namespace _106_Quiz6
{
    class Pyramid:Shape3D
    {
        new private static int _amount;
        private double _side;
        private double _height;
        public Pyramid():base()
        {
            _side = 0;
            _height = 0;
            _amount++;
        }
        public Pyramid(double side, double height,double density):base(density)
        {
            Side = side;
            Height = height;
            _amount++;
        }
        new public static int Amount
        {
            get { return _amount; }
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
         
        public override double Volumn()
        {
            return 1.0/3*_side*_side*_height;
        }
        
        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Pyramid");
            str += '\t';
            str += string.Format("{0,8:F2}", _side);
            str += '\t';
            str += string.Format("{0,8:F2}", _height);
            str += '\t';
            str += Property();
            return str;
        }
    }
}
