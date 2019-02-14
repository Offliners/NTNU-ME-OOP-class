using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] point;
            Triangle tri = new Triangle();
            while(true)
            {
                Console.WriteLine("請輸入三角形的三個頂點座標，並計算其特性");
                Console.Write("(x1,y1)=");
                point = Console.ReadLine().Split(' ');
                tri.x1 = Double.Parse(point[0]);
                tri.y1 = Double.Parse(point[1]);
                Console.Write("(x2,y2)=");
                point = Console.ReadLine().Split(' ');
                tri.x2 = Double.Parse(point[0]);
                tri.y2 = Double.Parse(point[1]);
                Console.Write("(x3,y3)=");
                point = Console.ReadLine().Split(' ');
                tri.x3 = Double.Parse(point[0]);
                tri.y3 = Double.Parse(point[1]);
                if (tri.IsValid() == false)
                    Console.WriteLine("這三點不能組成三角形!");
                else
                {
                    Console.WriteLine("Perimeter = {0}", tri.Perimeter());
                    Console.WriteLine("Area = {0}",tri.Area());
                    Console.WriteLine("Radius of circumcircle = {0}", tri.RadiusOfCircle());
                    if (tri.IsRight()==true)
                        Console.WriteLine("直角三角形");
                    else
                        Console.WriteLine("非直角三角形");
                }
                Console.WriteLine("Again?");
                if ((Console.ReadLine() != "y"))
                    break;
            }
            Console.WriteLine("End of program!");
            Console.ReadKey();
        }
    }

    class Triangle
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        public double x3;
        public double y3;
        public const double Tol = 1e-10;

        public bool IsValid()
        {
            double A = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double B = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double C = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            if ((A + B > C) && (B + C > A) && (C + A > B))
                return true;
            else
                return false;
        }

        public double Perimeter()
        {
            double A = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double B = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double C = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return (A + B + C);
        }

        public double Area()
        {
            double area;
            area = 0.5*Math.Abs(x1 * y2 + x2 * y3 + x3 * y1 - y1 * x2 - y2 * x3 - y3 * x1);
            return area;
        }

        public double RadiusOfCircle()
        {
            double A = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double B = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double C = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double R = A*B*C/(4*Area());
            return R;
        }

        public bool IsRight()
        {
            double A = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double B = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double C = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            if ((A * A + B * B == C * C) || (B * B + C * C == A * A) || (C * C + A * A == B * B))
                return true;
            else
                return false;
        }
    }
}
