/**************************************************
 * Two Dimension Array
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
            // Declare a single-dimensional array and 
           
            int[,] array1 = new int[3, 4] { { 1, 2, 3, 4 }, { 3, 4, 5, 6 }, { 5, 6, 7, 8 } };
            int[,] array2 = new int[,] { { 1, 2, 3 }, { 3, 4, 5  }, { 5, 6, 7 } };
            int[,] array3 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            
            //find the maxmum
            Console.WriteLine("Elements of Array are:");
            arrayPrint(array1);
            Console.WriteLine();
            arrayPrint(array2);
            Console.WriteLine();
            arrayPrint(array3);
            Console.WriteLine();

           
            Console.Read();
        }

        /// <summary>
        /// Print the array 
        /// </summary>
        /// <param name="arr"></param>
        static void arrayPrint(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
