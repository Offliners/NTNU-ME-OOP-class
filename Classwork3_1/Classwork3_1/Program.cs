using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork3_1
{
    class Program
    {
        static double Tol = Math.Pow(10,-10);
        static void Main(string[] args)
        {
            string[] xy;
            double x1, x2, x3, x4, y1, y2, y3, y4;
            while(true)
            {
                Console.WriteLine("請輸入四頂點座標，並以順時針方向輸入");
                Console.Write("請輸入第一頂點座標(x1,y1)(中間以逗點隔開): ");
                xy = Console.ReadLine().Split(',');
                x1 = double.Parse(xy[0]);
                y1 = double.Parse(xy[1]);
                Console.Write("請輸入第二頂點座標(x2,y2)(中間以逗點隔開): ");
                xy = Console.ReadLine().Split(',');
                x2 = double.Parse(xy[0]);
                y2 = double.Parse(xy[1]);
                Console.Write("請輸入第三頂點座標(x3,y3)(中間以逗點隔開): ");
                xy = Console.ReadLine().Split(',');
                x3 = double.Parse(xy[0]);
                y3 = double.Parse(xy[1]);
                Console.Write("請輸入第四頂點座標(x4,y4)(中間以逗點隔開): ");
                xy = Console.ReadLine().Split(',');
                x4 = double.Parse(xy[0]);
                y4 = double.Parse(xy[1]);
                switch(ShapeType(x1,y1,x2,y2,x3,y3,x4,y4))
                {
                    case 1:
                        Console.WriteLine("正方形");
                        break;
                    case 2:
                        Console.WriteLine("長方形");
                        break;
                    case 3:
                        Console.WriteLine("菱形");
                        break;
                    case 4:
                        Console.WriteLine("平行四邊形");
                        break;
                    case 5:
                        Console.WriteLine("梯形");
                        break;
                    case 6:
                        Console.WriteLine("箏形");
                        break;
                    case 7:
                        Console.WriteLine("不規則四邊形");
                        break;
                    default:
                        Console.WriteLine("未知形狀");
                        break;
                }
                Console.WriteLine("此四邊形面積為: {0}",Area(x1,y1,x2,y2,x3,y3)+Area(x1,y1,x3,y3,x4,y4));
                Console.Write("是否再次執行(y/n)? ");
                if ((Console.ReadLine() != "y") && (Console.ReadLine() != "Y"))
                {
                    Console.WriteLine("程式結束");
                    break;
                }
                else
                    Console.WriteLine("====================================================");
            }
            Console.ReadKey();
        }

        static double Length(double x1,double y1,double x2,double y2)
        {
            double length;
            length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return length;
        }

        static double Angle(double x1,double y1,double x2,double y2,double x3,double y3)
        {
            double cosAngle;
            double A, B, C;
            A = Length(x1, y1, x2, y2);
            B = Length(x1, y1, x3, y3);
            C = Length(x2, y2, x3, y3);
            cosAngle = (Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) / (2 * A * B);
            return Math.Acos(cosAngle) * 180 / Math.PI;
        }

        static bool IsEqualAngle(double x1,double y1,double x2,double y2,double x3,double y3,double x4,double y4)
        {
            double a1 = Angle(x1, y1, x2, y2, x4, y4);
            double a2 = Angle(x2, y2, x3, y3, x1, y1);
            double a3 = Angle(x3, y3, x4, y4, x2, y2);
            double a4 = Angle(x4, y4, x1, y1, x3, y3);
            if ((Math.Abs(a1 - 90) < Tol) && (Math.Abs(a2 - 90) < Tol) && (Math.Abs(a3 - 90) < Tol) && (Math.Abs(a4 - 90) < Tol))
                return true;
            else
                return false;
        }

        static bool IsEqualSide(double x1,double y1,double x2,double y2,double x3,double y3,double x4,double y4)
        {
            double s1 = Length(x1, y1, x2, y2);
            double s2 = Length(x2, y2, x3, y3);
            double s3 = Length(x3, y3, x4, y4);
            double s4 = Length(x4, y4, x1, y1);
            if ((Math.Abs(s1 - s2) < Tol) && (Math.Abs(s2 - s3) < Tol) && (Math.Abs(s3 - s4) < Tol) && (Math.Abs(s4 - s1) < Tol))
                return true;
            else
                return false;
        }

        static int ShapeType(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (IsEqualAngle(x1, y1, x2, y2, x3, y3, x4, y4) == true)
            {
                if (IsEqualSide(x1, y1, x2, y2, x3, y3, x4, y4) == true)
                    return 1;
                else
                    return 2;
            }
            else
            {
                if(IsOppsiteAngle(x1, y1, x2, y2, x3, y3, x4, y4)==true)
                {
                    if (IsEqualSide(x1, y1, x2, y2, x3, y3, x4, y4) == true)
                        return 3;
                    else
                        return 4; 
                }
                else
                {
                    if (IsParallelSide(x1, y1, x2, y2, x3, y3, x4, y4) == true)
                        return 5;
                    else
                    {
                        if (IsNextSide(x1, y1, x2, y2, x3, y3, x4, y4) == true)
                            return 6;
                        else
                            return 7;
                    }
                }
            }
        }

        static double Area(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area;
            area = Math.Abs(0.5 * (x1 * y2 + x2 * y3 + x3 * y1 - y1 * x2 - y2 * x3 - y3 * x1));
            return area;
        }

        static bool IsOppsiteAngle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double a1 = Angle(x1, y1, x2, y2, x4, y4);
            double a2 = Angle(x2, y2, x3, y3, x1, y1);
            double a3 = Angle(x3, y3, x4, y4, x2, y2);
            double a4 = Angle(x4, y4, x1, y1, x3, y3);
            if ((Math.Abs(a1 - a3) < Tol) && (Math.Abs(a2 - a4) < Tol))
                return true;
            else
                return false;
        }

        static bool IsParallelSide(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double a1 = Angle(x1, y1, x2, y2, x4, y4);
            double a2 = Angle(x2, y2, x3, y3, x1, y1);
            double a3 = Angle(x3, y3, x4, y4, x2, y2);
            double a4 = Angle(x4, y4, x1, y1, x3, y3);
            if (((Math.Abs(a1 + a2 - 180) < Tol) && (Math.Abs(a3 + a4 - 180) < Tol))||(((Math.Abs(a1 + a4 - 180) < Tol) && (Math.Abs(a2 + a3 - 180) < Tol))))
                return true;
            else
                return false;
        }

        static bool IsNextSide(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double s1 = Length(x1, y1, x2, y2);
            double s2 = Length(x2, y2, x3, y3);
            double s3 = Length(x3, y3, x4, y4);
            double s4 = Length(x4, y4, x1, y1);
            if (((Math.Abs(s1 - s2) < Tol) && (Math.Abs(s3 - s4) < Tol)) || ((Math.Abs(s1 - s4) < Tol) && (Math.Abs(s2 - s3) < Tol)))
                return true;
            else
                return false;
        }
    }
}
