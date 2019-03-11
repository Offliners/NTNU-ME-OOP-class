/***************************************
 * CH06_16_delegate2     利用委託實現傳方法到另一個方法中
 * Author: S.D. Wu
 * Date: 2014/4/29
 * 
 * ****************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_16_delegate2
{
    class Program
    {
        public delegate bool CompareFun(int num1,int num2);
        static void Main(string[] args)
        {
            int[] arr = {1,-3,7,-8,4,9,5,-6,2,-10};
            Console.WriteLine("=====Original Order!====");
            PrintArr(arr);
            Console.WriteLine("=====由小排到大!====");
            BubbleSort(arr, Ascent);
            PrintArr(arr);
            Console.WriteLine("=====由大排到小!====");
            BubbleSort(arr, Descent);
            PrintArr(arr);
            Console.WriteLine("=====依絕對值由小排到大!====");
            BubbleSort(arr, AbsAscent);
            PrintArr(arr);
            Console.WriteLine("=====依絕對值由大排到小!====");
            BubbleSort(arr, AbsDescent);
            PrintArr(arr);
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
