using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            string[] point;
            while(true)
            {
                Console.WriteLine("請依序輸入三角形的三個頂點");
                for(int i = 0;i<=2;i++)
                {
                    Console.Write("(x" + (i + 1).ToString() + ",y" + (i + 1).ToString() + ") = ");
                    point = Console.ReadLine().Split();
                    tri.xcoord[i] = double.Parse(point[0]);
                    tri.ycoord[i] = double.Parse(point[1]);
                }
                if (tri.IsValid() == false)
                    Console.WriteLine("此三點無法形成三角形");
                else
                {
                    Console.WriteLine("Perimeter = {0}", tri.Perimeter());
                    Console.WriteLine("Area = {0}", tri.Area());
                    Console.WriteLine("Radius of Circumcircle = {0}", tri.RadiusOfCircumcircle());
                    if (tri.IsRight() == true)
                        Console.WriteLine("直角三角形");
                    else
                        Console.WriteLine("非直角三角形");
                }
                Console.WriteLine("Again?");
                if (Console.ReadLine() != "y")
                    break;
            }
            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
}
