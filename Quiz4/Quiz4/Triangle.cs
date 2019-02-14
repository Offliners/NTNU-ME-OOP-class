using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class Triangle
    {
        public double[] xcoord = new double[3];
        public double[] ycoord = new double[3];
        public const double Tol = 1e-10;

        public void Length(double[] side)
        {
            for (int i = 0; i <= 2; i++)
                side[i] = Math.Sqrt(Math.Pow(xcoord[i] - xcoord[(i + 1) % 3], 2) + Math.Pow(ycoord[i] - ycoord[(i + 1) % 3], 2));
        }

        public bool IsValid()
        {
            double[] s = new double[3];
            Length(s);
            if ((s[0] + s[1] > s[2]) && (s[0] + s[2] > s[1]) && (s[1] + s[2] > s[0]))
                return true;
            else
                return false;
        }

        public double Perimeter()
        {
            double[] s = new double[3];
            Length(s);
            return (s[0] + s[1] + s[2]);
        }

        public double Area()
        {
            //double area;
            double sum = 0;
            for(int i = 0;i<=2;i++)
            {
                sum += xcoord[i] * ycoord[(i + 1) % 3];
                sum -= ycoord[i] * xcoord[(i + 1) % 3];
            }
            //area = 0.5*Math.Abs(xcoord[0] * ycoord[1] + xcoord[1] * ycoord[2] + xcoord[2] * ycoord[0] - ycoord[0] * xcoord[1] - ycoord[1] * xcoord[2] - ycoord[2] * xcoord[0]);
            return (0.5*Math.Abs(sum));
        }

        public double RadiusOfCircumcircle()
        {
            double[] s = new double[3];
            Length(s);
            double R = s[0] * s[1] * s[2] / (4 * Area());
            return R;
        }

        public bool IsRight()
        {
            double[] s = new double[3];
            Length(s);
            if ((Math.Abs(s[0] * s[0] + s[1] * s[1] - s[2] * s[2]) < Tol) || (Math.Abs(s[1] * s[1] + s[2] * s[2] - s[0] * s[0]) < Tol) || (Math.Abs(s[0] * s[0] + s[2] * s[2] - s[1] * s[1]) < Tol))
                return true;
            else
                return false;
        }
    }
}
