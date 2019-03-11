/***************************************
 * Operator
 * Author: S.D.Wu
 * Date: 2014/2/16
 **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    class Ch02_03
    {
        static void Main(string[] args)
        {
            short x;  //Declare variable x with short type 
            x = 2; //Assign value 2 to variable x
            int y = 5;
            float z= 1.5f; //postfix f is needed
            double w= 5.54;

            //Arithmetic operators
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
            Console.WriteLine("{0}-{1}={2}", x, y, x - y);
            Console.WriteLine("{0}*{1}={2}", x, y, x * y);
            Console.WriteLine("{1}/{0}={2}", x, y, y / x);
            Console.WriteLine("{1}%{0}={2}", x, y, y % x);
            Console.WriteLine("{1}/{0}={2}", z, w, w / z);

            // postfix incremental Operators
            Console.WriteLine("x={0}", x);
            Console.WriteLine("x={0}", x++);
            Console.WriteLine("x={0}", x);

            // prefix incremental Operators
            Console.WriteLine("y={0}", y);
            Console.WriteLine("y={0}", ++y);
            Console.WriteLine("y={0}", y);
            
            //Assignment and lambda expression
            Console.WriteLine("x={0}, x+=2 ==> x={1}", x, x += 2);
            Console.WriteLine("x={0}, x-=3 ==> x={1}", x, x -= 3);

            //Logical Operator
            Console.WriteLine("{0}>{1}  ==> {2}", x, y, x > y); //larger than
            Console.WriteLine("{0}>{1}  ==> {2}", x, y, x < y); //less than
            Console.WriteLine("{0}>{1}  ==> {2}", x, y, x == y); //equal
            Console.WriteLine("{0}>{1}  ==> {2}", x, y, x != y); //unequal
            Console.Read();
        }
    }
}
