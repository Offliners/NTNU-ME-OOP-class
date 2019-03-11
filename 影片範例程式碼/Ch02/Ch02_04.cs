/***************************************
 * Read string from keyboard & Convert string string into Numerics 
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
    class Ch02_04
    {
        static void Main(string[] args)
        {
            string input;    // declare variable input with string type
            int x, y;  // declare two variables,x and y, with integer type
            Console.WriteLine("請輸入第一個整數:");
            input = Console.ReadLine(); //Read string from keyboad
            x = int.Parse(input);    //Convert string into integer
            Console.WriteLine("請輸入第二個整數:");
            input = Console.ReadLine();
            y = int.Parse(input);
            Console.WriteLine("Sum of two input integer ={0}", x + y);

            double w, z;  // declare two variables,x and y, with integer type
            Console.WriteLine("請輸入第一個浮點數:");
            input = Console.ReadLine(); //Read string from keyboad
            w = double.Parse(input);    //Convert string into double
            Console.WriteLine("請輸入第二個浮點數:");
            input = Console.ReadLine();
            z = double.Parse(input);
            Console.WriteLine("Sum of two input double ={0}", w + z);
            Console.Read();
        }
    }
}
