using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_16_delegate1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] arr = {1,-3,7,-8,4,9,5,-6,2,-10};
            Console.WriteLine("=====Original Order!====");
            PrintArr(arr);
            Console.WriteLine("=====由小排到大!====");
            BubbleSortAsc(arr);
            PrintArr(arr);
            Console.WriteLine("=====由大排到小!====");
            BubbleSortDesc(arr);
            PrintArr(arr);
            Console.WriteLine("=====依絕對值由小排到大!====");
            BubbleSortAbsAsc(arr);
            PrintArr(arr);
            Console.WriteLine("=====依絕對值由大排到小!====");
            BubbleSortAbsDesc(arr);
            PrintArr(arr);
            Console.Read();

        }
       
        static public void BubbleSortAsc(int [] data)
        {
            for (int pass = 0; pass < data.Length; pass++)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i]>data[i + 1])
                    {
                        int temp;
                        temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;

                    }
                }
            }
        }
        static public void BubbleSortDesc(int[] data)
        {
            for (int pass = 0; pass < data.Length; pass++)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] < data[i + 1])
                    {
                        int temp;
                        temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;

                    }
                }
            }
        }
        static public void BubbleSortAbsAsc(int[] data)
        {
            for (int pass = 0; pass < data.Length; pass++)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (Math.Abs(data[i]) > Math.Abs(data[i + 1]))
                    {
                        int temp;
                        temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;

                    }
                }
            }
        }
        static public void BubbleSortAbsDesc(int[] data)
        {
            for (int pass = 0; pass < data.Length; pass++)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (Math.Abs(data[i]) < Math.Abs(data[i + 1]))
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
