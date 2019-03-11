/**************************************************
 * jagged Array
 * Author: S.D. Wu
 * Date: 2014/3/3
 * ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04
{
    class Ch04_01
    {
        static void Main(string[] args)
        {
            // Declare jagged array 
            int[][] jaggedArray1 = new int[3][];
            jaggedArray1[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray1[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray1[2] = new int[] { 11, 22, 33 };

            // // Declare jagged array 


            int[][] jaggedArray2 = new int[][] 
            {
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                new int[] {11, 22, 33, 44, 55, 66}
            };
            
            //find the maxmum
            Console.WriteLine("Elements of Array are:");
            //using foreach to print jagged array
            arrayPrint(jaggedArray1);
            Console.WriteLine();
            arrayPrint(jaggedArray2);
            Console.WriteLine();
            Console.WriteLine("Elements of Array are:");
            //using for loop to print jagged array
            arrayPrint2(jaggedArray1);
            Console.WriteLine();
            arrayPrint2(jaggedArray2);
            Console.WriteLine();    

            Console.Read();
        }

        /// <summary>
        /// Print the array using foreach loop
        /// </summary>
        /// <param name="arr"></param>
        static void arrayPrint(int[][] arr)
        {
            foreach(var row in arr)
            {
                foreach (var element in row)
                {
                    Console.Write("{0,3} ", element);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Print the array using foreach loop
        /// </summary>
        /// <param name="arr"></param>

        static void arrayPrint2(int[][] arr)
        {
            for (int i = 0 ; i < arr.Length; i++ )
            {
                for (int j = 0; j < arr[i].Length;j++ )
                {
                    Console.Write("{0,3} ", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
