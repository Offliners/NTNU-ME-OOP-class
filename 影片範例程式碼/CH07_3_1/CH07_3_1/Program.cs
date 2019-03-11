/***********************************************
 * Ch07_3_1
 * call by value v.s. call by reference: swap
 * Author: S. D. Wu
 * Date: 2014/5/8
 * 
 * **********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07_3_1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine("=======交換前!=====");
            Console.WriteLine("(a,b)=({0},{1})",num1,num2);
            Console.WriteLine("=======呼叫 Swap 函數後 (Call by Value)=====");
            Swap(num1, num2);
            Console.WriteLine("(a,b)=({0},{1})", num1, num2);
            Console.WriteLine("=======呼叫 Swapr 函數後 (Call by Reference)=====");
            Swapr(ref num1, ref num2);
            Console.WriteLine("(a,b)=({0},{1})", num1, num2);
            Console.ReadKey();
        }
        //call by value
        static void Swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        //call by reference
        static void Swapr(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
