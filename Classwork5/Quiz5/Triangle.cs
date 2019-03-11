using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz4
{
    class Triangle
    {
        public Point[] ptArr = new Point[3];
        public const double Tol= 1e-10;
        private void SideLengths(double[] side)
        {
            for (int i = 0; i <= 2; i++)
                side[i] = ptArr[i].Distance(ptArr[(i + 1) % 3]);
        }
        public void CreatePoints()
        {
            for (int i=0; i<=2; i++)
                ptArr[i] = new Point();
        }
        public double Perimeter()
        {
            double[] s = new double[3];
            SideLengths(s);
            double sum = 0;

            foreach (var element in s)
                sum += element;

            return (sum);
        }
        public double Area()
        {
            double[] s = new double[3];
            SideLengths(s);
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - s[0]) * (p - s[1]) * (p - s[2]));
        }
        public bool isValid()
        {
            double[] s = new double[3];
            SideLengths(s);
            for (int i=0; i<=2; i++)
            {
                if ((Math.Abs(s[i] + s[(i+1)%3] - s[(i+2)%3]) < Tol) )
                    return false;
            }
            return true;
        }
        public bool isRight()
        {
            double[] s = new double[3];
            SideLengths(s);
            for (int i = 0; i <= 2; i++)
            {
                if ((Math.Abs(s[i] *s[i] + s[(i + 1) % 3]* s[(i + 1) % 3] - s[(i + 2) % 3] * s[(i + 2) % 3]) < Tol))
                    return true;
            }
            return false;
        }
        public bool isAcute()
        {
            bool flag = true;
            double[] s = new double[3];
            SideLengths(s);
            for (int i = 0; i <= 2; i++)
            {
                if (s[i] * s[i] - s[(i + 1) % 3] * s[(i + 1) % 3] - s[(i + 2) % 3] * s[(i + 2) % 3] > Tol)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public int ShapeType()
        {
            if (isRight())
                return 1;
            else if (isAcute())
                return 2;
            else
                return 3;
        }
        public double RadiusOfCircumcircle()
        {
            double[] s = new double[3];
            SideLengths(s);
            double CosAlpha = (s[1] * s[1] + s[2] * s[2] - s[0] * s[0]) / (2 * s[1] * s[2]);
            double SinAlpha = Math.Sqrt(1 - CosAlpha * CosAlpha);
            return 0.5 * s[0] / SinAlpha;
        }
    }
}
