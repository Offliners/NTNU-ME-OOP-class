/***************************************
 * CH06_16_delegate3     委託陣列
 * Author: S.D. Wu
 * Date: 2014/4/29
 * 
 * ****************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_16_delegate3
{
    class Program
    {
        public delegate bool CompareFun(int num1,int num2);
        public static CompareFun[] cmpFunArr = { Ascent, Descent, AbsAscent, AbsDescent };
        public static string[] str = { "由小排到大", "由大排到小", "依絕對值由小排到大", "依絕對值由大排到小" };
        static void Main(string[] args)
        {
            int[] arr = {1,-3,7,-8,4,9,5,-6,2,-10};
            Console.WriteLine("=====Original Order!====");
            PrintArr(arr);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("====={0}!====",str[i]);
                BubbleSort(arr, cmpFunArr[i]);
                PrintArr(arr);
            }
            Console.Read();

        }
        
        static public bool Ascent(int num1, int num2)
        {
            return num1 > num2;
        }

        static public bool Descent(int num1, int num2)
        {
            return num1 < num2;
        }
        static public bool AbsAscent(int num1, int num2)
        {
            return Math.Abs(num1) > Math.Abs(num2);
        }
        static public bool AbsDescent(int num1, int num2)
        {
            return Math.Abs(num1) < Math.Abs(num2);
        }

        static public void BubbleSort(int [] data, CompareFun cmp)
        {
            for (int pass = 0; pass < data.Length; pass++)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (cmp(data[i], data[i + 1]))
                    {
                        int temp;
                        temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                    }
                }
            }
        }
        
        static private void PrintArr(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();
        }
    }
}
