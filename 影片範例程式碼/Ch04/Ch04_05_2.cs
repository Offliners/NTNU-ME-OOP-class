/**************************************************
 * jagged Array and Multidimenisonal array
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
            int[][] jaggedArray = new int[][] 
            {
                new int[] {1, 3, 5, 7},
                new int[] {0, 2, 4, 6},
                new int[] {11, 22, 33, 44}
            };
            // Declare two dimensional array
            int[,] Array2D = {{1, 3, 5, 7},{0, 2, 4, 6},{11, 22, 33, 44}};
            
            Console.WriteLine("Elements of Jagged Array are:");
            arrayPrint(jaggedArray);
            Console.WriteLine("Elements of Two Dimensional Array are:");
            arrayPrint(Array2D);
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

        static void arrayPrint(int[,] arr)
        {
            for (int i = 0 ; i < arr.GetLength(0); i++ )
            {
                for (int j = 0; j < arr.GetLength(1);j++ )
                {
                    Console.Write("{0,3} ", arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
