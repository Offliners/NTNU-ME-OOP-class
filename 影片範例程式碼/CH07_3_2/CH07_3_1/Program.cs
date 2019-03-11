/***********************************************
 * Ch07_3_1
 * call by value v.s. call by reference: swap complex number
 * Author: S. D. Wu
 * Date: 2014/5/8
 * 
 * **********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07_3_2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Complex num1 = new Complex(1,2);
            Complex num2 = new Complex(2,1);
            Console.WriteLine("=======交換前!=====");
            Console.WriteLine("(a,b)=({0},{1})",num1.ToString(),num2.ToString());
           
            Console.WriteLine("=======呼叫 Swap 函數後 (Call by Value)=====");
            Complex.Swap(num1, num2);
            Console.WriteLine("(a,b)=({0},{1})", num1.ToString(), num2.ToString());
            
            Console.WriteLine("=======呼叫 Swapr 函數後 (Call by Reference)=====");
            Complex.Swapr(ref num1, ref num2);
            Console.WriteLine("(a,b)=({0},{1})", num1.ToString(), num2.ToString());
            Console.ReadKey();
        }
    }
}
